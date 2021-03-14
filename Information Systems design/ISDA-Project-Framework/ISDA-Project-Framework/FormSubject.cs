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
using WindowsFormsAppISDA;

namespace ISDA_Project_Framework
{
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveSubject((int)this.numericUpDownID.Value, this.textBoxName.Text);
        }
    }
}