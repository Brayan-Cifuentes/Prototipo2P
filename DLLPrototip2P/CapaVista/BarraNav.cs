using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class BarraNav : UserControl
    {
        Controlador control = new Controlador();
        DataGridView dvgConsulta;
        public TextBox txtDatoBusqueda;
        public ComboBox combo;

        public string tabla;
        public string estatus;
        public string campoID;

        public BarraNav()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void asignarAliasvista(TextBox[] campos)
        {
            control.asignarAliasControlador(campos);
        }

        public void funcInsertarVista(string tabla)
        {
            control.funcionInsertarControlador(tabla);
        }

        public void funModificarVista(string tabla)
        {
            control.funcModificarControlador(campoID, tabla);
        }

        public void funcEliminar(string tabla)
        {
            control.funcEliminar(estatus, campoID, tabla);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            funcInsertarVista(tabla);
            llenaTabla();
        }

        
        //Pedir tabla
        public void DataGrid(DataGridView tabla)
        {
            dvgConsulta = tabla;
        }

        //Llenado de la tabla
        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl(tabla, estatus);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;
        }


        public void funSeleccionarDTVista(DataGridView data)
        {
            dvgConsulta = data;
            control.funSeleccionarDTControl(data);
        }


        public void funBuscar(DataGridView data, string campo ,TextBox id)
        {
            if (data.RowCount > 0)
            {
                bool existe = false;
                
                for (int i=0; i < data.RowCount; i++)
                {
                    if (Convert.ToInt16(data.Rows[i].Cells[""+campo+""].Value)==Convert.ToInt16(id.Text))
                    {
                        //selecciona la fila
                        data.Rows[i].Selected = true;
                        MessageBox.Show("Código Existente");
                        existe = true;
                        break;
                    }
                }

                if (existe!=true)
                {
                    MessageBox.Show("Código no Existe");
                }
            }
        }


        /*Combobox*/
        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string status)
        {
            control.funLlenarComboControl(cbx, tabla, value, display, status);
        }

        /*combo a texto*/
        public void funComboTextboxVista(ComboBox combo, TextBox combotexto)
        {
            control.funComboTextboxControl(combo, combotexto);
        }

        /*Text a combobox*/
        public void funTextboxComboVista(ComboBox combo, TextBox combotexto)
        {
            control.funTextboxComboControl(combo, combotexto);
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            funModificarVista(tabla);
            llenaTabla();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            funcEliminar(tabla);
            llenaTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            llenaTabla();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            //se le pasa el parametro del campo de nombre id en la BD
            funBuscar(dvgConsulta, campoID, txtDatoBusqueda);
            dvgConsulta.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
