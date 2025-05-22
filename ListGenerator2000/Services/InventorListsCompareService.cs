using ListGenerator2000.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGenerator2000.Services
{
    class InventorListsCompareService
    {
        private readonly List<InventorPart> _inventorParts = new List<InventorPart>();
        
        public List<InventorPart> ListCompare(List<InventorPart> newList, List<InventorPart> oldList)
        {
            _inventorParts.Clear();
            //_inventorParts = new List<InventorPart>(oldList);

            int counter = 0;
            foreach (InventorPart newRecord in newList)
            {
                InventorPart oldRecord = oldList.Where(p => p.PartNumber == newRecord.PartNumber).FirstOrDefault();
                int n = oldList.FindIndex(p => p.PartNumber == newRecord.PartNumber);
                oldRecord = oldList[n];
                //1. check for null and add record
                if (oldRecord is null)
                {
                    _inventorParts.Add(newRecord);
                    counter++;
                    continue;
                }

                //.2-1. if new version is added - put new part to the list
                if (newRecord.Version > oldRecord.Version)
                {
                    _inventorParts.Add(newRecord);
                }
                //2-2. if version is the same - 
                else if (newRecord.Version == oldRecord.Version)
                {
                    if (newRecord.Comments != oldRecord.Comments & newRecord.Comments != "")
                    {
                        oldRecord.Comments += "/n" + newRecord.Comments;
                    }

                    if (newRecord.Quantity > oldRecord.Quantity)
                    {
                        if (oldRecord.State is null || oldRecord.State == "")
                        {
                            oldRecord.Quantity = newRecord.Quantity;
                        }
                        else
                        {
                            oldRecord.Comments = "Liczba nowych detali = " + (newRecord.Quantity - oldRecord.Quantity).ToString() + "\n" + oldRecord.Comments;
                            oldRecord.Quantity = newRecord.Quantity;
                        }
                    }
                    else if (newRecord.Quantity < oldRecord.Quantity)
                    {
                        oldRecord.Quantity = newRecord.Quantity;
                    }
                    oldRecord.Vendor = newRecord.Vendor;
                    _inventorParts.Add(oldRecord);
                }
                //if new version is lower turn off visibility but keep item in the list
                else
                {
                    oldRecord.Visibility = false;
                    _inventorParts.Add(oldRecord);
                }
                

            }

            return _inventorParts;
        }

        
    }
}
