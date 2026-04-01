using Biblioteca.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.BibliotecaDBDataSet;

namespace Biblioteca
{
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
            AtualizarLista();

        }

        private void AtualizarLista()
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach (LivrosRow dado in dados) lboLivros.Items.Add(dado);
        }

        private void limparElementos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtGenero.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) return;
            LivrosRow livro =lboLivros.SelectedItem as LivrosRow;
            if (livro == null) return;
            btnAcoes.Text = "excluir";
            btnAjuste.Text = "Atualizar";
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtEditora.Text = livro.Editora;
            txtGenero.Text = livro.Genero;
            txtISBN.Text = livro.ISBN;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboLivros != null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar Lista";
                btnAjuste.Text = "cadastrar";
            }
        }
    }
}
