namespace Simply
{
    partial class FrmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobre));
            this.lblDesenvolvedores = new System.Windows.Forms.Label();
            this.ptvSimply = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptvSimply)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesenvolvedores
            // 
            this.lblDesenvolvedores.AutoSize = true;
            this.lblDesenvolvedores.Location = new System.Drawing.Point(50, 19);
            this.lblDesenvolvedores.Name = "lblDesenvolvedores";
            this.lblDesenvolvedores.Size = new System.Drawing.Size(268, 104);
            this.lblDesenvolvedores.TabIndex = 0;
            this.lblDesenvolvedores.Text = resources.GetString("lblDesenvolvedores.Text");
            // 
            // ptvSimply
            // 
            this.ptvSimply.Image = global::Simply.Properties.Resources.LOGO_simply_vermelha1;
            this.ptvSimply.Location = new System.Drawing.Point(235, 30);
            this.ptvSimply.Name = "ptvSimply";
            this.ptvSimply.Size = new System.Drawing.Size(94, 93);
            this.ptvSimply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptvSimply.TabIndex = 1;
            this.ptvSimply.TabStop = false;
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(367, 147);
            this.Controls.Add(this.ptvSimply);
            this.Controls.Add(this.lblDesenvolvedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSobre";
            this.Text = "Sobre o Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.ptvSimply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesenvolvedores;
        private System.Windows.Forms.PictureBox ptvSimply;
    }
}