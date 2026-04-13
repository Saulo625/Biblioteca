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

namespace Biblioteca
{
    public partial class FormUsuarios : Form
    {
        private Livros formularioPrincipal;
        public FormUsuarios(Livros form)
        {
            formularioPrincipal = form;
            InitializeComponent();
            UsuarioTableAdapter usuarios = new UsuarioTableAdapter();
            var dados = from linha in usuarios.GetData() select linha;
            foreach (var linha  in dados) lboUsuarios.Items.Add(linha);
        }

        private void FormUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(); //para limpar da memoria
            Close();
            formularioPrincipal.Show();

        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            Dispose(); //para limpar da memoria
            Close();
            formularioPrincipal.Show();

        }

      
    }
}
