using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bifarmdetailsrtrClass
    {
      public string itemcode { get; set; }
      public string itemname { get; set; }
      public double totalarea { get; set; }
      public string crop { get; set; }
      public double estimatedyield { get; set; }
      public DateTime dos { get; set; }
      public string doh { get; set; }
      public string irrigatedtype { get; set; }
        public string nurserytype { get; set; }
        public double nurseryqty { get; set; }
        public string company { get; set; }
        public string batchno { get; set; }
        public string ncropnorth { get; set; }
        public string ncropsouth { get; set; }
        public string ncropeast { get; set; }
        public string ncropwest { get; set; }
        public string bordercrop { get; set; }
        public string trapcrop { get; set; }
        public string pheromonecrop { get; set; }
        public string stickytrap { get; set; }


        public bifarmdetailsrtrClass(string item_code, string item_name, double total_area, string _crop, double estimated_yeild, DateTime dos_, string doh_, string irrigated_type, string nursery_type, double nursery_qty, string company_, string batch_no, string ncrop_north, string ncrop_south, string ncrop_east, string ncrop_west, string border_crop, string trap_corp, string pheromone_crop, string sticky_trap)
        {
            itemcode = item_code;
            itemname = item_name;
            totalarea = total_area;
            crop = _crop;
          estimatedyield = estimated_yeild;
            dos = dos_;
            doh = doh_;
          irrigatedtype = irrigated_type;
          nurserytype = nursery_type;
          nurseryqty = nursery_qty;
          batchno = batch_no;
          company = company_;
          ncropnorth = ncrop_north;
            ncropsouth = ncrop_south;
            ncropeast = ncrop_east;
            ncropwest = ncrop_west;
            bordercrop = border_crop;
            trapcrop = trap_corp;
            pheromonecrop = pheromone_crop;
            stickytrap = sticky_trap;
        }
    }
}