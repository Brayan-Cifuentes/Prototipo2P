namespace Prototipo2P
{
    partial class AsignarCursoMaestro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtIdSede = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCarrera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIdCarrera = new System.Windows.Forms.ComboBox();
            this.cbxIdSede = new System.Windows.Forms.ComboBox();
            this.cbxIdJornada = new System.Windows.Forms.ComboBox();
            this.txtIdJornada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxIdSeccion = new System.Windows.Forms.ComboBox();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.txtIdAula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxIdCurso = new System.Windows.Forms.ComboBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxIdMaestro = new System.Windows.Forms.ComboBox();
            this.txtIdMaestro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.barraNav1 = new CapaVista.BarraNav();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdAsignacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(136, 488);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 18;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbInactivo_MouseClick);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(383, 173);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 47;
            this.dgvTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabla.Size = new System.Drawing.Size(595, 179);
            this.dgvTabla.TabIndex = 16;
            this.dgvTabla.SelectionChanged += new System.EventHandler(this.dgvTabla_SelectionChanged);
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(234, 474);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(39, 20);
            this.txtEstatus.TabIndex = 15;
            this.txtEstatus.Tag = "estatus_maestro";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtIdSede
            // 
            this.txtIdSede.Location = new System.Drawing.Point(276, 239);
            this.txtIdSede.Name = "txtIdSede";
            this.txtIdSede.Size = new System.Drawing.Size(26, 20);
            this.txtIdSede.TabIndex = 14;
            this.txtIdSede.Tag = "codigo_sede";
            this.txtIdSede.Visible = false;
            this.txtIdSede.TextChanged += new System.EventHandler(this.txtIdSede_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sede:";
            // 
            // txtIdCarrera
            // 
            this.txtIdCarrera.Location = new System.Drawing.Point(276, 204);
            this.txtIdCarrera.Name = "txtIdCarrera";
            this.txtIdCarrera.Size = new System.Drawing.Size(26, 20);
            this.txtIdCarrera.TabIndex = 12;
            this.txtIdCarrera.Tag = "codigo_carrera";
            this.txtIdCarrera.Visible = false;
            this.txtIdCarrera.TextChanged += new System.EventHandler(this.txtIdCarrera_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carrera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asignar Cursos a Maestro";
            // 
            // cbxIdCarrera
            // 
            this.cbxIdCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdCarrera.FormattingEnabled = true;
            this.cbxIdCarrera.Location = new System.Drawing.Point(135, 204);
            this.cbxIdCarrera.Name = "cbxIdCarrera";
            this.cbxIdCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbxIdCarrera.TabIndex = 19;
            this.cbxIdCarrera.SelectedIndexChanged += new System.EventHandler(this.cbxIdCarrera_SelectedIndexChanged);
            this.cbxIdCarrera.SelectedValueChanged += new System.EventHandler(this.cbxIdCarrera_SelectedValueChanged);
            // 
            // cbxIdSede
            // 
            this.cbxIdSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdSede.FormattingEnabled = true;
            this.cbxIdSede.Location = new System.Drawing.Point(135, 239);
            this.cbxIdSede.Name = "cbxIdSede";
            this.cbxIdSede.Size = new System.Drawing.Size(121, 21);
            this.cbxIdSede.TabIndex = 20;
            this.cbxIdSede.SelectedIndexChanged += new System.EventHandler(this.cbxIdSede_SelectedIndexChanged);
            // 
            // cbxIdJornada
            // 
            this.cbxIdJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdJornada.FormattingEnabled = true;
            this.cbxIdJornada.Location = new System.Drawing.Point(135, 276);
            this.cbxIdJornada.Name = "cbxIdJornada";
            this.cbxIdJornada.Size = new System.Drawing.Size(121, 21);
            this.cbxIdJornada.TabIndex = 23;
            this.cbxIdJornada.SelectedIndexChanged += new System.EventHandler(this.cbxIdJornada_SelectedIndexChanged);
            // 
            // txtIdJornada
            // 
            this.txtIdJornada.Location = new System.Drawing.Point(276, 276);
            this.txtIdJornada.Name = "txtIdJornada";
            this.txtIdJornada.Size = new System.Drawing.Size(26, 20);
            this.txtIdJornada.TabIndex = 22;
            this.txtIdJornada.Tag = "codigo_jornada";
            this.txtIdJornada.Visible = false;
            this.txtIdJornada.TextChanged += new System.EventHandler(this.txtIdJornada_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jornada:";
            // 
            // cbxIdSeccion
            // 
            this.cbxIdSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdSeccion.FormattingEnabled = true;
            this.cbxIdSeccion.Location = new System.Drawing.Point(135, 315);
            this.cbxIdSeccion.Name = "cbxIdSeccion";
            this.cbxIdSeccion.Size = new System.Drawing.Size(121, 21);
            this.cbxIdSeccion.TabIndex = 26;
            this.cbxIdSeccion.SelectedIndexChanged += new System.EventHandler(this.cbxIdSeccion_SelectedIndexChanged);
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(276, 315);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(26, 20);
            this.txtIdSeccion.TabIndex = 25;
            this.txtIdSeccion.Tag = "codigo_seccion";
            this.txtIdSeccion.Visible = false;
            this.txtIdSeccion.TextChanged += new System.EventHandler(this.txtIdSeccion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sección:";
            // 
            // cbxAula
            // 
            this.cbxAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(135, 354);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(121, 21);
            this.cbxAula.TabIndex = 29;
            this.cbxAula.SelectedIndexChanged += new System.EventHandler(this.cbxAula_SelectedIndexChanged);
            // 
            // txtIdAula
            // 
            this.txtIdAula.Location = new System.Drawing.Point(276, 354);
            this.txtIdAula.Name = "txtIdAula";
            this.txtIdAula.Size = new System.Drawing.Size(26, 20);
            this.txtIdAula.TabIndex = 28;
            this.txtIdAula.Tag = "codigo_aula";
            this.txtIdAula.Visible = false;
            this.txtIdAula.TextChanged += new System.EventHandler(this.txtIdAula_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aula:";
            // 
            // cbxIdCurso
            // 
            this.cbxIdCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdCurso.FormattingEnabled = true;
            this.cbxIdCurso.Location = new System.Drawing.Point(135, 392);
            this.cbxIdCurso.Name = "cbxIdCurso";
            this.cbxIdCurso.Size = new System.Drawing.Size(121, 21);
            this.cbxIdCurso.TabIndex = 32;
            this.cbxIdCurso.SelectedIndexChanged += new System.EventHandler(this.cbxIdCurso_SelectedIndexChanged);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(276, 392);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(26, 20);
            this.txtIdCurso.TabIndex = 31;
            this.txtIdCurso.Tag = "codigo_curso";
            this.txtIdCurso.Visible = false;
            this.txtIdCurso.TextChanged += new System.EventHandler(this.txtIdCurso_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Curso:";
            // 
            // cbxIdMaestro
            // 
            this.cbxIdMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdMaestro.FormattingEnabled = true;
            this.cbxIdMaestro.Location = new System.Drawing.Point(135, 432);
            this.cbxIdMaestro.Name = "cbxIdMaestro";
            this.cbxIdMaestro.Size = new System.Drawing.Size(121, 21);
            this.cbxIdMaestro.TabIndex = 35;
            this.cbxIdMaestro.SelectedIndexChanged += new System.EventHandler(this.cbxIdMaestro_SelectedIndexChanged);
            // 
            // txtIdMaestro
            // 
            this.txtIdMaestro.Location = new System.Drawing.Point(276, 432);
            this.txtIdMaestro.Name = "txtIdMaestro";
            this.txtIdMaestro.Size = new System.Drawing.Size(26, 20);
            this.txtIdMaestro.TabIndex = 34;
            this.txtIdMaestro.Tag = "codigo_maestro";
            this.txtIdMaestro.Visible = false;
            this.txtIdMaestro.TextChanged += new System.EventHandler(this.txtIdMaestro_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Maestro:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(524, 362);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(104, 20);
            this.txtBuscar.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Digite ID a consultar: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Estatus:";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(136, 465);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 17;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbActivo_MouseClick);
            // 
            // barraNav1
            // 
            this.barraNav1.Location = new System.Drawing.Point(32, 70);
            this.barraNav1.Name = "barraNav1";
            this.barraNav1.Size = new System.Drawing.Size(365, 80);
            this.barraNav1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "ID Asignacion:";
            // 
            // txtIdAsignacion
            // 
            this.txtIdAsignacion.Location = new System.Drawing.Point(135, 173);
            this.txtIdAsignacion.Name = "txtIdAsignacion";
            this.txtIdAsignacion.Size = new System.Drawing.Size(56, 20);
            this.txtIdAsignacion.TabIndex = 41;
            this.txtIdAsignacion.Tag = "idasignacion";
            // 
            // AsignarCursoMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 517);
            this.Controls.Add(this.txtIdAsignacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.barraNav1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxIdMaestro);
            this.Controls.Add(this.txtIdMaestro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxIdCurso);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.txtIdAula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxIdSeccion);
            this.Controls.Add(this.txtIdSeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxIdJornada);
            this.Controls.Add(this.txtIdJornada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxIdSede);
            this.Controls.Add(this.cbxIdCarrera);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtIdSede);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarCursoMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarCursoMaestro";
            this.Load += new System.EventHandler(this.AsignarCursoMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtIdSede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxIdCarrera;
        private System.Windows.Forms.ComboBox cbxIdSede;
        private System.Windows.Forms.ComboBox cbxIdJornada;
        private System.Windows.Forms.TextBox txtIdJornada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxIdSeccion;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.TextBox txtIdAula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxIdCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxIdMaestro;
        private System.Windows.Forms.TextBox txtIdMaestro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label9;
        private CapaVista.BarraNav barraNav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdAsignacion;
    }
}