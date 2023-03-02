using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGenerator2000.Models
{
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
    }
}
