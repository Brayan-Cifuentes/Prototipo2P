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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void brayanCifuentes99591811113ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.MdiParent = this;
            cursos.Show();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maestros maestros = new Maestros();
            maestros.MdiParent = this;
            maestros.Show();
        }

        private void asignarCursosMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarCursoMaestro asignacion = new AsignarCursoMaestro();
            asignacion.MdiParent = this;
            asignacion.Show();
        }
    }
}
