using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListGenerator2000
{
    public class InventorPropertiesConfig
    {
        private Dictionary<string, Tuple<int, string>> iPropConfig = new Dictionary<string, Tuple<int, string>>();

        public InventorPropertiesConfig()
        {
            SetIPropConfig();
        }

        private void SetIPropConfig()
        {   
            iPropConfig.Add("Part Number", Tuple.Create(5, "Design Tracking Properties"));
            iPropConfig.Add("Description", Tuple.Create(29, "Design Tracking Properties"));
            iPropConfig.Add("Material", Tuple.Create(20, "Design Tracking Properties"));
            iPropConfig.Add("Stock Number", Tuple.Create(55, "Design Tracking Properties"));
            iPropConfig.Add("Vendor", Tuple.Create(30, "Design Tracking Properties"));
            iPropConfig.Add("Comments", Tuple.Create(6, "Inventor Summary Information"));
        }       

        public List<Tuple<int, string>> GetIPropConfig(string[] keyArray)
        {
            List<Tuple<int, string>> tempIProp = new List<Tuple<int, string>>();
            foreach (string key in keyArray)
            {
                tempIProp.Add(iPropConfig.Where(x => x.Key == key).FirstOrDefault().Value);
            }
            return tempIProp;
        }

    }



}
