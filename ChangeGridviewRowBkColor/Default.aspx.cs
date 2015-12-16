using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeGridviewRowBkColor
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                DataAccess da = new DataAccess();
                int rows = Convert.ToInt32(ConfigurationManager.AppSettings["Rows"]);
                DataTable dt = da.GetData(rows);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
                ErrorMessage.Visible = true;
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int getValue = Convert.ToInt32(e.Row.Cells[2].Text);
                if (getValue > 1)
                {
                   e.Row.CssClass = "redbackground";
                }
            }
        }
    }
}