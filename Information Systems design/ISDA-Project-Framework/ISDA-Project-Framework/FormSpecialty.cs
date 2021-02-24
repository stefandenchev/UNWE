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
    public partial class FormSpecialty : Form
    {
        public FormSpecialty()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveSpecialty(Convert.ToInt32(this.numericUpDownID.Value), this.textBoxName.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
