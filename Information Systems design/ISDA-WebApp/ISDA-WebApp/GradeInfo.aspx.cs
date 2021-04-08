using ISDA_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISDA_WebApp
{
    public partial class GradeInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["fnumber"] != null
                    && this.Request["subjectid"] != null)
                {
                    string param1 = this.Request["fnumber"];
                    string param2 = this.Request["subjectid"];

                    this.LoadData(param1, param2);
                }
                else
                {
                    this.Response.Redirect("Grades.aspx");
                }
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();

            DataTable students = configurator.LoadStudents();

            for (int i = 0; i < students.Rows.Count; i++)
            {
                DataRow row = students.Rows[i];

                string fNumber = row[0] as string;
                string fname = row[2] as string;
                string mname = row[3] as string;
                string lname = row[4] as string;

                ListItem item = new ListItem(fNumber + ", " + fname + " " + mname +
                    " " + lname, fNumber);

                this.DropDownListStudent.Items.Add(item);
            }

            DataTable subjects = configurator.LoadSubjects();

            for (int i = 0; i < subjects.Rows.Count; i++)
            {
                DataRow row = subjects.Rows[i];

                string id = row[0] as string;
                string name = row[1] as string;

                ListItem item = new ListItem(name, id);

                this.DropDownListSubject.Items.Add(item);
            }
        }

        private void LoadData(string param1, string param2)
        {
            Configurator configurator = new Configurator();

            Grade grade = configurator.LoadGradeByFNumberAndSubjectId(param1,
                Convert.ToInt32(param2));

            this.DropDownListStudent.SelectedValue = grade.FNumber;
            this.DropDownListSubject.SelectedValue = grade.SubjectId.ToString();
            this.TextBoxFinalGrade.Text = grade.FinalGrade.ToString();

            this.ViewState["fnumber"] = param1;
            this.ViewState["subjectid"] = param2;
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ViewState["fnumber"] != null
                && this.ViewState["subjectid"] != null)
            {
                string fNumber = this.ViewState["fnumber"] as string;
                int subjectId = Convert.ToInt32(this.ViewState["subjectid"]);

                Configurator configurator = new Configurator();
                configurator.UpdateGrade(
                    fNumber,
                    subjectId,
                    Convert.ToInt32(this.TextBoxFinalGrade.Text));

                this.Response.Redirect("Grades.aspx");
            }
        }
    }
}