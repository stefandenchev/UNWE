using ISDA_Proj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDA_Project_Framework
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           Configurator configurator = new Configurator();
           configurator.SaveStudent((int)this.numericUpDownFNumber.Value,
           Convert.ToInt32(this.stuSpecBox.SelectedValue), this.FNbox.Text,
           this.MNbox.Text, this.LNbox.Text, this.AdBox.Text,
           this.PhBox.Text, this.EmBox.Text);
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSpecialties();
            this.stuSpecBox.DataSource = dTable;
            this.stuSpecBox.ValueMember = "id";
            this.stuSpecBox.DisplayMember = "name";

        }
    }
}