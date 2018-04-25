using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntity;
using BusinessLogic;

namespace Condominium_Management_System.Controllers
{
    [Authorize]
    public class HouseController : ApiController
    {
        private string IsValid(Models.HousePostModel houseModel)
        {
            if (houseModel.BlockNumber == string.Empty)
            {
                return "Please enter Block Number";
            }
            else if (houseModel.RegionID == 0)
            {
                return "Please enter Region";
            }
            else if (houseModel.SubCityID == 0)
            {
                return "Please enter SubCity";
            }
            else if (houseModel.WoredaID == 0)
            {
                return "Please enter Woreda";
            }
            else
            {
                return string.Empty;
            }
        }

        [Route("api/House/Save")]
        [HttpPost]
        public string Save(Models.HousePostModel houseModel)
        {
            try
            {
                string result = IsValid(houseModel);
                if (result == string.Empty)
                {
                    BusinessLogic.HouseManager houseManager = new HouseManager();
                    HouseEntity houseEntity = new HouseEntity();
                    houseEntity.ID = houseModel.ID;
                    houseEntity.RegionID = houseModel.RegionID;
                    houseEntity.SubCityID = houseModel.SubCityID;
                    houseEntity.WoredaID = houseModel.WoredaID;
                    houseEntity.SiteName = houseModel.SiteName;
                    houseEntity.BlockNumber = houseModel.BlockNumber;
                    houseEntity.FloorNumber = houseModel.FloorNumber;
                    houseEntity.GovernmentTransferedDate = houseModel.GovernmentTransferedDate;
                    houseEntity.HouseNumber = houseModel.HouseNumber;

                    if (houseManager.Save(houseEntity) == true)
                    {
                        return "Saved";
                    }
                    else
                    {
                        return "Failed";
                    }
                }
                else
                {
                    return result;
                }

            }
            catch (Exception)
            {
                return "Failed";
            }
        }

        [AllowAnonymous]
        [Route("api/House/GetAll")]
        [HttpGet]
        public List<Models.HouseModel> GetAll()
        {
            try
            {
                List<Models.HouseModel> houseModels = new List<Models.HouseModel>();
                HouseManager houseManager = new HouseManager();
                List<HouseEntity> houseEntities = houseManager.GetAll();

                foreach (HouseEntity houseEntity in houseEntities)
                {
                    Models.HouseModel houseModel = new Models.HouseModel();
                    houseModel.ID = houseEntity.ID;
                    houseModel.RegionID = houseEntity.RegionID;
                    houseModel.SubCityID = houseEntity.SubCityID;
                    houseModel.WoredaID = houseEntity.WoredaID;
                    houseModel.SiteName = houseEntity.SiteName;
                    houseModel.BlockNumber = houseEntity.BlockNumber;
                    houseModel.FloorNumber = houseEntity.FloorNumber;
                    houseModel.GovernmentTransferedDate = houseEntity.GovernmentTransferedDate;
                    houseModel.HouseNumber = houseEntity.HouseNumber;

                    houseModel.RegionModel = new Models.RegionModel();
                    houseModel.RegionModel.ID = houseEntity.RegionEntity.ID;
                    houseModel.RegionModel.TItle = houseEntity.RegionEntity.TItle;

                    houseModel.SubCityModel = new Models.SubCityModel();
                    houseModel.SubCityModel.ID = houseEntity.SubCityEntity.ID;
                    houseModel.SubCityModel.TItle = houseEntity.SubCityEntity.TItle;

                    houseModel.WoredaModel = new Models.WoredaModel();
                    houseModel.WoredaModel.ID = houseEntity.WoredaEntity.ID;
                    houseModel.WoredaModel.TItle = houseEntity.WoredaEntity.TItle;

                    houseModels.Add(houseModel);
                }

                return houseModels;
            }
            catch (Exception)
            {
                return null;
            }
        }


        [Route("api/House/Update")]
        [HttpPost]
        public string Update(Models.HousePostModel houseModel)
        {
            try
            {
                string result = IsValid(houseModel);
                if (result == string.Empty)
                {
                    BusinessLogic.HouseManager houseManager = new HouseManager();
                    HouseEntity houseEntity = new HouseEntity();
                    houseEntity.ID = houseModel.ID;
                    houseEntity.RegionID = houseModel.RegionID;
                    houseEntity.SubCityID = houseModel.SubCityID;
                    houseEntity.WoredaID = houseModel.WoredaID;
                    houseEntity.SiteName = houseModel.SiteName;
                    houseEntity.BlockNumber = houseModel.BlockNumber;
                    houseEntity.FloorNumber = houseModel.FloorNumber;
                    houseEntity.GovernmentTransferedDate = houseModel.GovernmentTransferedDate;
                    houseEntity.HouseNumber = houseModel.HouseNumber;

                    if (houseManager.Update(houseEntity) == true)
                    {
                        return "Saved";
                    }
                    else
                    {
                        return "Failed";
                    }
                }
                else
                {
                    return result;
                }

            }
            catch (Exception)
            {
                return "Failed";
            }
        }

        [Route("api/House/Delete")]
        [HttpPost]
        public string Delete(Models.HousePostModel houseModel)
        {
            try
            {
                BusinessLogic.HouseManager houseManager = new HouseManager();
                if (houseManager.Delete(houseModel.ID) == true)
                {
                    return "Saved";
                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception)
            {
                return "Failed";
            }
        }

    }
}
