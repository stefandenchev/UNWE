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
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["fnumber"] != null)
                {
                    string param = this.Request["fnumber"];
                    this.LoadData(param);
                }
                else
                {
                    this.Response.Redirect("Students.aspx");
                }
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable specialties = configurator.LoadSpecialties();

            for (int i = 0; i < specialties.Rows.Count; i++)
            {
                DataRow row = specialties.Rows[i];

                string id = row[0] as string;
                string name = row[1] as string;

                ListItem item = new ListItem(name, id);

                this.DropDownListSpecialty.Items.Add(item);
            }
        }

        private void LoadData(string param)
        {
            Configurator configurator = new Configurator();

            Student student = configurator.LoadStudentByFNumber(param);

            if (student != null)
            {
                this.TextBoxStudentFNumber.Text = student.FNumber;
                this.DropDownListSpecialty.SelectedValue = student.SpecialtyId.ToString();
                this.TextBoxStudentFName.Text = student.FName;
                this.TextBoxStudentFName.Text = student.MName;
                this.TextBoxStudentFName.Text = student.LName;
                this.TextBoxStudentAddress.Text = student.Address;
                this.TextBoxStudentPhone.Text = student.Phone;
                this.TextBoxStudentEMail.Text = student.EMail;

                this.ViewState["fnumber"] = param;
            }
            else
            {
                this.Response.Redirect("Students.aspx");
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ViewState["fnumber"] != null)
            {
                string fNumber = this.ViewState["fnumber"] as string;

                Configurator configurator = new Configurator();
                configurator.UpdateStudent(
                    fNumber,
                    Convert.ToInt32(this.DropDownListSpecialty.SelectedValue),
                    this.TextBoxStudentFName.Text,
                    this.TextBoxStudentMName.Text,
                    this.TextBoxStudentLName.Text,
                    this.TextBoxStudentAddress.Text,
                    this.TextBoxStudentPhone.Text,
                    this.TextBoxStudentEMail.Text);

                this.Response.Redirect("Students.aspx");
            }
        }
    }
}