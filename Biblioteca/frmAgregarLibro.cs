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
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
            cbxGene.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.Titulo = txtTitulo.Text;
            libros.Autor = txtAutor.Text;
            libros.Editorial = txtEdito.Text;
            libros.Genero = cbxGene.SelectedIndex;
            libros.Cantidad = int.Parse(txtCant.Text);

            libros.Registrar();

            //this.Hide();
            //frmMostrarLibro showlib = new frmMostrarLibro();
            //showlib.Show();
        }
    }
}
