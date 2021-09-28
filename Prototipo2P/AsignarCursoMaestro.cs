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
    public partial class AsignarCursoMaestro : Form
    {
        public AsignarCursoMaestro()
        {
            InitializeComponent();

            TextBox[] campos = { txtIdAsignacion,txtIdCarrera,txtIdSede, txtIdJornada, txtIdSeccion, txtIdAula, txtIdCurso, txtIdMaestro, txtEstatus };
            barraNav1.asignarAliasvista(campos);

            /*Tabla a utilizarse para insercion*/
            barraNav1.tabla = "asignacioncursosmastros";
            //Llenado de tabla
            barraNav1.estatus = "estatus_maestro";
            barraNav1.DataGrid(this.dgvTabla);
            barraNav1.llenaTabla();

            /*Campo para modificar*/
            barraNav1.campoID = "idasignacion";

            /*Dato en la Datagridview*/
            barraNav1.txtDatoBusqueda = txtBuscar;


            barraNav1.funLlenarComboControl(cbxIdCarrera,"carreras", "codigo_carrera", "nombre_carrera", "estatus_carrera");
            barraNav1.funLlenarComboControl(cbxIdSede, "sedes", "codigo_sede", "nombre_sede", "estatus_sede");
            barraNav1.funLlenarComboControl(cbxIdJornada, "jornadas", "codigo_jornada", "nombre_jornada", "estatus_jornada");
            barraNav1.funLlenarComboControl(cbxIdSeccion, "secciones", "codigo_seccion", "nombre_seccion", "estatus_seccion");
            barraNav1.funLlenarComboControl(cbxAula, "aulas", "codigo_aula", "nombre_aula", "estatus_aula");
            barraNav1.funLlenarComboControl(cbxIdCurso, "cursos", "codigo_curso", "nombre_curso", "estatus_curso");
            barraNav1.funLlenarComboControl(cbxIdMaestro, "maestros", "codigo_maestro", "nombre_maestro", "estatus_maestro");
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
            if(txtEstatus.Text == "A")
            {
                rbActivo.Checked = true;
            }
            else if(txtEstatus.Text == "I"){
                rbInactivo.Checked = true;
            }
        }

        private void AsignarCursoMaestro_Load(object sender, EventArgs e)
        {

        }

        private void cbxIdCarrera_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxIdCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdCarrera, txtIdCarrera);
        }

        private void cbxIdSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdSede, txtIdSede);
        }

        private void cbxIdJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdJornada, txtIdJornada);
        }

        private void cbxIdSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdSeccion, txtIdSeccion);
        }

        private void cbxAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxAula, txtIdAula);
        }

        private void cbxIdCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdCurso, txtIdCurso);
        }

        private void cbxIdMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            barraNav1.funComboTextboxVista(cbxIdMaestro, txtIdMaestro);
        }

        private void txtIdCarrera_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdCarrera, txtIdCarrera);
        }

        private void txtIdSede_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdSede, txtIdSede);
        }

        private void txtIdJornada_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdJornada, txtIdJornada);
        }

        private void txtIdSeccion_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdSeccion, txtIdSeccion);
        }

        private void txtIdAula_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxAula, txtIdAula);
        }

        private void txtIdCurso_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdCurso, txtIdCurso);
        }

        private void txtIdMaestro_TextChanged(object sender, EventArgs e)
        {
            barraNav1.funTextboxComboVista(cbxIdMaestro, txtIdMaestro);
        }

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            barraNav1.funSeleccionarDTVista(dgvTabla);
            //txtIdAsignacion.Text = "0";
        }
    }
}
