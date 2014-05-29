using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CBI360.Library.Data;
using System.Data;
using System.Configuration;

namespace b
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //绑定企业和建造师
            if (!IsPostBack)
            {
                BindCompany();
                BindBuilder();
            }
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
            DataTable dtCompany = new DataTable();
            SqlHelper.FillDataTable(dtCompany, Cfg.conn, "Q_GetIndexCompany", CommandType.StoredProcedure);
            rptCompany.DataSource = dtCompany;
            rptCompany.DataBind();
        }

        //绑定建造师
        protected void BindBuilder()
        {
            DataTable dtBuilder = new DataTable();
            SqlHelper.FillDataTable(dtBuilder, Cfg.conn, "Q_GetIndexBuilder", CommandType.StoredProcedure);
            rptBuilder.DataSource = dtBuilder;
            rptBuilder.DataBind();
        }

    }
}