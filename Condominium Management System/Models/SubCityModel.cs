using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Condominium_Management_System.Models
{
    public class SubCityModel
    {
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string TItle { get; set; }

        public RegionModel RegionModel { get; set; }
    }
}