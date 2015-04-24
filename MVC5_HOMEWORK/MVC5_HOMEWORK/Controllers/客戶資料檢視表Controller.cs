using MVC5_HOMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_HOMEWORK.Controllers
{
    public class 客戶資料檢視表Controller : Controller
    {
        // GET: 客戶資料檢視表
        public ActionResult Index()
        {
            客戶資料Entities1 en = new 客戶資料Entities1();
            IQueryable l_客戶相關資料表 = en.客戶相關資料表.AsQueryable();
            return View(l_客戶相關資料表);
        }
    }
}