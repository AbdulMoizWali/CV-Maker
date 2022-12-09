
namespace CVMaker
{
    partial class popupCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popupCV));
            this.displaybox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displaybox)).BeginInit();
            this.SuspendLayout();
            // 
            // displaybox
            // 
            this.displaybox.Location = new System.Drawing.Point(-1, 0);
            this.displaybox.Name = "displaybox";
            this.displaybox.Size = new System.Drawing.Size(511, 652);
            this.displaybox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displaybox.TabIndex = 1;
            this.displaybox.TabStop = false;
            // 
            // popupCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 651);
            this.Controls.Add(this.displaybox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "popupCV";
            this.Text = "popupCV";
            ((System.ComponentModel.ISupportInitialize)(this.displaybox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox displaybox;
    }
}