using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace b
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //绑定企业和建造师
            BindCompany();
            BindBuilder();
        }

        //搜索方法
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCompany.Text))
            {
                Response.Redirect("CompanyList.aspx?wd=" + HttpUtility.UrlEncode(tbCompany.Text.Trim())); 
            }
        }
        
        //绑定企业
        protected void BindCompany()
        { 
            
        }

        protected void BindBuilder()
        {

        }

    }
}