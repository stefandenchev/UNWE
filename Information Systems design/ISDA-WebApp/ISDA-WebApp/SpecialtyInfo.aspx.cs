using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISDA_WebApp
{
    public partial class SpecialtyInfo : System.Web.UI.Page
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
                    this.Response.Redirect("Specialties.aspx");
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
                this.Response.Redirect("Specialties.aspx");
            }
            Configurator configurator = new Configurator();

            Specialty specialty = configurator.LoadSpecialtyById(id);

            if (specialty != null)
            {
                this.TextBoxSpecialtyID.Text = specialty.Id.ToString();
                this.TextBoxSpecialtyName.Text = specialty.Name;
                this.ViewState["id"] = id;
            }
            else
            {
                this.Response.Redirect("Specialties.aspx");
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ViewState["id"] != null)
            {
                int id = Convert.ToInt32(this.ViewState["id"]);

                Configurator configurator = new Configurator();

                configurator.UpdateSpecialty(id, this.TextBoxSpecialtyName.Text);
                this.Response.Redirect("Specialties.aspx");
            }
        }

    }
}