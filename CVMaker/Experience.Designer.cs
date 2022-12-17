
namespace CVMaker
{
    partial class Experience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Experience));
            this.panelex = new System.Windows.Forms.Panel();
            this.experiencepanel = new CVMaker.roundedpanel();
            this.end_experience = new System.Windows.Forms.Label();
            this.start_experience = new System.Windows.Forms.Label();
            this.titleexperience = new System.Windows.Forms.Label();
            this.deleteexperience = new System.Windows.Forms.PictureBox();
            this.expid = new System.Windows.Forms.Label();
            this.panelex.SuspendLayout();
            this.experiencepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteexperience)).BeginInit();
            this.SuspendLayout();
            // 
            // panelex
            // 
            this.panelex.Controls.Add(this.experiencepanel);
            this.panelex.Controls.Add(this.deleteexperience);
            this.panelex.Controls.Add(this.expid);
            this.panelex.Location = new System.Drawing.Point(0, 0);
            this.panelex.Name = "panelex";
            this.panelex.Size = new System.Drawing.Size(388, 108);
            this.panelex.TabIndex = 2;
            // 
            // experiencepanel
            // 
            this.experiencepanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.experiencepanel.BorderRadius = 30;
            this.experiencepanel.Controls.Add(this.end_experience);
            this.experiencepanel.Controls.Add(this.start_experience);
            this.experiencepanel.Controls.Add(this.titleexperience);
            this.experiencepanel.ForeColor = System.Drawing.Color.Black;
            this.experiencepanel.GradientAngle = 90F;
            this.experiencepanel.GradientBottomColor = System.Drawing.Color.Empty;
            this.experiencepanel.GradientTopColor = System.Drawing.Color.Empty;
            this.experiencepanel.Location = new System.Drawing.Point(22, 1);
            this.experiencepanel.Name = "experiencepanel";
            this.experiencepanel.Size = new System.Drawing.Size(267, 84);
            this.experiencepanel.TabIndex = 2;
            this.experiencepanel.Click += new System.EventHandler(this.expericebtnclick);
            // 
            // end_experience
            // 
            this.end_experience.BackColor = System.Drawing.Color.Transparent;
            this.end_experience.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_experience.ForeColor = System.Drawing.Color.Transparent;
            this.end_experience.Location = new System.Drawing.Point(160, 41);
            this.end_experience.Name = "end_experience";
            this.end_experience.Size = new System.Drawing.Size(110, 23);
            this.end_experience.TabIndex = 0;
            // 
            // start_experience
            // 
            this.start_experience.BackColor = System.Drawing.Color.Transparent;
            this.start_experience.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_experience.ForeColor = System.Drawing.Color.Transparent;
            this.start_experience.Location = new System.Drawing.Point(3, 41);
            this.start_experience.Name = "start_experience";
            this.start_experience.Size = new System.Drawing.Size(117, 23);
            this.start_experience.TabIndex = 0;
            // 
            // titleexperience
            // 
            this.titleexperience.BackColor = System.Drawing.Color.Transparent;
            this.titleexperience.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleexperience.ForeColor = System.Drawing.Color.Transparent;
            this.titleexperience.Location = new System.Drawing.Point(8, 3);
            this.titleexperience.Name = "titleexperience";
            this.titleexperience.Size = new System.Drawing.Size(251, 35);
            this.titleexperience.TabIndex = 0;
            // 
            // deleteexperience
            // 
            this.deleteexperience.Image = ((System.Drawing.Image)(resources.GetObject("deleteexperience.Image")));
            this.deleteexperience.Location = new System.Drawing.Point(1, 26);
            this.deleteexperience.Name = "deleteexperience";
            this.deleteexperience.Size = new System.Drawing.Size(81, 40);
            this.deleteexperience.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteexperience.TabIndex = 0;
            this.deleteexperience.TabStop = false;
            this.deleteexperience.Click += new System.EventHandler(this.deleteexperience_Click);
            // 
            // expid
            // 
            this.expid.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.expid.Location = new System.Drawing.Point(78, 26);
            this.expid.Name = "expid";
            this.expid.Size = new System.Drawing.Size(45, 40);
            this.expid.TabIndex = 3;
            // 
            // Experience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelex);
            this.Name = "Experience";
            this.Size = new System.Drawing.Size(291, 108);
            this.panelex.ResumeLayout(false);
            this.experiencepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteexperience)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelex;
        private System.Windows.Forms.PictureBox deleteexperience;
        private roundedpanel experiencepanel;
        public System.Windows.Forms.Label end_experience;
        public System.Windows.Forms.Label start_experience;
        public System.Windows.Forms.Label titleexperience;
        private System.Windows.Forms.Label expid;
    }
}
