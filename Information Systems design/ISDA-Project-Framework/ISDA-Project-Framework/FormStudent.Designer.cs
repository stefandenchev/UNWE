
namespace ISDA_Project_Framework
{
    partial class FormStudent
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
            this.Student_ID_label = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownFNumber = new System.Windows.Forms.NumericUpDown();
            this.labelFN = new System.Windows.Forms.Label();
            this.FNbox = new System.Windows.Forms.TextBox();
            this.labelMN = new System.Windows.Forms.Label();
            this.MNbox = new System.Windows.Forms.TextBox();
            this.labelLN = new System.Windows.Forms.Label();
            this.LNbox = new System.Windows.Forms.TextBox();
            this.labelAddr = new System.Windows.Forms.Label();
            this.AdBox = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.PhBox = new System.Windows.Forms.TextBox();
            this.stuSpecBox = new System.Windows.Forms.ComboBox();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelEM = new System.Windows.Forms.Label();
            this.EmBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_ID_label
            // 
            this.Student_ID_label.AutoSize = true;
            this.Student_ID_label.Location = new System.Drawing.Point(12, 9);
            this.Student_ID_label.Name = "Student_ID_label";
            this.Student_ID_label.Size = new System.Drawing.Size(81, 13);
            this.Student_ID_label.TabIndex = 8;
            this.Student_ID_label.Text = "Faculty Number";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 361);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownFNumber
            // 
            this.numericUpDownFNumber.Location = new System.Drawing.Point(12, 25);
            this.numericUpDownFNumber.Name = "numericUpDownFNumber";
            this.numericUpDownFNumber.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFNumber.TabIndex = 5;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(12, 97);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(57, 13);
            this.labelFN.TabIndex = 11;
            this.labelFN.Text = "First Name";
            // 
            // FNbox
            // 
            this.FNbox.Location = new System.Drawing.Point(12, 113);
            this.FNbox.Name = "FNbox";
            this.FNbox.Size = new System.Drawing.Size(100, 20);
            this.FNbox.TabIndex = 10;
            // 
            // labelMN
            // 
            this.labelMN.AutoSize = true;
            this.labelMN.Location = new System.Drawing.Point(9, 136);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(69, 13);
            this.labelMN.TabIndex = 13;
            this.labelMN.Text = "Middle Name";
            // 
            // MNbox
            // 
            this.MNbox.Location = new System.Drawing.Point(12, 152);
            this.MNbox.Name = "MNbox";
            this.MNbox.Size = new System.Drawing.Size(100, 20);
            this.MNbox.TabIndex = 12;
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Location = new System.Drawing.Point(12, 175);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(58, 13);
            this.labelLN.TabIndex = 15;
            this.labelLN.Text = "Last Name";
            // 
            // LNbox
            // 
            this.LNbox.Location = new System.Drawing.Point(12, 191);
            this.LNbox.Name = "LNbox";
            this.LNbox.Size = new System.Drawing.Size(100, 20);
            this.LNbox.TabIndex = 14;
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Location = new System.Drawing.Point(12, 218);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(45, 13);
            this.labelAddr.TabIndex = 17;
            this.labelAddr.Text = "Address";
            // 
            // AdBox
            // 
            this.AdBox.Location = new System.Drawing.Point(12, 234);
            this.AdBox.Name = "AdBox";
            this.AdBox.Size = new System.Drawing.Size(100, 20);
            this.AdBox.TabIndex = 16;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 257);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 19;
            this.labelPhone.Text = "Phone";
            // 
            // PhBox
            // 
            this.PhBox.Location = new System.Drawing.Point(12, 273);
            this.PhBox.Name = "PhBox";
            this.PhBox.Size = new System.Drawing.Size(100, 20);
            this.PhBox.TabIndex = 18;
            // 
            // stuSpecBox
            // 
            this.stuSpecBox.FormattingEnabled = true;
            this.stuSpecBox.Location = new System.Drawing.Point(12, 66);
            this.stuSpecBox.Name = "stuSpecBox";
            this.stuSpecBox.Size = new System.Drawing.Size(121, 21);
            this.stuSpecBox.TabIndex = 20;
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Location = new System.Drawing.Point(12, 47);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(50, 13);
            this.labelSpec.TabIndex = 21;
            this.labelSpec.Text = "Specialty";
            // 
            // labelEM
            // 
            this.labelEM.AutoSize = true;
            this.labelEM.Location = new System.Drawing.Point(12, 298);
            this.labelEM.Name = "labelEM";
            this.labelEM.Size = new System.Drawing.Size(33, 13);
            this.labelEM.TabIndex = 23;
            this.labelEM.Text = "EMail";
            // 
            // EmBox
            // 
            this.EmBox.Location = new System.Drawing.Point(12, 314);
            this.EmBox.Name = "EmBox";
            this.EmBox.Size = new System.Drawing.Size(100, 20);
            this.EmBox.TabIndex = 22;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEM);
            this.Controls.Add(this.EmBox);
            this.Controls.Add(this.labelSpec);
            this.Controls.Add(this.stuSpecBox);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.PhBox);
            this.Controls.Add(this.labelAddr);
            this.Controls.Add(this.AdBox);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.LNbox);
            this.Controls.Add(this.labelMN);
            this.Controls.Add(this.MNbox);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.FNbox);
            this.Controls.Add(this.Student_ID_label);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownFNumber);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Student_ID_label;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownFNumber;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox FNbox;
        private System.Windows.Forms.Label labelMN;
        private System.Windows.Forms.TextBox MNbox;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.TextBox LNbox;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.TextBox AdBox;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox PhBox;
        private System.Windows.Forms.ComboBox stuSpecBox;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelEM;
        private System.Windows.Forms.TextBox EmBox;
    }
}