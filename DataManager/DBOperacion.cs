using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager
{
    internal class DBOperacion:DBConexion
    {

        private Int32 EjecutarSentencia(String sentencia)
        {
            Int32 filasAfectadas = 0;
            MySqlCommand comando = new MySqlCommand();

            if (base.Conectar())
            {
                comando.Connection = base.conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;

                try
                {

                }
                catch (Exception)
                {
                    filasAfectadas = -1;
                }
                base.Desconectar();
            }

            return filasAfectadas;

        }

        private DataTable Consultar(String consulta)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            MySqlCommand comando = new MySqlCommand();
            DataTable resultado = new DataTable();
            if (base.Conectar())
            {
                comando.Connection = base.conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                adaptador.SelectCommand = comando;
                try
                {
                    adaptador.Fill(resultado);
                }
                catch (Exception)
                {
                    resultado = new DataTable();
                }
                base.Desconectar();
            }
            return resultado;
        }

    }
}
