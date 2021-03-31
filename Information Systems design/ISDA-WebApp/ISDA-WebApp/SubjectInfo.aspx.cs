using ISDA_WebApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISDA_WebApp
{
    public partial class SubjectInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["id"] != null)
                {
                    string param = this.Request["id"];
                    this.LoadData(param);
                }
                else
                {
                    this.Response.Redirect("Subjects.aspx");
                }
            }
        }
        private void LoadData(string param)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(param);
            }
            catch
            {
                this.Response.Redirect("Subjects.aspx");
            }
            Configurator configurator = new Configurator();

            Subject subject = configurator.LoadSubjectById(id);

            if (subject != null)
            {
                this.TextBoxSubjectID.Text = subject.Id.ToString();
                this.TextBoxSubjectName.Text = subject.Name;
                this.ViewState["id"] = id;
            }
            else
            {
                this.Response.Redirect("Subjects.aspx");
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ViewState["id"] != null)
            {
                int id = Convert.ToInt32(this.ViewState["id"]);

                Configurator configurator = new Configurator();

                configurator.UpdateSubject(id, this.TextBoxSubjectName.Text);
                this.Response.Redirect("Subjects.aspx");
            }
        }

    }
}