using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class HouseEntity
    {
        public int ID { get; set; }
        public int RegionID { get; set; }
        public int SubCityID { get; set; }
        public int WoredaID { get; set; }
        public string BlockNumber { get; set; }
        public int FloorNumber { get; set; }
        public string HouseNumber { get; set; }
        public System.DateTime GovernmentTransferedDate { get; set; }
        public string SiteName { get; set; }

        public RegionEntity RegionEntity { get; set; }
        public SubCityEntity SubCityEntity { get; set; }
        public WoredaEntity WoredaEntity { get; set; }
    }
}
