namespace CVMaker
{
    partial class SocialUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialUC));
            this.panelsocial = new System.Windows.Forms.Panel();
            this.roundedpanelsocial = new CVMaker.roundedpanel();
            this.title_social = new System.Windows.Forms.Label();
            this.deletesocial = new System.Windows.Forms.PictureBox();
            this.socialid = new System.Windows.Forms.Label();
            this.panelsocial.SuspendLayout();
            this.roundedpanelsocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletesocial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsocial
            // 
            this.panelsocial.Controls.Add(this.roundedpanelsocial);
            this.panelsocial.Controls.Add(this.deletesocial);
            this.panelsocial.Controls.Add(this.socialid);
            this.panelsocial.Location = new System.Drawing.Point(0, 0);
            this.panelsocial.Name = "panelsocial";
            this.panelsocial.Size = new System.Drawing.Size(388, 108);
            this.panelsocial.TabIndex = 4;
            // 
            // roundedpanelsocial
            // 
            this.roundedpanelsocial.BackColor = System.Drawing.Color.Coral;
            this.roundedpanelsocial.BorderRadius = 30;
            this.roundedpanelsocial.Controls.Add(this.title_social);
            this.roundedpanelsocial.ForeColor = System.Drawing.Color.Black;
            this.roundedpanelsocial.GradientAngle = 90F;
            this.roundedpanelsocial.GradientBottomColor = System.Drawing.Color.Empty;
            this.roundedpanelsocial.GradientTopColor = System.Drawing.Color.Empty;
            this.roundedpanelsocial.Location = new System.Drawing.Point(20, 3);
            this.roundedpanelsocial.Name = "roundedpanelsocial";
            this.roundedpanelsocial.Size = new System.Drawing.Size(267, 84);
            this.roundedpanelsocial.TabIndex = 3;
            this.roundedpanelsocial.Click += new System.EventHandler(this.roundedpanelsocial_Click);
            // 
            // title_social
            // 
            this.title_social.BackColor = System.Drawing.Color.Transparent;
            this.title_social.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_social.ForeColor = System.Drawing.Color.Transparent;
            this.title_social.Location = new System.Drawing.Point(8, 9);
            this.title_social.Name = "title_social";
            this.title_social.Size = new System.Drawing.Size(251, 35);
            this.title_social.TabIndex = 0;
            // 
            // deletesocial
            // 
            this.deletesocial.Image = ((System.Drawing.Image)(resources.GetObject("deletesocial.Image")));
            this.deletesocial.Location = new System.Drawing.Point(1, 26);
            this.deletesocial.Name = "deletesocial";
            this.deletesocial.Size = new System.Drawing.Size(81, 40);
            this.deletesocial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletesocial.TabIndex = 0;
            this.deletesocial.TabStop = false;
            this.deletesocial.Click += new System.EventHandler(this.deletesocial_Click);
            // 
            // socialid
            // 
            this.socialid.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socialid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.socialid.Location = new System.Drawing.Point(78, 26);
            this.socialid.Name = "socialid";
            this.socialid.Size = new System.Drawing.Size(45, 40);
            this.socialid.TabIndex = 4;
            // 
            // SocialUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelsocial);
            this.Name = "SocialUC";
            this.Size = new System.Drawing.Size(290, 108);
            this.panelsocial.ResumeLayout(false);
            this.roundedpanelsocial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletesocial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsocial;
        private roundedpanel roundedpanelsocial;
        public System.Windows.Forms.Label title_social;
        private System.Windows.Forms.PictureBox deletesocial;
        private System.Windows.Forms.Label socialid;
    }
}
