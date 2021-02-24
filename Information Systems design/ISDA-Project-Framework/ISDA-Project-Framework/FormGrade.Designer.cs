
namespace ISDA_Project_Framework
{
    partial class FormGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStu = new System.Windows.Forms.Label();
            this.studentBox = new System.Windows.Forms.ComboBox();
            this.Student_ID_label = new System.Windows.Forms.Label();
            this.numericUpDownFinalGrade = new System.Windows.Forms.NumericUpDown();
            this.subjLabel = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStu
            // 
            this.labelStu.AutoSize = true;
            this.labelStu.Location = new System.Drawing.Point(11, 8);
            this.labelStu.Name = "labelStu";
            this.labelStu.Size = new System.Drawing.Size(44, 13);
            this.labelStu.TabIndex = 25;
            this.labelStu.Text = "Student";
            // 
            // studentBox
            // 
            this.studentBox.FormattingEnabled = true;
            this.studentBox.Location = new System.Drawing.Point(11, 27);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(121, 21);
            this.studentBox.TabIndex = 24;
            // 
            // Student_ID_label
            // 
            this.Student_ID_label.AutoSize = true;
            this.Student_ID_label.Location = new System.Drawing.Point(11, 111);
            this.Student_ID_label.Name = "Student_ID_label";
            this.Student_ID_label.Size = new System.Drawing.Size(59, 13);
            this.Student_ID_label.TabIndex = 23;
            this.Student_ID_label.Text = "Final grade";
            // 
            // numericUpDownFinalGrade
            // 
            this.numericUpDownFinalGrade.Location = new System.Drawing.Point(11, 127);
            this.numericUpDownFinalGrade.Name = "numericUpDownFinalGrade";
            this.numericUpDownFinalGrade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFinalGrade.TabIndex = 22;
            // 
            // subjLabel
            // 
            this.subjLabel.AutoSize = true;
            this.subjLabel.Location = new System.Drawing.Point(11, 57);
            this.subjLabel.Name = "subjLabel";
            this.subjLabel.Size = new System.Drawing.Size(43, 13);
            this.subjLabel.TabIndex = 27;
            this.subjLabel.Text = "Subject";
            this.subjLabel.Click += new System.EventHandler(this.specLabel_Click);
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(11, 76);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(121, 21);
            this.subjectBox.TabIndex = 26;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(14, 167);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.subjLabel);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.labelStu);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.Student_ID_label);
            this.Controls.Add(this.numericUpDownFinalGrade);
            this.Name = "FormGrade";
            this.Text = "FormGrade";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinalGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStu;
        private System.Windows.Forms.ComboBox studentBox;
        private System.Windows.Forms.Label Student_ID_label;
        private System.Windows.Forms.NumericUpDown numericUpDownFinalGrade;
        private System.Windows.Forms.Label subjLabel;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.Button buttonSave;
    }
}