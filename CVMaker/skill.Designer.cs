
namespace CVMaker
{
    partial class skill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skill));
            this.panelskill = new System.Windows.Forms.Panel();
            this.roundedpanelskill = new CVMaker.roundedpanel();
            this.level_skill = new System.Windows.Forms.Label();
            this.title_skill = new System.Windows.Forms.Label();
            this.deleteskill = new System.Windows.Forms.PictureBox();
            this.skillid = new System.Windows.Forms.Label();
            this.panelskill.SuspendLayout();
            this.roundedpanelskill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteskill)).BeginInit();
            this.SuspendLayout();
            // 
            // panelskill
            // 
            this.panelskill.Controls.Add(this.roundedpanelskill);
            this.panelskill.Controls.Add(this.deleteskill);
            this.panelskill.Controls.Add(this.skillid);
            this.panelskill.Location = new System.Drawing.Point(0, 0);
            this.panelskill.Name = "panelskill";
            this.panelskill.Size = new System.Drawing.Size(388, 108);
            this.panelskill.TabIndex = 2;
            this.panelskill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelskill_Paint);
            // 
            // roundedpanelskill
            // 
            this.roundedpanelskill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.roundedpanelskill.BorderRadius = 30;
            this.roundedpanelskill.Controls.Add(this.level_skill);
            this.roundedpanelskill.Controls.Add(this.title_skill);
            this.roundedpanelskill.ForeColor = System.Drawing.Color.Black;
            this.roundedpanelskill.GradientAngle = 90F;
            this.roundedpanelskill.GradientBottomColor = System.Drawing.Color.Empty;
            this.roundedpanelskill.GradientTopColor = System.Drawing.Color.Empty;
            this.roundedpanelskill.Location = new System.Drawing.Point(20, 3);
            this.roundedpanelskill.Name = "roundedpanelskill";
            this.roundedpanelskill.Size = new System.Drawing.Size(267, 84);
            this.roundedpanelskill.TabIndex = 3;
            this.roundedpanelskill.Click += new System.EventHandler(this.skillbuttonclick);
            // 
            // level_skill
            // 
            this.level_skill.BackColor = System.Drawing.Color.Transparent;
            this.level_skill.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_skill.ForeColor = System.Drawing.Color.Transparent;
            this.level_skill.Location = new System.Drawing.Point(11, 54);
            this.level_skill.Name = "level_skill";
            this.level_skill.Size = new System.Drawing.Size(117, 23);
            this.level_skill.TabIndex = 0;
            this.level_skill.Click += new System.EventHandler(this.level_skill_Click);
            // 
            // title_skill
            // 
            this.title_skill.BackColor = System.Drawing.Color.Transparent;
            this.title_skill.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_skill.ForeColor = System.Drawing.Color.Transparent;
            this.title_skill.Location = new System.Drawing.Point(8, 9);
            this.title_skill.Name = "title_skill";
            this.title_skill.Size = new System.Drawing.Size(251, 35);
            this.title_skill.TabIndex = 0;
            // 
            // deleteskill
            // 
            this.deleteskill.Image = ((System.Drawing.Image)(resources.GetObject("deleteskill.Image")));
            this.deleteskill.Location = new System.Drawing.Point(1, 26);
            this.deleteskill.Name = "deleteskill";
            this.deleteskill.Size = new System.Drawing.Size(81, 40);
            this.deleteskill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteskill.TabIndex = 0;
            this.deleteskill.TabStop = false;
            this.deleteskill.Click += new System.EventHandler(this.deleteskill_Click);
            // 
            // skillid
            // 
            this.skillid.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.skillid.Location = new System.Drawing.Point(78, 26);
            this.skillid.Name = "skillid";
            this.skillid.Size = new System.Drawing.Size(45, 40);
            this.skillid.TabIndex = 4;
            // 
            // skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelskill);
            this.Name = "skill";
            this.Size = new System.Drawing.Size(290, 108);
            this.panelskill.ResumeLayout(false);
            this.roundedpanelskill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteskill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelskill;
        private System.Windows.Forms.PictureBox deleteskill;
        private roundedpanel roundedpanelskill;
        public System.Windows.Forms.Label level_skill;
        public System.Windows.Forms.Label title_skill;
        private System.Windows.Forms.Label skillid;
    }
}
