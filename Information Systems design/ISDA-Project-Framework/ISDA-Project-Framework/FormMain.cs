using ISDA_Project_Framework;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void specialtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpecialty f = new FormSpecialty();
            f.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubject f = new FormSubject();
            f.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent f = new FormStudent();
            f.ShowDialog();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrade f = new FormGrade();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}