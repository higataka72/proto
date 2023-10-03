﻿using System;
using System.Collections.Generic;
using System.Linq;
using C1.Web.Mvc;
using C1.Web.Mvc.Serialization;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Data.Entity;
using CampusV4.Models;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Ajax.Utilities;
using System.Diagnostics;

// This code was generated by C1 Scaffolder.

namespace CampusV4.Controllers.EstimateReplyInput
{
    public partial class EstimateReplyInputController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult EstimateReplyInput(string InquiryNumber, string CampusId)
        {
            ModelState.Clear();
            EstimateReplyInputViewModel model = new EstimateReplyInputViewModel();


            model.EstimateReplyNo = InquiryNumber;
            model.EstimateRequestNo = CampusId;
            model.EstimateReplyDate = DateTime.Now;

            model.InquiryNumber = InquiryNumber;
            model.GroupingMark = "A";
            model.ProductionNumber = "3101A001";

            model.Subject = "A機枠組み";
            model.VarietyCode = "ZX-A001";
            model.ProductName = "金型A図枠組み";

            model.DesignEmployeeCode = "USR00001";
            model.DesignEmployeeName = "佐藤　一郎";

            model.RequestDate = DateTime.Parse("2023/11/01");
            model.RequestedShippingDate = DateTime.Parse("2023/12/28");
            model.QuotationBy = DateTime.Parse("2023/11/20");

            model.CampusId = CampusId;
            model.CompanyName = "株式会社 A社";

            model.SuppliersName = "田中　一郎";
            model.DepartmentName = "設計部";

            model.PhoneNumber = "00-0000-0000";
            model.Email = "xxxxx@xxx.com";

            model.Notes = "備考欄";
            model.RfqClassification = "2";

            GetCompDataList(ref model);

            return View(model);
        }


        public ActionResult SplitDelivery(string EstimateReplyNo, double? Quantity, string Unit, double? Unitprice, double? Price)
        {

            ModelState.Clear();
            EstimateReplyInputViewModel model = new EstimateReplyInputViewModel();
            
            return View(model);

        }

        //リストボックス値取得
        private void GetCompDataList(ref EstimateReplyInputViewModel model)
        {
            // 共通項目
            // 品種情報を取得
            var HinshudataList = new List<HinshuData>();
            HinshudataList.Add(new HinshuData("　", ""));
            HinshudataList.Add(new HinshuData("ZX-A001", "金型A図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-B001", "金型B図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-C001", "金型C図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-D001", "金型D図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-E001", "金型E図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-F001", "金型F図枠組み"));
            HinshudataList.Add(new HinshuData("ZX-G001", "金型G図枠組み"));
            model.HinsyuDataList = HinshudataList;

            // 営業担当者情報を取得
            var EmployeeData = new List<EmployeeData>();
            EmployeeData.Add(new EmployeeData("　", ""));
            EmployeeData.Add(new EmployeeData("USR00001", "佐藤　一郎"));
            EmployeeData.Add(new EmployeeData("USR00002", "佐藤　次郎"));
            EmployeeData.Add(new EmployeeData("USR00003", "佐藤　三郎"));
            EmployeeData.Add(new EmployeeData("USR00004", "佐藤　四朗"));
            EmployeeData.Add(new EmployeeData("USR00005", "佐藤　五郎"));
            model.EmployeeDataList = EmployeeData;

            // 部品記号を取得
            var GroupingMarkDataList = new List<GroupingMarkData>();
            GroupingMarkDataList.Add(new GroupingMarkData("　", ""));
            GroupingMarkDataList.Add(new GroupingMarkData("A", "A"));
            GroupingMarkDataList.Add(new GroupingMarkData("B", "B"));
            GroupingMarkDataList.Add(new GroupingMarkData("C", "C"));
            GroupingMarkDataList.Add(new GroupingMarkData("D", "D"));
            GroupingMarkDataList.Add(new GroupingMarkData("E", "E"));
            model.GroupingMarkList = GroupingMarkDataList;

            var dataList = new List<EstimateReplyListData>();

            EstimateReplyListData estimateReplyListData = new EstimateReplyListData();
            //行番号
            estimateReplyListData.RowNumber = 1;
            //見積辞退区分
            estimateReplyListData.Decline = false;
            //部品分類
            estimateReplyListData.PartsCode = "A";
            //部品名
            estimateReplyListData.PartsName = "Upper Cull Block";
            //図面番号／型式
            estimateReplyListData.DrawingNumber = "001602-A-B002";
            //入数
            estimateReplyListData.IriSu = 1;
            //個数
            estimateReplyListData.Quantity = 2;
            //単位
            estimateReplyListData.Unit = "式";
            //表面処理コード
            estimateReplyListData.SurfaceTreatment = "001";
            //表面処理
            estimateReplyListData.SurfaceTreatmentName = "表明処理１";
            //単価
            estimateReplyListData.Unitprice = 260000;
            //金額
            estimateReplyListData.Price = 520000;
            //納期
            estimateReplyListData.ShippingDate = DateTime.Parse("2023/12/28");

            dataList.Add(estimateReplyListData);

            //EstimateReplyListData estimateReplyListData1 = new EstimateReplyListData();
            ////行番号
            //estimateReplyListData1.RowNumber = 2;
            ////見積辞退区分
            //estimateReplyListData1.Decline = true;
            ////部品分類
            //estimateReplyListData1.PartsCode = "B";
            ////部品名
            //estimateReplyListData1.PartsName = "Upper Cull Block";
            ////図面番号／型式
            //estimateReplyListData1.DrawingNumber = "001602-A-B002";
            ////入数
            //estimateReplyListData1.IriSu = 3;
            ////個数
            //estimateReplyListData1.Quantity = 4;
            ////単位
            //estimateReplyListData1.Unit = "ロール";
            ////表面処理コード
            //estimateReplyListData1.SurfaceTreatment = "002";
            ////表面処理
            //estimateReplyListData1.SurfaceTreatmentName = "表明処理２";
            ////単価
            //estimateReplyListData1.Unitprice = 200;
            ////金額
            //estimateReplyListData1.Price = 600;
            ////納期
            //estimateReplyListData1.ShippingDate = DateTime.Parse("2023/12/31");

            //dataList.Add(estimateReplyListData1);

            model.GridDataList = dataList;

            // パートナー工場の担当者
            var SupplierSearchAddDataList = new List<SupplierSearchAddData>();
            SupplierSearchAddDataList.Add(new SupplierSearchAddData("1001001", "佐藤　一郎", "営業部", "000-000-0000", "xxxx@xxx.com"));
            SupplierSearchAddDataList.Add(new SupplierSearchAddData("1001002", "佐藤　二郎", "営業部", "000-000-0000", "xxxx@xxx.com"));
            SupplierSearchAddDataList.Add(new SupplierSearchAddData("1001003", "佐藤　三郎", "調達部", "000-000-0000", "xxxx@xxx.com"));
            model.SupplierSearchAddDataList = SupplierSearchAddDataList;
        }
    }
}