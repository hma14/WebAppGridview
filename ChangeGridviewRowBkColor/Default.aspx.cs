using System;
using System.Collections.Generic;
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
            DataAccess da = new DataAccess();
            DataTable dt = da.GetData(100);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                long getValue = Convert.ToInt64(e.Row.Cells[1].Text);
                if (getValue > 1)
                {
                   e.Row.CssClass = "redbackground";
                }
            }
        }
    }
}