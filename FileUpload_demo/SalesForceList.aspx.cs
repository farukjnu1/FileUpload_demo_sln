using FileUpload_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload_demo
{
    public partial class SalesForceList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSalesForce();
        }

        private void GetSalesForce()
        {
            var ctx = new Model1();
            var list = (from sf in ctx.SalesForces
                        join st in ctx.SalesTerritories on sf.SalesTerritoryId equals st.SalesTerritoryId
                        select new
                        {
                            sf.SalesForceId,
                            sf.SalesForceName,
                            sf.JoinDate,
                            sf.Pic,
                            sf.SalesTerritoryId,
                            st.SalesterritoryName
                        }
                        ).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
        
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                var SalesForceId = selectedRow.Cells[0].Text.Trim();
                Response.Redirect("SalesForceEdit.aspx?id=" + SalesForceId);
            }

            if (e.CommandName == "Remove")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                var SalesForceId = selectedRow.Cells[0].Text.Trim();
                Response.Redirect("SalesForceDelete.aspx?id=" + SalesForceId);
            }
        }

    }
}