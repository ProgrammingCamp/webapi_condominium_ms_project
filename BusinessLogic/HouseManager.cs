using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
{
    public class HouseManager
    {
        public bool Save(HouseEntity houseEntity)
        {
            try
            {
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                tblHouse house = new tblHouse();
                house.ID = houseEntity.ID;
                house.RegionID = houseEntity.RegionID;
                house.SubCityID = houseEntity.SubCityID;
                house.WoredaID = houseEntity.WoredaID;
                house.BlockNumber = houseEntity.BlockNumber;
                house.FloorNumber = houseEntity.FloorNumber;
                house.GovernmentTransferedDate = houseEntity.GovernmentTransferedDate;
                house.HouseNumber = houseEntity.HouseNumber;
                house.SiteName = houseEntity.SiteName;

                entity.tblHouses.Add(house);
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(HouseEntity houseEntity)
        {
            try
            {
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                tblHouse newHouse = new tblHouse();
                newHouse.ID = houseEntity.ID;
                newHouse.RegionID = houseEntity.RegionID;
                newHouse.SubCityID = houseEntity.SubCityID;
                newHouse.WoredaID = houseEntity.WoredaID;
                newHouse.BlockNumber = houseEntity.BlockNumber;
                newHouse.FloorNumber = houseEntity.FloorNumber;
                newHouse.GovernmentTransferedDate = houseEntity.GovernmentTransferedDate;
                newHouse.HouseNumber = houseEntity.HouseNumber;
                newHouse.SiteName = houseEntity.SiteName;

                tblHouse oldHouse = entity.tblHouses.Where(x => x.ID == houseEntity.ID).FirstOrDefault();
                entity.Entry(oldHouse).CurrentValues.SetValues(newHouse);
                
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int houseID)
        {
            try
            {
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                tblHouse oldHouse = entity.tblHouses.Where(x => x.ID == houseID).FirstOrDefault();

                entity.tblHouses.Remove(oldHouse);
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HouseEntity> GetAll()
        {
            try
            {
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                List<HouseEntity> houseEntities = new List<HouseEntity>();
                List<tblHouse> houses = entity.tblHouses.ToList();

                foreach (tblHouse house in houses)
                {
                    HouseEntity houseEntity = new HouseEntity();
                    houseEntity.ID = house.ID;
                    houseEntity.RegionID = house.RegionID;
                    houseEntity.SubCityID = house.SubCityID;
                    houseEntity.WoredaID = house.WoredaID;
                    houseEntity.BlockNumber = house.BlockNumber;
                    houseEntity.FloorNumber = house.FloorNumber;
                    houseEntity.GovernmentTransferedDate = house.GovernmentTransferedDate;
                    houseEntity.HouseNumber = house.HouseNumber;
                    houseEntity.SiteName = house.SiteName;

                    houseEntity.RegionEntity = new RegionEntity();
                    houseEntity.RegionEntity.ID = house.tblRegion.ID;
                    houseEntity.RegionEntity.TItle = house.tblRegion.TItle;

                    houseEntity.SubCityEntity = new SubCityEntity();
                    houseEntity.SubCityEntity.ID = house.tblSubCity.ID;
                    houseEntity.SubCityEntity.TItle = house.tblSubCity.TItle;

                    houseEntity.WoredaEntity = new WoredaEntity();
                    houseEntity.WoredaEntity.ID = house.tblWoreda.ID;
                    houseEntity.WoredaEntity.TItle = house.tblWoreda.TItle;

                    houseEntities.Add(houseEntity);
                }

                return houseEntities;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
