using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo2P
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            TextBox[] campos = { txtIdCurso, txtNombre, txtEstatus };
            barraNav1.asignarAliasvista(campos);

            /*Tabla a utilizarse para insercion*/
            barraNav1.tabla = "cursos";
            //Llenado de tabla
            barraNav1.estatus = "estatus_curso";
            barraNav1.DataGrid(this.dgvTabla);
            barraNav1.llenaTabla();

            /*Campo para modificar*/
            barraNav1.campoID = "codigo_curso";

            /*Dato en la Datagridview*/
            barraNav1.txtDatoBusqueda = txtBuscar;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            barraNav1.funSeleccionarDTVista(dgvTabla);
        }

        private void rbActivo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbActivo.Checked==true)
            {
                txtEstatus.Text = "A";
            }
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            if (txtEstatus.Text == "A")
            {
                rbActivo.Checked = true;
            }
            else if (txtEstatus.Text == "I")
            {
                rbInactivo.Checked = false;
            }
        }

        private void rbInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbInactivo.Checked == true)
            {
                txtEstatus.Text = "I";
            }
        }
    }
}
