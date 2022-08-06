﻿using MySql.Data.MySqlClient;
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

        public MySqlDataReader Consultar()
        {
            //MySqlDataReader libros = null;
            string query = "select t1.titulo, t2.genero, t1.autor, t1.editorial, t1.cantidad " +
                "from libros t1 inner join generos t2 " +
                "on t1.id_genero = t2.id";
            //string sql = "select * from libros";

            MySqlConnection con = Conexion.Conectar();
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader libros = cmd.ExecuteReader();
                return libros;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
