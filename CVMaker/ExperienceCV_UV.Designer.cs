namespace CVMaker
{
    partial class ExperienceCV_UV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleCV = new System.Windows.Forms.Label();
            this.end_dateCV = new System.Windows.Forms.Label();
            this.start_dateCV = new System.Windows.Forms.Label();
            this.descriptionCV = new System.Windows.Forms.RichTextBox();
            this.company_nameCV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleCV
            // 
            this.titleCV.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.titleCV.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleCV.Location = new System.Drawing.Point(14, 60);
            this.titleCV.Name = "titleCV";
            this.titleCV.Size = new System.Drawing.Size(340, 24);
            this.titleCV.TabIndex = 24;
            this.titleCV.Text = "Title";
            // 
            // end_dateCV
            // 
            this.end_dateCV.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.end_dateCV.ForeColor = System.Drawing.Color.SteelBlue;
            this.end_dateCV.Location = new System.Drawing.Point(256, 14);
            this.end_dateCV.Name = "end_dateCV";
            this.end_dateCV.Size = new System.Drawing.Size(82, 22);
            this.end_dateCV.TabIndex = 26;
            this.end_dateCV.Text = "End_Date";
            // 
            // start_dateCV
            // 
            this.start_dateCV.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.start_dateCV.ForeColor = System.Drawing.Color.SteelBlue;
            this.start_dateCV.Location = new System.Drawing.Point(14, 14);
            this.start_dateCV.Name = "start_dateCV";
            this.start_dateCV.Size = new System.Drawing.Size(92, 22);
            this.start_dateCV.TabIndex = 25;
            this.start_dateCV.Text = "Start_date";
            // 
            // descriptionCV
            // 
            this.descriptionCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionCV.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.descriptionCV.Location = new System.Drawing.Point(18, 87);
            this.descriptionCV.Name = "descriptionCV";
            this.descriptionCV.Size = new System.Drawing.Size(531, 75);
            this.descriptionCV.TabIndex = 27;
            this.descriptionCV.Text = "Description";
            // 
            // company_nameCV
            // 
            this.company_nameCV.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.company_nameCV.ForeColor = System.Drawing.Color.SteelBlue;
            this.company_nameCV.Location = new System.Drawing.Point(14, 36);
            this.company_nameCV.Name = "company_nameCV";
            this.company_nameCV.Size = new System.Drawing.Size(340, 24);
            this.company_nameCV.TabIndex = 23;
            this.company_nameCV.Text = "Company";
            // 
            // ExperienceCV_UV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleCV);
            this.Controls.Add(this.end_dateCV);
            this.Controls.Add(this.start_dateCV);
            this.Controls.Add(this.descriptionCV);
            this.Controls.Add(this.company_nameCV);
            this.Name = "ExperienceCV_UV";
            this.Size = new System.Drawing.Size(556, 177);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleCV;
        private System.Windows.Forms.Label end_dateCV;
        private System.Windows.Forms.Label start_dateCV;
        private System.Windows.Forms.RichTextBox descriptionCV;
        private System.Windows.Forms.Label company_nameCV;
    }
}
