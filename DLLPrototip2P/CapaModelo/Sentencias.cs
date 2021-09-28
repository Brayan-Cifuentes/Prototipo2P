using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion conn = new Conexion();
        TextBox[] alias;
        int cantidad = 0;

        
        public void asignarAlias(TextBox[] campos)
        {
            int contador = 0;
            foreach (TextBox i in campos)
            {
                contador++;
            }

            alias = new TextBox[contador];
            cantidad = contador;

            int j = 0;
            for (int i=0; i< contador; i++) 
            {
                //llenado 
                alias[j] = campos[i];
                j++;
            }
        }
        
        public void funcInsertar(string tabla)
        {

            string sql = "INSERT INTO" + " " + tabla + " " + "("+"";

            for (int j = 0; j< cantidad; j++)
            {
                if (j != (cantidad-1))
                {
                    sql += " "+alias[j].Tag.ToString() + ", ";
                }
                else
                {
                    sql += " "+alias[j].Tag.ToString()+") ";
                }
            }

            sql += " VALUES (";
            
            for (int j=0; j<cantidad; j++)
            {
                if (j!=(cantidad-1))
                {
                    sql += " '" + alias[j].Text + "', ";
                }
                else
                {
                    sql += " '" + alias[j].Text+"')";
                }
                
            }
           

            OdbcConnection conexion = conn.conexion();

            try
            {
                OdbcCommand insertar = new OdbcCommand(sql, conexion);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Guardar los datos "+e.ToString());
            }
            finally
            {
                conn.cerrar(conexion);
            }
        }


        /*Modificar, id es el campo que se llama id en la BD*/
        public void funModificar(string id, string tabla)
        {  
            string sqlModificar = "UPDATE" + " " + tabla + " "+"SET";
            
            for (int j=0; j<cantidad; j++)
            {
                if (j!= (cantidad - 1))
                {
                    sqlModificar += " " + alias[j].Tag.ToString() + " = '" + alias[j].Text + "',";
                }
                else
                {
                    sqlModificar += " " + alias[j].Tag.ToString() + " = '" + alias[j].Text + "' "+ " WHERE " + " " + id + " = '" + alias[0].Text+"'";
                }
            }

            //MessageBox.Show(sqlModificar);

            OdbcConnection conexionBD = conn.conexion();

            try
            {
                OdbcCommand modificar = new OdbcCommand(sqlModificar, conexionBD);
                modificar.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Modificar los datos "+e.ToString());
            }
            finally
            {
                conn.cerrar(conexionBD);
            }
        }


        public void funcEliminar(string campoBaja, string campoId, string tabla)
        {
            
            string sqlBaja = "UPDATE" + " " + tabla + " " + "SET" + " " + campoBaja + "  = 'I' WHERE " + " " + campoId + "= '" + alias[0].Text + "'";

            //MessageBox.Show(sqlBaja);
            OdbcConnection conexionBD = conn.conexion();

            try
            {
                OdbcCommand eliminar = new OdbcCommand(sqlBaja, conexionBD);
                eliminar.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Eliminar los datos " + e.ToString());
            }
            finally
            {
                conn.cerrar(conexionBD);
            }
        }


        //Contenido de una tabla
        public OdbcDataAdapter llenarTbl(string tabla, string estatus)
        {
            
            //string para almacenar los campos de 
            string sql = "select * from " + tabla +" "+"WHERE"+" "+estatus+" "+ "= 'A';";
            OdbcConnection conexionBD = conn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexionBD);
            conn.cerrar(conexionBD);

            return dataTable;
        }

        //seleccionar datos
        public void funSeleccionarDT(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            if (filaSeleccionada != null) 
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    alias[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }


        /*Combobox*/
        public void funLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' ";
            //MessageBox.Show(psql);
            OdbcConnection conect = conn.conexion();


            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);

                DataTable dt = new DataTable();
                data.Fill(dt);

                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                //conexionBD.Close();
                conn.cerrar(conect);
            }
        }


        /*valor de combobox (id) textbox*/
        public void funComboTextbox(ComboBox combo, TextBox combotexto)
        {
            if (combo.SelectedValue == null)
            {
                return;
            }
            String cbx = combo.SelectedValue.ToString();
            combotexto.Text = cbx;

        }

        /*Textbox a combobox*/
        public void funTextboxCombo(ComboBox combo, TextBox combotexto)
        {
            combo.SelectedValue = combotexto.Text.ToString();
        }
    }
}
