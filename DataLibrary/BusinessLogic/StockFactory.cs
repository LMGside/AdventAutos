using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class StockFactory
    {
        public static List<Stock> LoadStock()
        {
            string sql = @"SELECT *
                          FROM [dbo].[Stock]";

            return SqlDataAccess.LoadData<Stock>(sql);
        }

        public static Stock GetStock(int id)
        {
            string sql = @"SELECT *
                          FROM [dbo].[Stock]
                          WHERE [ProductID] = @ProductID";

            Stock stockMod = new Stock()
            {
                ProductID = id
            };

            return SqlDataAccess.GetData<Stock>(sql, stockMod);
        }
    }
}
