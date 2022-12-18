namespace CVMaker
{
    partial class EducationCV_UC
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
            this.institute_edu_CV = new System.Windows.Forms.Label();
            this.end_edu_CV = new System.Windows.Forms.Label();
            this.title_edu_CV = new System.Windows.Forms.Label();
            this.start_edu_CV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // institute_edu_CV
            // 
            this.institute_edu_CV.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.institute_edu_CV.Location = new System.Drawing.Point(21, 49);
            this.institute_edu_CV.Name = "institute_edu_CV";
            this.institute_edu_CV.Size = new System.Drawing.Size(135, 34);
            this.institute_edu_CV.TabIndex = 4;
            this.institute_edu_CV.Text = "institute";
            // 
            // end_edu_CV
            // 
            this.end_edu_CV.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_edu_CV.Location = new System.Drawing.Point(107, 5);
            this.end_edu_CV.Name = "end_edu_CV";
            this.end_edu_CV.Size = new System.Drawing.Size(69, 22);
            this.end_edu_CV.TabIndex = 5;
            this.end_edu_CV.Text = "end";
            // 
            // title_edu_CV
            // 
            this.title_edu_CV.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.title_edu_CV.Location = new System.Drawing.Point(19, 27);
            this.title_edu_CV.Name = "title_edu_CV";
            this.title_edu_CV.Size = new System.Drawing.Size(135, 22);
            this.title_edu_CV.TabIndex = 6;
            this.title_edu_CV.Text = "title";
            // 
            // start_edu_CV
            // 
            this.start_edu_CV.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_edu_CV.Location = new System.Drawing.Point(20, 5);
            this.start_edu_CV.Name = "start_edu_CV";
            this.start_edu_CV.Size = new System.Drawing.Size(75, 22);
            this.start_edu_CV.TabIndex = 7;
            this.start_edu_CV.Text = "start";
            // 
            // EducationCV_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.institute_edu_CV);
            this.Controls.Add(this.end_edu_CV);
            this.Controls.Add(this.title_edu_CV);
            this.Controls.Add(this.start_edu_CV);
            this.Name = "EducationCV_UC";
            this.Size = new System.Drawing.Size(195, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label institute_edu_CV;
        private System.Windows.Forms.Label end_edu_CV;
        private System.Windows.Forms.Label title_edu_CV;
        private System.Windows.Forms.Label start_edu_CV;
    }
}
