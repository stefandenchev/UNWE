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
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTableStudents = configurator.LoadStudents();
            this.studentBox.DataSource = dTableStudents;
            this.studentBox.ValueMember = "fnumber";
            this.studentBox.DisplayMember = "name";
            DataTable dTableSubjects = configurator.LoadSubjects();
            this.subjectBox.DataSource = dTableSubjects;
            this.subjectBox.ValueMember = "id";
            this.subjectBox.DisplayMember = "name";

        }

        private void specLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveGrade(Convert.ToInt32(this.studentBox.SelectedValue),
           Convert.ToInt32(this.subjectBox.SelectedValue),
           (int)this.numericUpDownFinalGrade.Value);

        }
    }
}
