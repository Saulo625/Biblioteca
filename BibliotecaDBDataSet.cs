using System;
using System.Windows.Forms;

namespace Biblioteca
{


    partial class BibliotecaDBDataSet
    {
        partial class UsuarioRow
        {
            public override string ToString()
            {
                return UsuarioID.ToString() + "-" + Nome;
            }
        }

    }
}


