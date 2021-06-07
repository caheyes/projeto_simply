namespace Simply
{
    partial class FrmConsultaEspecifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEspecifica));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadastroSistema = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lklAjuda = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTabelaGeral = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabelaGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por CPF:";
            // 
            // lblCadastroSistema
            // 
            this.lblCadastroSistema.AutoSize = true;
            this.lblCadastroSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSistema.Location = new System.Drawing.Point(38, 9);
            this.lblCadastroSistema.Name = "lblCadastroSistema";
            this.lblCadastroSistema.Size = new System.Drawing.Size(335, 25);
            this.lblCadastroSistema.TabIndex = 3;
            this.lblCadastroSistema.Text = "Pesquisar Cadastro Específico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Por nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 14;
            // 
            // lklAjuda
            // 
            this.lklAjuda.ActiveLinkColor = System.Drawing.Color.LightCyan;
            this.lklAjuda.AutoSize = true;
            this.lklAjuda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lklAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklAjuda.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lklAjuda.LinkColor = System.Drawing.Color.LightBlue;
            this.lklAjuda.Location = new System.Drawing.Point(757, 16);
            this.lklAjuda.Name = "lklAjuda";
            this.lklAjuda.Size = new System.Drawing.Size(38, 15);
            this.lklAjuda.TabIndex = 49;
            this.lklAjuda.TabStop = true;
            this.lklAjuda.Text = "Ajuda";
            this.lklAjuda.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Digite o Nome ou o CPF do usuário para encontrar o cadastro:";
            // 
            // dgTabelaGeral
            // 
            this.dgTabelaGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabelaGeral.Location = new System.Drawing.Point(43, 136);
            this.dgTabelaGeral.Name = "dgTabelaGeral";
            this.dgTabelaGeral.Size = new System.Drawing.Size(723, 263);
            this.dgTabelaGeral.TabIndex = 51;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAtualizar.FlatAppearance.BorderSize = 2;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Location = new System.Drawing.Point(579, 409);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(85, 37);
            this.btnAtualizar.TabIndex = 52;
            this.btnAtualizar.Text = "Selecionar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(681, 409);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 37);
            this.btnConsultar.TabIndex = 56;
            this.btnConsultar.Text = "Voltar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultaEspecifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgTabelaGeral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lklAjuda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadastroSistema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaEspecifica";
            this.Text = "ConsultaEspecifica";
            ((System.ComponentModel.ISupportInitialize)(this.dgTabelaGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCadastroSistema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel lklAjuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTabelaGeral;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnConsultar;
    }
}