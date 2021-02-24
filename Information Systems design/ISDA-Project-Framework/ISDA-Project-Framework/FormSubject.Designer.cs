
namespace ISDA_Project_Framework
{
    partial class FormSubject
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
            this.Specialty_Name_label = new System.Windows.Forms.Label();
            this.Specialty_ID_label = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.SuspendLayout();
            // 
            // Specialty_Name_label
            // 
            this.Specialty_Name_label.AutoSize = true;
            this.Specialty_Name_label.Location = new System.Drawing.Point(12, 59);
            this.Specialty_Name_label.Name = "Specialty_Name_label";
            this.Specialty_Name_label.Size = new System.Drawing.Size(35, 13);
            this.Specialty_Name_label.TabIndex = 9;
            this.Specialty_Name_label.Text = "Name";
            // 
            // Specialty_ID_label
            // 
            this.Specialty_ID_label.AutoSize = true;
            this.Specialty_ID_label.Location = new System.Drawing.Point(12, 9);
            this.Specialty_ID_label.Name = "Specialty_ID_label";
            this.Specialty_ID_label.Size = new System.Drawing.Size(18, 13);
            this.Specialty_ID_label.TabIndex = 8;
            this.Specialty_ID_label.Text = "ID";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(12, 25);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownID.TabIndex = 5;
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 309);
            this.Controls.Add(this.Specialty_Name_label);
            this.Controls.Add(this.Specialty_ID_label);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownID);
            this.Name = "FormSubject";
            this.Text = "FormSubject";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Specialty_Name_label;
        private System.Windows.Forms.Label Specialty_ID_label;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
    }
}