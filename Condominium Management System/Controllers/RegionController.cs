using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic;
using BusinessEntity;

namespace Condominium_Management_System.Controllers
{
    public class RegionController : ApiController
    {
        [Route("api/Region/GetAll")]
        [HttpGet]
        public List<Models.RegionModel> GetAll()
        {
            try
            {
                List<Models.RegionModel> regionModels = new List<Models.RegionModel>();

                RegionManager regionManager = new RegionManager();
                List<RegionEntity> regionEntities = regionManager.GetAll();

                foreach (RegionEntity regionEntity in regionEntities)
                {
                    Models.RegionModel regionModel = new Models.RegionModel();
                    regionModel.ID = regionEntity.ID;
                    regionModel.TItle = regionEntity.TItle;

                    regionModels.Add(regionModel);
                }

                return regionModels;

            }
            catch (Exception)
            {
                return null;
            }
        }

        [Route("api/Region/Save")]
        [HttpPost]
        public bool Save(Models.RegionModel regionModel)
        {
            try
            {
                RegionManager regionManager = new RegionManager();
                RegionEntity regionEntity = new RegionEntity();
                regionEntity.ID = regionModel.ID;
                regionEntity.TItle = regionModel.TItle;

                if(regionManager.Save(regionEntity) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Route("api/Region/Update")]
        [HttpPost]
        public bool Update(Models.RegionModel regionModel)
        {
            try
            {
                RegionManager regionManager = new RegionManager();
                RegionEntity regionEntity = new RegionEntity();
                regionEntity.ID = regionModel.ID;
                regionEntity.TItle = regionModel.TItle;

                regionManager.Update(regionEntity);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Route("api/Region/Delete")]
        [HttpPost]
        public bool Delete(Models.RegionModel regionModel)
        {
            try
            {
                RegionManager regionManager = new RegionManager();
                regionManager.Delete(regionModel.ID);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
