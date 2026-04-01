namespace Biblioteca
{
    partial class Livros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.DimGray;
            this.lblAutor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(25, 98);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(47, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.DimGray;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(25, 302);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 20);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.DimGray;
            this.lblGenero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(25, 165);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 20);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.BackColor = System.Drawing.Color.DimGray;
            this.lblEditora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(25, 232);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(58, 20);
            this.lblEditora.TabIndex = 4;
            this.lblEditora.Text = "Editora:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.DimGray;
            this.lblISBN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(25, 364);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(44, 20);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Silver;
            this.txtTitulo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(29, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(306, 25);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.Silver;
            this.txtISBN.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(29, 387);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(306, 25);
            this.txtISBN.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.Silver;
            this.txtQuantidade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(29, 325);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(306, 25);
            this.txtQuantidade.TabIndex = 8;
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.Color.Silver;
            this.txtEditora.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(29, 255);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(306, 25);
            this.txtEditora.TabIndex = 9;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.Silver;
            this.txtGenero.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(29, 188);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(306, 25);
            this.txtGenero.TabIndex = 10;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.Silver;
            this.txtAutor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(29, 121);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(306, 25);
            this.txtAutor.TabIndex = 11;
            // 
            // lboLivros
            // 
            this.lboLivros.BackColor = System.Drawing.Color.Silver;
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(387, 48);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(357, 368);
            this.lboLivros.TabIndex = 12;
            this.lboLivros.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // btnAcoes
            // 
            this.btnAcoes.BackColor = System.Drawing.Color.Silver;
            this.btnAcoes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoes.Location = new System.Drawing.Point(218, 436);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(105, 46);
            this.btnAcoes.TabIndex = 13;
            this.btnAcoes.Text = "Atualizar";
            this.btnAcoes.UseVisualStyleBackColor = false;
            this.btnAcoes.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.BackColor = System.Drawing.Color.Silver;
            this.btnAjuste.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuste.Location = new System.Drawing.Point(55, 436);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(105, 46);
            this.btnAjuste.TabIndex = 14;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(513, 436);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 46);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(773, 510);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnLimpar;
    }
}

