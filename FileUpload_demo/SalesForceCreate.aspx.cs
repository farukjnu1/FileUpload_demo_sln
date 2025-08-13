using FileUpload_demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileUpload_demo
{
    public partial class SalesForceCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSalesTerritory();
        }
        
        private void GetSalesTerritory()
        {
            var ctx = new Model1();
            var list = (from o in ctx.SalesTerritories select o).ToList();
            foreach (var oTerritory in ctx.SalesTerritories)
            {
                ddlTerritory.Items.Insert(0, new ListItem(oTerritory.SalesterritoryName, oTerritory.SalesTerritoryId.ToString()));
            }
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string picPath = "~/Images/images.jpg";
            if (FileUpload1.HasFile)
            {
                var extension = Path.GetExtension(FileUpload1.FileName);
                var newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + extension;
                picPath = "~/Images/" + newFileName;
                if (File.Exists(Server.MapPath(FileUpload1.FileName)))
                {
                    File.Delete(Server.MapPath(FileUpload1.FileName));
                }

                FileUpload1.SaveAs(Server.MapPath("images//" + newFileName));
                Label1.Text = "Image Uploaded";
                Label1.ForeColor = System.Drawing.Color.ForestGreen;
            }
            else
            {
                Label1.Text = "Please Select your file";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

            var ctx = new Model1();
            var oSalesForce = new SalesForce();
            oSalesForce.SalesForceName = txtName.Text.Trim();
            oSalesForce.JoinDate = Convert.ToDateTime(txtJoinDate.Text.Trim());
            oSalesForce.Pic = picPath;
            oSalesForce.SalesTerritoryId = Convert.ToInt32(ddlTerritory.SelectedValue);
            ctx.SalesForces.Add(oSalesForce);
            ctx.SaveChanges();

            Response.Redirect("SalesForceList.aspx");
        }
        
    }
}