using MySql.Data.MySqlClient;
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
    public partial class frmUpdateLibro : Form
    {
        int idupdate;
        public frmUpdateLibro(int id)
        {
            InitializeComponent();
            idupdate = id;
            Libros libros = new Libros();
            MySqlDataReader update = libros.ObtenerId(id);

            while (update.Read())
            {
                txtTitulo.Text = update.GetString(1);
                cbxGene.SelectedIndex = int.Parse(update.GetString(2));
                txtAutor.Text = update.GetString(3);
                txtEdito.Text = update.GetString(4);
                txtCant.Text = update.GetString(5);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            libros.Id = idupdate;
            libros.Titulo = txtTitulo.Text;
            libros.Autor = txtAutor.Text;
            libros.Editorial = txtEdito.Text;
            libros.Genero = cbxGene.SelectedIndex;
            libros.Cantidad = int.Parse(txtCant.Text);

            libros.Actualizar();
            this.Close();
        }
    }
}
