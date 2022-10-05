﻿using ITWorks_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class FakeDataController : Controller
    {
        public static List<FAQDeviceCategoryModel> list_of_FAQ_Category = new List<FAQDeviceCategoryModel>()
        {
            new FAQDeviceCategoryModel { FAQDeviceCategoryID = 1, FAQDeviceCategoryName = "Mobile", FAQDeviceCategoryImage = "/img/mobile.svg", FAQDeviceCategoryTXTCSS = "mobile-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "mobile-img"},
            new FAQDeviceCategoryModel { FAQDeviceCategoryID = 2, FAQDeviceCategoryName = "Laptop", FAQDeviceCategoryImage = "/img/laptop.svg", FAQDeviceCategoryTXTCSS = "laptop-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "laptop-img"},
            new FAQDeviceCategoryModel { FAQDeviceCategoryID = 3, FAQDeviceCategoryName = "Printer", FAQDeviceCategoryImage = "/img/printer.svg", FAQDeviceCategoryTXTCSS = "printer-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "printer-img"},
            new FAQDeviceCategoryModel { FAQDeviceCategoryID = 4, FAQDeviceCategoryName = "Home Appliances", FAQDeviceCategoryImage = "/img/homeappliance.svg", FAQDeviceCategoryTXTCSS = "home-appliances-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "homeappliance-img"}
        };
        public static List<BrandModel> list_of_brands = new List<BrandModel>()
        {
            new BrandModel { BrandID = 1, BrandName = "Apple", BrandImage = ""},
            new BrandModel { BrandID = 1, BrandName = "Samsung", BrandImage = "" },
            new BrandModel { BrandID = 1, BrandName = "Xiaomi", BrandImage = "" },
            new BrandModel { BrandID = 1, BrandName = "Huawei", BrandImage = "" },
        };
        public static List<BrandDeviceModel> list_of_deviceBrands = new List<BrandDeviceModel>()
        {
            new BrandDeviceModel { BrandDeviceID = 1, BrandID = 1, FAQDeviceCategoryID = 1 },
            new BrandDeviceModel { BrandDeviceID = 2, BrandID = 2, FAQDeviceCategoryID = 1 },
            new BrandDeviceModel { BrandDeviceID = 3, BrandID = 3, FAQDeviceCategoryID = 1 },
            new BrandDeviceModel { BrandDeviceID = 4, BrandID = 4, FAQDeviceCategoryID = 1 },
        };
        public static List<FixCategoryModel> list_of_fixCategory = new List<FixCategoryModel>()
        {
            new FixCategoryModel { FixCateogryID = 1, FixCategoryName = "Display" },
            new FixCategoryModel { FixCateogryID = 2, FixCategoryName = "Battery" },
            new FixCategoryModel { FixCateogryID = 3, FixCategoryName = "Password" },
            new FixCategoryModel { FixCateogryID = 4, FixCategoryName = "Camera" },
        };
        public static List<BrandDeviceFixCategory> list_of_fixdeviceBrands = new List<BrandDeviceFixCategory>()
        {
            new BrandDeviceFixCategory { FixCateogryID = 1, BrandDeviceID = 1 },
            new BrandDeviceFixCategory { FixCateogryID = 2, BrandDeviceID = 1 },
            new BrandDeviceFixCategory { FixCateogryID = 3, BrandDeviceID = 1 },
            new BrandDeviceFixCategory { FixCateogryID = 4, BrandDeviceID = 1 },
            new BrandDeviceFixCategory { FixCateogryID = 1, BrandDeviceID = 2 },
            new BrandDeviceFixCategory { FixCateogryID = 2, BrandDeviceID = 2 },
            new BrandDeviceFixCategory { FixCateogryID = 3, BrandDeviceID = 2 },
            new BrandDeviceFixCategory { FixCateogryID = 4, BrandDeviceID = 2 },
            new BrandDeviceFixCategory { FixCateogryID = 1, BrandDeviceID = 3 },
            new BrandDeviceFixCategory { FixCateogryID = 2, BrandDeviceID = 3 },
            new BrandDeviceFixCategory { FixCateogryID = 3, BrandDeviceID = 3 },
            new BrandDeviceFixCategory { FixCateogryID = 4, BrandDeviceID = 3 },
            new BrandDeviceFixCategory { FixCateogryID = 1, BrandDeviceID = 4 },
            new BrandDeviceFixCategory { FixCateogryID = 2, BrandDeviceID = 4 },
            new BrandDeviceFixCategory { FixCateogryID = 3, BrandDeviceID = 4 },
            new BrandDeviceFixCategory { FixCateogryID = 4, BrandDeviceID = 4 },
        };
        public static List<FixModel> list_of_fixModel = new List<FixModel>()
        {
            new FixModel{ FixID = 1, FixCateogryID = 1, BrandDeviceID = 1, FixTitle = "Cannot Charge Android Phone", FixDescription = "Cannot Charge Android Phone"},
            new FixModel{ FixID = 2, FixCateogryID = 1, BrandDeviceID = 2, FixTitle = "Cannot Charge iPhone", FixDescription = "Cannot Charge iPhone"}
        };
        public static List<InstructionModel> list_of_instruction = new List<InstructionModel>()
        {
            new InstructionModel { InstructionID = 1, InstructionTitle = "Make sure you use the correct cable", InstructionContent = "Android Phone only can be charged using a Micro USB Connector"},
            new InstructionModel { InstructionID = 2, InstructionTitle = "Make sure you use the correct cable", InstructionContent = "iPhone only can be charged using a Lighting Cable"},
        };
        public static List<FixInstructionModel> list_of_fixInstruction = new List<FixInstructionModel>()
        {
            new FixInstructionModel { FixID = 1, InstructionID = 1, SolutionStep = 1},
            new FixInstructionModel { FixID = 1, InstructionID = 2, SolutionStep = 2 },
            new FixInstructionModel { FixID = 2, InstructionID = 1, SolutionStep = 1 },
            new FixInstructionModel { FixID = 2, InstructionID = 2, SolutionStep = 2 }
        }; 


    }
}
