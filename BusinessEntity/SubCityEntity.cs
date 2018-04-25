using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class SubCityEntity
    {
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string TItle { get; set; }

        public RegionEntity RegionEntity { get; set; }
    }
}
