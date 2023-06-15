using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaCartera.Clases
{
    internal class cConexion
    {
        //Se define la ruta en la base de datos 
        static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandr\Desktop\IUE\Semestre_2022-2\Poo\SistemaCartera\BdPolizas.mdf;Integrated Security=True;Connect Timeout=30";

        //Definir una variable para cargar la base de datos 
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //método para abrir la base de datos 
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //método para cerrar la base de datos 
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
