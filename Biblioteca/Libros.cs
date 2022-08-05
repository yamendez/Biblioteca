using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    internal class Libros
    {
        public string Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public int Genero { get; set; }
        public string Editorial { get; set; }
        public int Cantidad { get; set; }

        public void Registrar()
        {
            string query = "insert into libros (titulo, id_genero, autor, editorial, cantidad) " +
                "values ('"+Titulo+ "', '" + Genero + "', '" + Autor + "', '" + Editorial + "', '" + Cantidad + "')";
            //Conexion con = new Conexion();
            MySqlConnection con = Conexion.Conectar();

            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Libro Guardado Correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
