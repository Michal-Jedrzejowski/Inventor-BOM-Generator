using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ListGenerator2000.Models
{
    public enum HiddenStatus { InventorPart, XMLPart, DeletedPart}
    //public enum BomStructureE {
    //    [Description("Purchased")] Purchased,
    //    [Description("Purchased/Normal")] PurchasedNormal, 
    //    [Description("Normal")] Normal
    //}

    public class InventorPart
    {
        public string BomStructure { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Material { get; set; }
        public string StockNumber { get; set; }
        public string Vendor { get; set; }
        public string Comments { get; set; }
        public string State { get; set; }
        public int Version { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public bool Visibility { get; set; }
        public HiddenStatus HiddenStatus { get; set; }
        public int UpdateCounter { get; set; }

        public bool Equals(InventorPart part)
        {
            if (part.PartNumber == PartNumber)
            {
                Quantity++;
                return true;
            }
            return false;
        }

        public void Update()
        {
            this.UpdateCounter++;
        }

    }

}
