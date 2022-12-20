namespace CVMaker
{
    partial class CVSkillsUC
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
            this.Skilltitle = new System.Windows.Forms.Label();
            this.Skilllevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Skilltitle
            // 
            this.Skilltitle.AutoSize = true;
            this.Skilltitle.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skilltitle.Location = new System.Drawing.Point(3, 10);
            this.Skilltitle.Name = "Skilltitle";
            this.Skilltitle.Size = new System.Drawing.Size(29, 13);
            this.Skilltitle.TabIndex = 0;
            this.Skilltitle.Text = "Title";
            // 
            // Skilllevel
            // 
            this.Skilllevel.AutoSize = true;
            this.Skilllevel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skilllevel.Location = new System.Drawing.Point(96, 10);
            this.Skilllevel.Name = "Skilllevel";
            this.Skilllevel.Size = new System.Drawing.Size(32, 13);
            this.Skilllevel.TabIndex = 1;
            this.Skilllevel.Text = "Level";
            // 
            // CVSkillsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Skilllevel);
            this.Controls.Add(this.Skilltitle);
            this.Name = "CVSkillsUC";
            this.Size = new System.Drawing.Size(174, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Skilltitle;
        private System.Windows.Forms.Label Skilllevel;
    }
}
