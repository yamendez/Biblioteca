using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal class Conexion
    {
        public static MySqlConnection Conectar()
        {
            string datoscon = "Database=biblioteca;Data Source=localhost;User Id=root;Password=admin";
            try
            {
                MySqlConnection con = new MySqlConnection(datoscon);
                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
