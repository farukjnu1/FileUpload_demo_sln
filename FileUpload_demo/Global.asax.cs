using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FileUpload_demo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        List<MaintainUrl> urls = new MaintainUrl().Get();

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            string path = Request.Path.ToLower();

            if (urls.Any(url => url.Page_Url.Equals(path)))
            {
                string handler = urls.First(url => url.Page_Url.Equals(path)).Page_Handler;
                Context.RewritePath(@"~/" + handler);
            }
        }
    }

    public class MaintainUrl
    {
        public int PageId { get; set; }
        public string Page_Name { get; set; }
        public string Page_Handler { get; set; }
        public string Page_Url { get; set; }

        public List<MaintainUrl> Get()
        {
            List<MaintainUrl> urls = new List<MaintainUrl>()
            {
                new MaintainUrl() { PageId = 1, Page_Name = "Sales Force List", Page_Handler = "SalesForceList.aspx", Page_Url = "/salesforces"},
                new MaintainUrl() { PageId = 2, Page_Name = "Sales Force Create", Page_Handler = "SalesForceCreate.aspx", Page_Url = "/salesforce"},
                new MaintainUrl() { PageId = 3, Page_Name = "Sales Territories", Page_Handler = "SalesTerritoryList.aspx", Page_Url = "/salesterritories"},
                new MaintainUrl() { PageId = 4, Page_Name = "Sales Territory Create", Page_Handler = "SalesTerritory.aspx", Page_Url = "/salesterritory"},
                new MaintainUrl() { PageId = 5, Page_Name = "Home", Page_Handler = "Home.aspx", Page_Url = "/home"},
                new MaintainUrl() { PageId = 5, Page_Name = "Home", Page_Handler = "Home.aspx", Page_Url = "/"},
            };

            return urls;
        }
    }
}