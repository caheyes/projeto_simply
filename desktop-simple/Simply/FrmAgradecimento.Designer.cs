namespace Simply
{
    partial class FrmAgradecimento
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
            this.lblAgradecimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgradecimento
            // 
            this.lblAgradecimento.AutoSize = true;
            this.lblAgradecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgradecimento.Location = new System.Drawing.Point(29, 29);
            this.lblAgradecimento.Name = "lblAgradecimento";
            this.lblAgradecimento.Size = new System.Drawing.Size(179, 16);
            this.lblAgradecimento.TabIndex = 0;
            this.lblAgradecimento.Text = "Obrigado Por Usar a Simply!";
            // 
            // FrmAgradecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(231, 86);
            this.Controls.Add(this.lblAgradecimento);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgradecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgradecimento";
            this.Load += new System.EventHandler(this.FrmAgradecimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgradecimento;
    }
}