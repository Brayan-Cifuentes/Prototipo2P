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
    public partial class Maestros : Form
    {
        public Maestros()
        {
            InitializeComponent();
            TextBox[] campos = { txtIdMaestro, txtNombre, txtDireccion, txtTelefono, txtEmail, txtEstatus };
            barraNav1.asignarAliasvista(campos);

            /*Nombre tabla BD*/
            barraNav1.tabla = "maestros";

            /*Modificar*/
            barraNav1.estatus = "estatus_maestro";
            barraNav1.campoID = "codigo_maestro";

            /*Cargar Tabla*/
            barraNav1.DataGrid(this.dgvMaestros);
            barraNav1.llenaTabla();

            barraNav1.txtDatoBusqueda = txtBuscar;

        }

        private void rbActivo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbActivo.Checked == true)
            {
                txtEstatus.Text = "A";
            }
        }

        private void rbInactivo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbInactivo.Checked == true)
            {
                txtEstatus.Text = "I";
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

        private void Maestros_Load(object sender, EventArgs e)
        {

        }

        private void dgvMaestros_SelectionChanged(object sender, EventArgs e)
        {
            barraNav1.funSeleccionarDTVista(dgvMaestros);
        }

        private void txtEstatus_TextChanged_1(object sender, EventArgs e)
        {
            if(txtEstatus.Text == "A")
            {
                rbActivo.Checked = true;
            }else if (txtEstatus.Text == "I")
            {
                rbInactivo.Checked = true;
            }
        }
    }
}
