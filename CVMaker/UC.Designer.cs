
namespace CVMaker
{
    partial class UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC));
            this.panelll = new System.Windows.Forms.Panel();
            this.editeducation = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedpanel1 = new CVMaker.roundedpanel();
            this.end_edu = new System.Windows.Forms.Label();
            this.start_edu = new System.Windows.Forms.Label();
            this.title_edu = new System.Windows.Forms.Label();
            this.panelll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editeducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelll
            // 
            this.panelll.Controls.Add(this.editeducation);
            this.panelll.Controls.Add(this.pictureBox1);
            this.panelll.Location = new System.Drawing.Point(0, 0);
            this.panelll.Name = "panelll";
            this.panelll.Size = new System.Drawing.Size(388, 108);
            this.panelll.TabIndex = 1;
            this.panelll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelll_Paint);
            // 
            // editeducation
            // 
            this.editeducation.Image = ((System.Drawing.Image)(resources.GetObject("editeducation.Image")));
            this.editeducation.Location = new System.Drawing.Point(78, 26);
            this.editeducation.Name = "editeducation";
            this.editeducation.Size = new System.Drawing.Size(45, 40);
            this.editeducation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editeducation.TabIndex = 1;
            this.editeducation.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.deletebtnclick);
            // 
            // roundedpanel1
            // 
            this.roundedpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.roundedpanel1.BorderRadius = 30;
            this.roundedpanel1.Controls.Add(this.end_edu);
            this.roundedpanel1.Controls.Add(this.start_edu);
            this.roundedpanel1.Controls.Add(this.title_edu);
            this.roundedpanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedpanel1.GradientAngle = 90F;
            this.roundedpanel1.GradientBottomColor = System.Drawing.Color.Empty;
            this.roundedpanel1.GradientTopColor = System.Drawing.Color.Empty;
            this.roundedpanel1.Location = new System.Drawing.Point(22, 1);
            this.roundedpanel1.Name = "roundedpanel1";
            this.roundedpanel1.Size = new System.Drawing.Size(267, 84);
            this.roundedpanel1.TabIndex = 1;
            this.roundedpanel1.Click += new System.EventHandler(this.pnlperson);
            this.roundedpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedpanel1_Paint);
            // 
            // end_edu
            // 
            this.end_edu.BackColor = System.Drawing.Color.Transparent;
            this.end_edu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_edu.ForeColor = System.Drawing.Color.Transparent;
            this.end_edu.Location = new System.Drawing.Point(160, 54);
            this.end_edu.Name = "end_edu";
            this.end_edu.Size = new System.Drawing.Size(110, 23);
            this.end_edu.TabIndex = 0;
            // 
            // start_edu
            // 
            this.start_edu.BackColor = System.Drawing.Color.Transparent;
            this.start_edu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_edu.ForeColor = System.Drawing.Color.Transparent;
            this.start_edu.Location = new System.Drawing.Point(11, 54);
            this.start_edu.Name = "start_edu";
            this.start_edu.Size = new System.Drawing.Size(117, 23);
            this.start_edu.TabIndex = 0;
            // 
            // title_edu
            // 
            this.title_edu.BackColor = System.Drawing.Color.Transparent;
            this.title_edu.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_edu.ForeColor = System.Drawing.Color.Transparent;
            this.title_edu.Location = new System.Drawing.Point(8, 9);
            this.title_edu.Name = "title_edu";
            this.title_edu.Size = new System.Drawing.Size(251, 35);
            this.title_edu.TabIndex = 0;
            // 
            // UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedpanel1);
            this.Controls.Add(this.panelll);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC";
            this.Size = new System.Drawing.Size(290, 108);
            this.panelll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editeducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private roundedpanel roundedpanel1;
        public System.Windows.Forms.Label start_edu;
        public System.Windows.Forms.Label title_edu;
        public System.Windows.Forms.Label end_edu;
        private System.Windows.Forms.PictureBox editeducation;
    }
}
