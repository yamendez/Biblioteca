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
    public partial class frmMostrarLibro : Form
    {
        public frmMostrarLibro()
        {
            InitializeComponent();
            Libros libros = new Libros();
            MySqlDataReader list = libros.Consultar();

            while (list.Read())
            {
                dgvTabla.Rows.Add(
                    list.GetString(0),
                    list.GetString(1),
                    list.GetString(2),
                    list.GetString(3),
                    list.GetString(4)
                    );
            }
        }

        private void btnAgregarL_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarLibro addlib = new frmAgregarLibro();
            addlib.Show();
        }
    }
}
