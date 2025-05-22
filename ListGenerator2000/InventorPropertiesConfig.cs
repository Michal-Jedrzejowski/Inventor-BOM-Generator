using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGenerator2000
{
    public class IPropertyConfigurator
    {
        public IPropertyConfigurator(string name, int propid, string propertySetName)
        {
            Name = name;
            Propid = propid;
            PropertySetName = propertySetName;
        }
        public string Name { get; }
        public int Propid { get; }
        public string PropertySetName { get; }

        public static IPropertyConfigurator PartName = new IPropertyConfigurator("Part Number", 5, "Design Tracking Properties");
        public static IPropertyConfigurator Description = new IPropertyConfigurator("Description", 29, "Design Tracking Properties");
        public static IPropertyConfigurator Material = new IPropertyConfigurator("Material", 20, "Design Tracking Properties");
        public static IPropertyConfigurator StockNumber = new IPropertyConfigurator("Stock Number", 55, "Design Tracking Properties");
        public static IPropertyConfigurator Vendor = new IPropertyConfigurator("Vendor", 30, "Design Tracking Properties");
        public static IPropertyConfigurator Comments = new IPropertyConfigurator("Comments", 6, "Inventor Summary Information");
        public static IPropertyConfigurator Version = new IPropertyConfigurator("Version", 9, "Inventor Summary Information");

        public static List<IPropertyConfigurator> IPropertiesConfigurationList = new List<IPropertyConfigurator>()
        {
            PartName,
            Description,
            Material,
            StockNumber,
            Vendor,
            Comments,
            Version,
        };

    }

}