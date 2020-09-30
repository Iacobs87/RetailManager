using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library.DataAccess
{
    public class SaleData
    {
        public void SaveSale(SaleData sale)
        {
            //TODO: make this SOLID/DRY/Better now just MVP

            // Start filling in the models we will save to the database

            //Fill in the available info

            // Create the Sale Model

            //Get the ID from the sale model

            //Finish filling in the sale detail models

            //Save the sale detail models
        }

        //public List<ProductModel> GetProducts()
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "TRMData");

        //    return output;
        //}
    }
}
