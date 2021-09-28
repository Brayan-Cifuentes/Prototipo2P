using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            //Creacion de conexion ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=SIU");

            try
            {
                conn.Open();
                //MessageBox.Show("Conexion de BD establecida");
            }
            catch (OdbcException)
            {
                MessageBox.Show("No se conectó a BD");
            }
            return conn;
        }

        //Método para cerrar la conexion
        public OdbcConnection cerrar(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }catch(OdbcException)
            {
                MessageBox.Show("No se establecio conexion");
            }
            
            return conn;
        }

       
    }
}
