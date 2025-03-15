using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Agenda
{
    internal class datos
    {
        String cadenaConexion = "Data Source= CESAR\\YO;" + "integrated security=true; initial catalog=Agenda; encrypt=false";
        SqlConnection conexion;

        private SqlConnection AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); //Abrir conexion a base de datos
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataSet query(String query)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, AbrirConexion());
                sqlDataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString);
                return null;
            }
        }

        public bool command(string consulta)
        {
            try
            {
                SqlCommand command = new SqlCommand(consulta, AbrirConexion());
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
    }
}
   