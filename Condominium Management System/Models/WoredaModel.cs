using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Condominium_Management_System.Models
{
    public class WoredaModel
    {
        public int ID { get; set; }
        public int SubCityID { get; set; }
        public string TItle { get; set; }

        public SubCityModel SubCityModel { get; set; }
    }
}