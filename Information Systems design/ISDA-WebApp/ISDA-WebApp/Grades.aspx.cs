using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISDA_WebApp
{
    public partial class Grades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }

            this.LoadData();
        }

        protected void GridViewContent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                // Convert the row index stored in the CommandArgument
                // property to an Integer.
                int index = Convert.ToInt32(e.CommandArgument);

                // Get the last name of the selected author from the appropriate
                // cell in the GridView control.
                GridViewRow selectedRow = this.GridViewContent.Rows[index];
                TableCell firstCell = selectedRow.Cells[1];
                TableCell fifthCell = selectedRow.Cells[5];
                string fnumber = firstCell.Text;
                string subjectId = fifthCell.Text;
                this.Response.Redirect("GradeInfo.aspx?fnumber=" + fnumber
                    + "&subjectid=" + subjectId);
            }
        }

        private void LoadData()
        {
            Configurator configurator = new Configurator();
            this.GridViewContent.DataSource = configurator.LoadGrades();
            this.GridViewContent.DataBind();
        }
    }
}