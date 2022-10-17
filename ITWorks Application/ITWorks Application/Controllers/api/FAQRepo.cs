using ITWorks_Application.Data;
using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers.api
{
    public class FAQRepo
    {
        private readonly itworkxdevdatabaseContext _context = new itworkxdevdatabaseContext();

        public List<FAQDeviceCategoryData> GetAllFAQDeviceCategory()
        {
            List<FAQDeviceCategoryData> datas = _context.FaqdeviceCategoryData.Select(x => 
                new FAQDeviceCategoryData {
                    FAQDeviceCategoryID = x.FaqdeviceCategoryId,
                    FAQDeviceCategoryName = x.FaqdeviceCategoryName,
                    FAQDeviceCategoryImage = x.FaqdeviceCategoryImage,
                    FAQDeviceCategoryTXTCSS = x.FaqdeviceCategoryTxtcss,
                    FAQDeviceCategoryIMGCSS = x.FaqdeviceCategoryImgcss

                }).ToList();

            return datas;
        }
        public BrandModelData GetBrand(int BrandID)
        {
            BrandModelData data = (BrandModelData)_context.BrandModelData.Where(x => x.BrandId == BrandID)
                .Select(x => new BrandModelData()
                {
                    BrandID = BrandID,
                    BrandName = x.BrandName,
                    BrandImage = x.BrandImage
                });
            return data;
        }
        public List<BrandModelData> GetDeviceBrand(int DeviceID)
        {
            
            List<BrandDeviceData> list_of_deviceBrands = GetDeviceBrandPairs(DeviceID);

            List<BrandModelData> temp = _context.BrandModelData.Select(x => new BrandModelData()
            {
                BrandID = x.BrandId,
                BrandName = x.BrandName,
                BrandImage = x.BrandImage
            }).ToList();

            List<BrandModelData> modeldata = temp.Intersect(temp.Where(k => list_of_deviceBrands.Any(x => x.BrandID == k.BrandID))).ToList();
            return modeldata;
        }
        public List<BrandDeviceData> GetDeviceBrandPairs(int DeviceID)
        {
            List<BrandDeviceData> datas = _context.BrandDeviceData.Where(x => x.FaqdeviceCategoryId == DeviceID)
                .Select( x => new BrandDeviceData()
                {
                      FAQDeviceCategoryID = x.FaqdeviceCategoryId,
                      BrandDeviceID = x.BrandDeviceId,
                      BrandID = x.BrandId
                }).ToList();
            return datas;
        }
        public int GetDeviceBrandPairID(int BrandID, int FAQDeviceCategoryID)
        {
            return _context.BrandDeviceData.FirstOrDefault(x => x.BrandId == BrandID && x.FaqdeviceCategoryId == FAQDeviceCategoryID).BrandDeviceId;
        }
        public List<FixCategoryData> GetFixCategories(List<BrandDeviceFixCategoryData> brandDeviceFixCategoryDatas)
        {
            List<FixCategoryData> temp = _context.FixCategoryData.Select(x => new FixCategoryData()
            {
                FixCategoryID = x.FixCateogryId,
                FixCategoryName = x.FixCategoryName,
                FixCategoryContainer = x.FixCategoryContainer,
                FixCategoryImage = x.FixCategoryImage,
                FixCategoryIMGCSS = x.FixCategoryImgcss,
                FixCategoryTXTCSS = x.FixCategoryTxtcss
            }).ToList();

            return temp.Intersect(temp.Where(k => brandDeviceFixCategoryDatas.Any(x => x.FixCategoryID == k.FixCategoryID))).ToList();
        }
        public List<BrandDeviceFixCategoryData> GetBrandDeviceFixPairs(int BrandDeviceID)
        {
            List<BrandDeviceFixCategoryData> datas = _context.BrandDeviceFixCategoryData.Where(x => x.BrandDeviceId == BrandDeviceID)
                .Select(x => new BrandDeviceFixCategoryData()
                {
                    BrandDeviceID = Convert.ToInt32(x.BrandDeviceId),
                    FixCategoryID = Convert.ToInt32(x.FixCateogryId)
                }).ToList();
            return datas;
        }
        public List<FixData> GetFixDataByKeyword(string BrandDeviceID, string keyword)
        {
            List<FixData> temp = FakeDataController.list_of_fixModel.Where(x => x.BrandDeviceID == Convert.ToInt32(BrandDeviceID) && (x.FixTitle.ToLower().Contains(keyword) || x.FixDescription.ToLower().Contains(keyword))).ToList()
        }
    }
}
