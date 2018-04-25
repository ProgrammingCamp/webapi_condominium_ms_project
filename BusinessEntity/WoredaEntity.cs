using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class WoredaEntity
    {
        public int ID { get; set; }
        public int SubCityID { get; set; }
        public string TItle { get; set; }

        public SubCityEntity SubCityEntity { get; set; }
    }
}
