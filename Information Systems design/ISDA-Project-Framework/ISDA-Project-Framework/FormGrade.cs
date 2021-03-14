using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppISDA
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
            this.comboBoxStudent.DataSource = dTableStudents;
            this.comboBoxStudent.ValueMember = "fnumber";
            this.comboBoxStudent.DisplayMember = "name";
            DataTable dTableSubjects = configurator.LoadSubjects();
            this.comboBoxSubject.DataSource = dTableSubjects;
            this.comboBoxSubject.ValueMember = "id";
            this.comboBoxSubject.DisplayMember = "name";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveGrade(Convert.ToInt32(this.comboBoxStudent.SelectedValue),
           Convert.ToInt32(this.comboBoxSubject.SelectedValue),
           (int)this.numericUpDownFinalGrade.Value);
        }
    }
}
