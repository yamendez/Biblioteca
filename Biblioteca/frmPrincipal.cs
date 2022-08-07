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
    public partial class frmPrincipal : Form
    {
        private Form frmactivo = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            if (frmactivo != null)
            {
                frmactivo.Close();
                frmactivo = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                pnlPantalla.Controls.Add(form);
                pnlPantalla.Tag = form;
                form.Show();
            }
            else
            {
                frmactivo = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                pnlPantalla.Controls.Add(form);
                pnlPantalla.Tag = form;
                form.Show();

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OpenForm(new frmMostrarLibro());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAgregarLibro());
        }
    }
}
