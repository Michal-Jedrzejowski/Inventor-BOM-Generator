using ListGenerator2000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace ListGenerator2000.Services
{
    public class InventorViewerService
    {
        public List<InventorPart> GetInventorParts(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new Exception("File not specify.");

            Inventor.ApprenticeServerComponent objapprenticeServerApp = new Inventor.ApprenticeServerComponentClass();
            Inventor.ApprenticeServerDocument invDocObj = objapprenticeServerApp.Open(fileName);

            var inventorParts = GenerateBom(invDocObj.ComponentDefinition);
            return inventorParts;
        }

        private List<InventorPart> GenerateBom(Inventor.ComponentDefinition invComp)
        {

            var inventorParts = new List<InventorPart>();
            if (invComp.Type == Inventor.ObjectTypeEnum.kAssemblyComponentDefinitionObject)
            {
                if (invComp.BOMStructure == Inventor.BOMStructureEnum.kNormalBOMStructure)
                {
                    foreach (Inventor.ComponentOccurrence occ in invComp.Occurrences)
                    {
                        var parts = GenerateBom(occ.Definition);
                        inventorParts.AddRange(parts);
                    }
                }
                else if (invComp.BOMStructure == Inventor.BOMStructureEnum.kPurchasedBOMStructure)
                {
                    inventorParts.Add(GenerateBOMRow(invComp));
                }
            }
            else if (invComp.Type == Inventor.ObjectTypeEnum.kPartComponentDefinitionObject)
            {
                inventorParts.Add(GenerateBOMRow(invComp));
            }

            return inventorParts;
        }

        private InventorPart GenerateBOMRow(Inventor.ComponentDefinition invCompDef)
        {
            Inventor.ApprenticeServerDocument inventorDocument = (Inventor.ApprenticeServerDocument)invCompDef.Document;
            string _bomStructureType = "";
            InventorPropertiesConfig propConfig = new InventorPropertiesConfig();

            string[] properties = { "Part Number", "Description", "Material", "Stock Number", "Vendor", "Comments" }; //na razie na sztywno
            List<string> inventorProperties = IProperties(inventorDocument.PropertySets, propConfig.GetIPropConfig(properties));

            if (invCompDef.BOMStructure == Inventor.BOMStructureEnum.kPurchasedBOMStructure)
            {
                _bomStructureType = "Purchased";
                inventorProperties[2] = "";
            }
            else if (invCompDef.BOMStructure == Inventor.BOMStructureEnum.kNormalBOMStructure)
            {
                if (inventorProperties[3] != "")
                {
                    _bomStructureType = "Purchased/Normal";
                    inventorProperties[2] = inventorProperties[3];
                }
                else
                {
                    _bomStructureType = "Normal";
                }
            }
            return new InventorPart()
            {
                BomStructure = _bomStructureType,
                PartNumber = inventorProperties[0],
                Description = inventorProperties[1],
                Quantity = 1,
                Material = inventorProperties[2],
                Vendor = inventorProperties[4],
                Comments = inventorProperties[5],
                State = "",
            };
        }

        private List<string> IProperties(Inventor.PropertySets propertySets, List<Tuple<int, string>> propertyTypes)
        {
            IEnumerable<Inventor.PropertySet> propertySetEnum = propertySets.Cast<Inventor.PropertySet>();
            List<string> listOfProperties = new List<string>();

            Inventor.PropertySet propertySet;
            Inventor.Property property;

            foreach (Tuple<int, string> propertyType in propertyTypes)
            {
                propertySet = propertySetEnum.Where(p => p.Name == propertyType.Item2).FirstOrDefault();
                property = propertySet.ItemByPropId[propertyType.Item1];
                listOfProperties.Add(property.Value.ToString());
            }

            return listOfProperties;
        }
    }
}
