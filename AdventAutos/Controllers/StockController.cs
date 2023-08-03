using AdventModels.ResponseFields;
using DataLibrary.BusinessLogic;
using DataLibrary.ResponseFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventAutos.Controllers
{
    public class StockController : Controller
    {
        public ActionResult Index()
        {
            var listStock = StockFactory.LoadStock();

            List<StockResponse> stockList = new List<StockResponse>();
            foreach (var item in listStock)
            {
                StockResponse val = new StockResponse()
                {
                    Description = item.Description,
                    Price = item.Price,
                    ProductCategory = item.ProductCategory,
                    ProductID = item.ProductID,
                    ProductName = item.ProductName,
                    Quantity = item.Quantity
                };

                stockList.Add(val);
            }

            StockPage sp = new StockPage();
            sp.StockResponses = stockList;

            return View(sp);
        }

        public ActionResult Create()
        {
            AdventAuto.Models.Stock stock = new AdventAuto.Models.Stock()
            {
                ProductName = "",
                Price = 0,
                Description = "",
                ProductCategory = 0,
                ProductID = 0,
                Quantity = 0
            };

            return View(stock);
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}