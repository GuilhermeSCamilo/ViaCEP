namespace ViaCEP
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.dgvCep = new System.Windows.Forms.DataGridView();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(119, 361);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 50);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(119, 335);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(116, 20);
            this.txbCEP.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(114, 308);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Digite o CEP!";
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.lblDDD);
            this.grbResultado.Controls.Add(this.lblUF);
            this.grbResultado.Controls.Add(this.lblLocalidade);
            this.grbResultado.Controls.Add(this.lblBairro);
            this.grbResultado.Controls.Add(this.lblComplemento);
            this.grbResultado.Controls.Add(this.lblLogradouro);
            this.grbResultado.Location = new System.Drawing.Point(83, 59);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(190, 224);
            this.grbResultado.TabIndex = 3;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado:";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(7, 137);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(31, 13);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(7, 114);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "UF";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(7, 90);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidade.TabIndex = 3;
            this.lblLocalidade.Text = "Localidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(7, 68);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(7, 45);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 1;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(7, 20);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // dgvCep
            // 
            this.dgvCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCep.Location = new System.Drawing.Point(329, 59);
            this.dgvCep.Name = "dgvCep";
            this.dgvCep.Size = new System.Drawing.Size(315, 296);
            this.dgvCep.TabIndex = 4;
            this.dgvCep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCep_CellClick);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(329, 361);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(94, 50);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar Selecionado";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.Location = new System.Drawing.Point(553, 361);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(91, 50);
            this.btnApagarTudo.TabIndex = 6;
            this.btnApagarTudo.Text = "Apagar Tudo";
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(429, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 50);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar CEP";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.dgvCep);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.DataGridView dgvCep;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

