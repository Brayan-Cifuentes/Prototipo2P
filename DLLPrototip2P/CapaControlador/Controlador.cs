using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;


namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sentencia = new Sentencias();

        public void funcionInsertarControlador(TextBox campos, string tabla)
        {
            throw new NotImplementedException();
        }


        public void asignarAliasControlador(TextBox[] campos)
        {
            sentencia.asignarAlias(campos);
        }

        public void funcionInsertarControlador(string tabla)
        {
            sentencia.funcInsertar(tabla);
        }

        public void funcModificarControlador(string id, string tabla)
        {
            sentencia.funModificar(id, tabla);
        }

        public void funcEliminar(string campoBaja, string campo, string tabla)
        {
            sentencia.funcEliminar(campoBaja, campo, tabla);
        }

        //Llenado de tabla
        public DataTable llenarTbl(string tablaDB, string estatus)
        {
            OdbcDataAdapter dt = sentencia.llenarTbl(tablaDB, estatus);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Seleccion de tabla
        public void funSeleccionarDTControl(DataGridView data)
        {
            sentencia.funSeleccionarDT(data);
        }

        /*Combobox*/
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            sentencia.funLlenarCombo(cbx, tabla, value, display, estatus);
        }

        //Presionar boton de combobox
        public void funComboTextboxControl(ComboBox combo, TextBox combotexto)
        {
            sentencia.funComboTextbox(combo, combotexto);

        }

        //textbox a combobox
        public void funTextboxComboControl(ComboBox combo, TextBox combotexto)
        {
            sentencia.funTextboxCombo(combo, combotexto);
        }
    }
}
