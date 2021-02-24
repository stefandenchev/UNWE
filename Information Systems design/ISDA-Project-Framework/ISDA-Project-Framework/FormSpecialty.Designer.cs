namespace ISDA_Project_Framework
{
    partial class FormSpecialty
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
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Specialty_ID_label = new System.Windows.Forms.Label();
            this.Specialty_Name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(12, 25);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownID.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Specialty_ID_label
            // 
            this.Specialty_ID_label.AutoSize = true;
            this.Specialty_ID_label.Location = new System.Drawing.Point(12, 9);
            this.Specialty_ID_label.Name = "Specialty_ID_label";
            this.Specialty_ID_label.Size = new System.Drawing.Size(18, 13);
            this.Specialty_ID_label.TabIndex = 3;
            this.Specialty_ID_label.Text = "ID";
            this.Specialty_ID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Specialty_Name_label
            // 
            this.Specialty_Name_label.AutoSize = true;
            this.Specialty_Name_label.Location = new System.Drawing.Point(12, 59);
            this.Specialty_Name_label.Name = "Specialty_Name_label";
            this.Specialty_Name_label.Size = new System.Drawing.Size(35, 13);
            this.Specialty_Name_label.TabIndex = 4;
            this.Specialty_Name_label.Text = "Name";
            // 
            // FormSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 304);
            this.Controls.Add(this.Specialty_Name_label);
            this.Controls.Add(this.Specialty_ID_label);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownID);
            this.Name = "FormSpecialty";
            this.Text = "FormSpecialty";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label Specialty_ID_label;
        private System.Windows.Forms.Label Specialty_Name_label;
    }
}