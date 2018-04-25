using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
{
    public class RegionManager
    {
        public List<RegionEntity> GetAll()
        {
            try
            {
                //
                List<RegionEntity> regionEntities = new List<RegionEntity>();
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                List<tblRegion> regions = entity.tblRegions.ToList();

                foreach (tblRegion region in regions)
                {
                    RegionEntity regionEntity = new RegionEntity();
                    regionEntity.ID = region.ID;
                    regionEntity.TItle = region.TItle;

                    regionEntities.Add(regionEntity);
                }

                return regionEntities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Save(RegionEntity regionEntity)
        {
            try
            {
                //
                tblRegion region = new tblRegion();
                region.ID = regionEntity.ID;
                region.TItle = regionEntity.TItle;

                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                entity.tblRegions.Add(region);
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(RegionEntity regionEntity)
        {
            try
            {
                //
                tblRegion newRegion = new tblRegion();
                newRegion.ID = regionEntity.ID;
                newRegion.TItle = regionEntity.TItle;

                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                tblRegion oldRegion = entity.tblRegions.Where(x => x.ID == regionEntity.ID).FirstOrDefault();

                entity.Entry(oldRegion).CurrentValues.SetValues(newRegion);
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int RegionID)
        {
            try
            {
                //
                CondominiumManagementSystemDBEntities entity = new CondominiumManagementSystemDBEntities();
                tblRegion oldRegion = entity.tblRegions.Where(x => x.ID == RegionID).FirstOrDefault();

                entity.tblRegions.Remove(oldRegion);
                entity.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
