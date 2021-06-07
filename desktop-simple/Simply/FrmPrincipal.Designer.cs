namespace Simply
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnMenuCadastrar = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnTransacao = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptvSimply = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblInfoSobre = new System.Windows.Forms.Label();
            this.lklSite = new System.Windows.Forms.LinkLabel();
            this.lklBaixeApp = new System.Windows.Forms.LinkLabel();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.lblDatadoDia = new System.Windows.Forms.Label();
            this.lblHorariodoDia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptvSimply)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuCadastrar
            // 
            this.btnMenuCadastrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMenuCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenuCadastrar.FlatAppearance.BorderSize = 2;
            this.btnMenuCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMenuCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMenuCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuCadastrar.Location = new System.Drawing.Point(50, 55);
            this.btnMenuCadastrar.Name = "btnMenuCadastrar";
            this.btnMenuCadastrar.Size = new System.Drawing.Size(85, 37);
            this.btnMenuCadastrar.TabIndex = 0;
            this.btnMenuCadastrar.Text = "Cadastrar";
            this.btnMenuCadastrar.UseVisualStyleBackColor = false;
            this.btnMenuCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(45, 27);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(68, 25);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Início";
            this.lblInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTransacao
            // 
            this.btnTransacao.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTransacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransacao.FlatAppearance.BorderSize = 2;
            this.btnTransacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTransacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransacao.Location = new System.Drawing.Point(131, 55);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Size = new System.Drawing.Size(85, 37);
            this.btnTransacao.TabIndex = 2;
            this.btnTransacao.Text = "Transação";
            this.btnTransacao.UseVisualStyleBackColor = false;
            this.btnTransacao.Click += new System.EventHandler(this.btnTransacao_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRelatorio.FlatAppearance.BorderSize = 2;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorio.Location = new System.Drawing.Point(216, 55);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(85, 37);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSobre.FlatAppearance.BorderSize = 2;
            this.btnSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSobre.Location = new System.Drawing.Point(50, 392);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(85, 37);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(596, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(85, 37);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptvSimply);
            this.groupBox1.Location = new System.Drawing.Point(337, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ptvSimply
            // 
            this.ptvSimply.Image = global::Simply.Properties.Resources.LOGO_simply_vermelha1;
            this.ptvSimply.Location = new System.Drawing.Point(33, 19);
            this.ptvSimply.Name = "ptvSimply";
            this.ptvSimply.Size = new System.Drawing.Size(280, 288);
            this.ptvSimply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptvSimply.TabIndex = 0;
            this.ptvSimply.TabStop = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(299, 9);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(132, 25);
            this.lblBemVindo.TabIndex = 7;
            this.lblBemVindo.Text = "Bem Vindo!";
            // 
            // lblInfoSobre
            // 
            this.lblInfoSobre.AutoSize = true;
            this.lblInfoSobre.Location = new System.Drawing.Point(47, 124);
            this.lblInfoSobre.Name = "lblInfoSobre";
            this.lblInfoSobre.Size = new System.Drawing.Size(284, 78);
            this.lblInfoSobre.TabIndex = 8;
            this.lblInfoSobre.Text = resources.GetString("lblInfoSobre.Text");
            // 
            // lklSite
            // 
            this.lklSite.AutoSize = true;
            this.lklSite.Location = new System.Drawing.Point(47, 217);
            this.lklSite.Name = "lklSite";
            this.lklSite.Size = new System.Drawing.Size(128, 13);
            this.lklSite.TabIndex = 10;
            this.lklSite.TabStop = true;
            this.lklSite.Text = "Visite: www.simply.com.br";
            // 
            // lklBaixeApp
            // 
            this.lklBaixeApp.AutoSize = true;
            this.lklBaixeApp.Location = new System.Drawing.Point(47, 240);
            this.lklBaixeApp.Name = "lklBaixeApp";
            this.lklBaixeApp.Size = new System.Drawing.Size(126, 13);
            this.lklBaixeApp.TabIndex = 11;
            this.lklBaixeApp.TabStop = true;
            this.lklBaixeApp.Text = "Baixe o aplicativo: Simply";
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.Red;
            this.btnConfiguracao.BackgroundImage = global::Simply.Properties.Resources.icone_engrenagem;
            this.btnConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConfiguracao.FlatAppearance.BorderSize = 2;
            this.btnConfiguracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.btnConfiguracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguracao.Location = new System.Drawing.Point(141, 392);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(47, 37);
            this.btnConfiguracao.TabIndex = 9;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // lblDatadoDia
            // 
            this.lblDatadoDia.AutoSize = true;
            this.lblDatadoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatadoDia.Location = new System.Drawing.Point(432, 404);
            this.lblDatadoDia.Name = "lblDatadoDia";
            this.lblDatadoDia.Size = new System.Drawing.Size(33, 15);
            this.lblDatadoDia.TabIndex = 12;
            this.lblDatadoDia.Text = "Data";
            this.lblDatadoDia.Click += new System.EventHandler(this.lblDatadoDia_Click);
            // 
            // lblHorariodoDia
            // 
            this.lblHorariodoDia.AutoSize = true;
            this.lblHorariodoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorariodoDia.Location = new System.Drawing.Point(510, 404);
            this.lblHorariodoDia.Name = "lblHorariodoDia";
            this.lblHorariodoDia.Size = new System.Drawing.Size(34, 15);
            this.lblHorariodoDia.TabIndex = 13;
            this.lblHorariodoDia.Text = "Hora";
            this.lblHorariodoDia.Click += new System.EventHandler(this.lblHorariodoDia_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Build 1.0 version";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHorariodoDia);
            this.Controls.Add(this.lblDatadoDia);
            this.Controls.Add(this.lklBaixeApp);
            this.Controls.Add(this.lklSite);
            this.Controls.Add(this.btnConfiguracao);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnTransacao);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.btnMenuCadastrar);
            this.Controls.Add(this.lblInfoSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simply Bem vindo!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptvSimply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuCadastrar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnTransacao;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptvSimply;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblInfoSobre;
        private System.Windows.Forms.Button btnConfiguracao;
        private System.Windows.Forms.LinkLabel lklSite;
        private System.Windows.Forms.LinkLabel lklBaixeApp;
        private System.Windows.Forms.Label lblDatadoDia;
        private System.Windows.Forms.Label lblHorariodoDia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

