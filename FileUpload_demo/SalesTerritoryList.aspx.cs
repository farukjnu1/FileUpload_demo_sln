using FileUpload_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload_demo
{
    public partial class SalesTerritoryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSalesTerritory();
        }

        private void GetSalesTerritory()
        {
            var ctx = new Model1();
            var list = (from o in ctx.SalesTerritories
                        select
                        new
                        {
                            id = o.SalesTerritoryId,
                            name = o.SalesterritoryName,
                            numberOfSalesForce = ctx.SalesForces.Where(x => x.SalesTerritoryId == o.SalesTerritoryId).Count()
                        }).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

    }
}