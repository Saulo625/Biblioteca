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
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.txtTitulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGenero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtQuantidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtISBN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEditora = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAutor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAjuste = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAcoes = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lboLivros
            // 
            this.lboLivros.BackColor = System.Drawing.Color.Gray;
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.Location = new System.Drawing.Point(382, 42);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(357, 368);
            this.lboLivros.TabIndex = 12;
            this.lboLivros.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Depth = 0;
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTitulo.Hint = "";
            this.txtTitulo.Location = new System.Drawing.Point(29, 60);
            this.txtTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.Size = new System.Drawing.Size(294, 23);
            this.txtTitulo.TabIndex = 16;
            this.txtTitulo.Text = "Digite o titulo do livro";
            this.txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.DimGray;
            this.txtGenero.Depth = 0;
            this.txtGenero.ForeColor = System.Drawing.SystemColors.Control;
            this.txtGenero.Hint = "";
            this.txtGenero.Location = new System.Drawing.Point(29, 188);
            this.txtGenero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.PasswordChar = '\0';
            this.txtGenero.SelectedText = "";
            this.txtGenero.SelectionLength = 0;
            this.txtGenero.SelectionStart = 0;
            this.txtGenero.Size = new System.Drawing.Size(294, 23);
            this.txtGenero.TabIndex = 17;
            this.txtGenero.Text = "Digite o genero";
            this.txtGenero.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.DimGray;
            this.txtQuantidade.Depth = 0;
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.Hint = "";
            this.txtQuantidade.Location = new System.Drawing.Point(29, 325);
            this.txtQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.SelectionLength = 0;
            this.txtQuantidade.SelectionStart = 0;
            this.txtQuantidade.Size = new System.Drawing.Size(294, 23);
            this.txtQuantidade.TabIndex = 18;
            this.txtQuantidade.Text = "Digite a quantidade";
            this.txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.DimGray;
            this.txtISBN.Depth = 0;
            this.txtISBN.ForeColor = System.Drawing.SystemColors.Control;
            this.txtISBN.Hint = "";
            this.txtISBN.Location = new System.Drawing.Point(29, 387);
            this.txtISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.SelectedText = "";
            this.txtISBN.SelectionLength = 0;
            this.txtISBN.SelectionStart = 0;
            this.txtISBN.Size = new System.Drawing.Size(294, 23);
            this.txtISBN.TabIndex = 19;
            this.txtISBN.Text = "Digite o ISBN";
            this.txtISBN.UseSystemPasswordChar = false;
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.Color.DimGray;
            this.txtEditora.Depth = 0;
            this.txtEditora.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEditora.Hint = "";
            this.txtEditora.Location = new System.Drawing.Point(29, 255);
            this.txtEditora.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.PasswordChar = '\0';
            this.txtEditora.SelectedText = "";
            this.txtEditora.SelectionLength = 0;
            this.txtEditora.SelectionStart = 0;
            this.txtEditora.Size = new System.Drawing.Size(294, 23);
            this.txtEditora.TabIndex = 20;
            this.txtEditora.Text = "Digite a editora";
            this.txtEditora.UseSystemPasswordChar = false;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.DimGray;
            this.txtAutor.Depth = 0;
            this.txtAutor.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAutor.Hint = "";
            this.txtAutor.Location = new System.Drawing.Point(29, 121);
            this.txtAutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.Size = new System.Drawing.Size(294, 23);
            this.txtAutor.TabIndex = 21;
            this.txtAutor.Text = "Digite o nome do autor";
            this.txtAutor.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Titulo:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 98);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Autor:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Genero:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Editora:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 302);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(88, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "Quantidade:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(25, 364);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 27;
            this.materialLabel6.Text = "ISBN:";
            // 
            // btnAjuste
            // 
            this.btnAjuste.AutoSize = true;
            this.btnAjuste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjuste.BackColor = System.Drawing.Color.Silver;
            this.btnAjuste.Depth = 0;
            this.btnAjuste.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuste.Location = new System.Drawing.Point(63, 446);
            this.btnAjuste.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjuste.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Primary = false;
            this.btnAjuste.Size = new System.Drawing.Size(91, 36);
            this.btnAjuste.TabIndex = 28;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = false;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // btnAcoes
            // 
            this.btnAcoes.AutoSize = true;
            this.btnAcoes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcoes.BackColor = System.Drawing.Color.Silver;
            this.btnAcoes.Depth = 0;
            this.btnAcoes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoes.Location = new System.Drawing.Point(245, 446);
            this.btnAcoes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcoes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Primary = false;
            this.btnAcoes.Size = new System.Drawing.Size(125, 36);
            this.btnAcoes.TabIndex = 29;
            this.btnAcoes.Text = "Atualizar lista";
            this.btnAcoes.UseVisualStyleBackColor = false;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Location = new System.Drawing.Point(522, 446);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = false;
            this.btnLimpar.Size = new System.Drawing.Size(62, 36);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(773, 510);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lboLivros);
            this.MaximizeBox = false;
            this.Name = "Livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lboLivros;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGenero;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQuantidade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtISBN;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEditora;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAutor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton btnAjuste;
        private MaterialSkin.Controls.MaterialFlatButton btnAcoes;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpar;
    }
}

