using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataManager
{
    public class DBConexion
    {
        String cadenaConexion = "Server=localhost;Port=3306;Database=bd_inventario;Uid=userInventario;Pwd=Pa55word;";
        protected MySqlConnection conexion = new MySqlConnection();
        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                result = true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return result;
        }
        public void Desconectar()
        {
            try
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
