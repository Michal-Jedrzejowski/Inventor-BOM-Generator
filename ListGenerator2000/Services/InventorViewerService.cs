using ListGenerator2000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace ListGenerator2000.Services
{
    public class InventorViewerService
    {
        private bool _stopRecursion;
        bool _error_skip = false;
        private List<InventorPart> _inventorParts = new List<InventorPart>();

        public object EnumFormat { get; private set; }

        public List<InventorPart> GetInventorParts(string fileName)
        {
            _inventorParts.Clear();
            if (string.IsNullOrEmpty(fileName))
                throw new Exception("File not specify.");

            Inventor.ApprenticeServerComponent objapprenticeServerApp = new Inventor.ApprenticeServerComponentClass();
            Inventor.ApprenticeServerDocument invDocObj = objapprenticeServerApp.Open(fileName);

            _stopRecursion = false;
            GenerateBom(invDocObj.ComponentDefinition);
            var inventorParts = _inventorParts;

            return inventorParts;
        }

        private void GenerateBom(Inventor.ComponentDefinition invComp)
        {
            if (invComp.Type == Inventor.ObjectTypeEnum.kAssemblyComponentDefinitionObject && !_stopRecursion)
            {
                if (invComp.BOMStructure == Inventor.BOMStructureEnum.kNormalBOMStructure)
                {
                    foreach (Inventor.ComponentOccurrence occ in invComp.Occurrences)
                    {
                        if (_stopRecursion) return;
                        try
                        {
                            GenerateBom(occ.Definition);
                        }
                        catch (COMException e)
                        {
                            if ((uint)e.ErrorCode == 0x80004005)
                            {
                                if (_error_skip)
                                {
                                    break;
                                }
                                DialogResult result;

                                result = MessageBox.Show("Unresolved document detected. Do you want to continue?",
                                    "Error jak chuj",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error);

                                if (result == DialogResult.No)
                                {
                                    _stopRecursion = true;
                                    _inventorParts = new List<InventorPart>();
                                    return;
                                }
                                else
                                {
                                    _error_skip = true;
                                }
                            }
                        }
                        
                    }
                }
                else if (invComp.BOMStructure == Inventor.BOMStructureEnum.kPurchasedBOMStructure)
                {
                    if (!CheckIfVersionAdded(invComp))
                        return;
                    InventorPart part = GenerateBOMRow(invComp);
                    bool equal = false;

                    foreach (InventorPart listedpart in _inventorParts)
                    {
                        if (listedpart.Equals(part))
                        {
                            equal = true;
                            break;
                        }
                    }

                    if (!equal) _inventorParts.Add(part);
                }
            }
            else if (invComp.Type == Inventor.ObjectTypeEnum.kPartComponentDefinitionObject)
            {
                if (!CheckIfVersionAdded(invComp))
                    return;
                InventorPart part = GenerateBOMRow(invComp);
                bool equal = false;
                foreach (InventorPart listedpart in _inventorParts)
                {
                    if (listedpart.Equals(part))
                    {
                        equal = true;
                        break;
                    }
                }
                if (!equal & part.PartNumber.Length != 0) _inventorParts.Add(part);
            }
        }

        private InventorPart GenerateBOMRow(Inventor.ComponentDefinition invCompDef)
        {
            Inventor.ApprenticeServerDocument inventorDocument = (Inventor.ApprenticeServerDocument)invCompDef.Document;
            string _bomStructureType = "";

            Dictionary<string, string> inventorProperties = IProperties(inventorDocument.PropertySets);

            if (invCompDef.BOMStructure == Inventor.BOMStructureEnum.kPurchasedBOMStructure)
            {
                _bomStructureType = "Purchased";
                inventorProperties[IPropertyConfigurator.Material.Name] = "";
            }
            else if (invCompDef.BOMStructure == Inventor.BOMStructureEnum.kNormalBOMStructure)
            {
                if (inventorProperties[IPropertyConfigurator.StockNumber.Name] != "")
                {
                    _bomStructureType = "Purchased/Normal";
                    inventorProperties[IPropertyConfigurator.Material.Name] = inventorProperties[IPropertyConfigurator.StockNumber.Name];
                }
                else
                {
                    _bomStructureType = "Normal";
                }
            }

            bool visibility;
            if (Int32.Parse(inventorProperties["Version"]) == 0)
                return new InventorPart()
                {
                    PartNumber = "",
                    Vendor = ""
                };
            else
                visibility = true;

            return new InventorPart()
            {
                BomStructure = _bomStructureType,
                PartNumber = inventorProperties[IPropertyConfigurator.PartName.Name],
                Description = inventorProperties[IPropertyConfigurator.Description.Name],
                Quantity = 1,
                Material = inventorProperties[IPropertyConfigurator.Material.Name],
                Vendor = inventorProperties[IPropertyConfigurator.Vendor.Name],
                Comments = inventorProperties[IPropertyConfigurator.Comments.Name],
                State = "",
                Version = Int32.Parse(inventorProperties[IPropertyConfigurator.Version.Name]),
                Path = inventorDocument.FullFileName,
                Visibility = visibility,
                UpdateCounter = 1,
            };
        }

        private Dictionary<string, string> IProperties(Inventor.PropertySets propertySets)
        {
            IEnumerable<Inventor.PropertySet> propertySetEnum = propertySets.Cast<Inventor.PropertySet>();
            Dictionary<string, string> listOfProperties = new Dictionary<string, string>() {
                {"Part Number","" },
                {"Description","" },
                {"Material", "" },
                {"Stock Number", "" },
                {"Vendor", "" },
                {"Comments", "" },
                {"Version", "" },
            }; 
 

            Inventor.PropertySet propertySet;
            Inventor.Property property;

            foreach (IPropertyConfigurator propertyConfigurator in IPropertyConfigurator.IPropertiesConfigurationList)
            {
                try
                {
                    propertySet = propertySetEnum.Where(p => p.Name == propertyConfigurator.PropertySetName).FirstOrDefault();
                    property = propertySet.ItemByPropId[propertyConfigurator.Propid];
                    listOfProperties[propertyConfigurator.Name] = property.Value.ToString();
                }
                catch
                {
                    listOfProperties[propertyConfigurator.Name] = "0";
                }
            }

            return listOfProperties;
        }

        private bool CheckIfVersionAdded(Inventor.ComponentDefinition invCompDef)
        {
            Inventor.ApprenticeServerDocument inventorDocument = (Inventor.ApprenticeServerDocument)invCompDef.Document;
            IEnumerable<Inventor.PropertySet> propertySetEnum = inventorDocument.PropertySets.Cast<Inventor.PropertySet>();

            Inventor.PropertySet propertySet;
            Inventor.Property property;
            try
            {
                propertySet = propertySetEnum.Where(p => p.Name == IPropertyConfigurator.Version.PropertySetName).FirstOrDefault();
                property = propertySet.ItemByPropId[IPropertyConfigurator.Version.Propid];
                if (Int32.Parse(property.Value.ToString()) != 0)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

    }
}
