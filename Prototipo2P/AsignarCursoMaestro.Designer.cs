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
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(39, 380);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 18;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(39, 357);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 17;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(382, 96);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 47;
            this.dgvTabla.Size = new System.Drawing.Size(595, 179);
            this.dgvTabla.TabIndex = 16;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(137, 366);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(39, 20);
            this.txtEstatus.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(278, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(26, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Código Sede:";
            // 
            // txtIdCarrera
            // 
            this.txtIdCarrera.Location = new System.Drawing.Point(278, 96);
            this.txtIdCarrera.Name = "txtIdCarrera";
            this.txtIdCarrera.Size = new System.Drawing.Size(26, 20);
            this.txtIdCarrera.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código Carrera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asignar Cursos a Maestro";
            // 
            // cbxIdCarrera
            // 
            this.cbxIdCarrera.FormattingEnabled = true;
            this.cbxIdCarrera.Location = new System.Drawing.Point(137, 96);
            this.cbxIdCarrera.Name = "cbxIdCarrera";
            this.cbxIdCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbxIdCarrera.TabIndex = 19;
            // 
            // cbxIdSede
            // 
            this.cbxIdSede.FormattingEnabled = true;
            this.cbxIdSede.Location = new System.Drawing.Point(137, 131);
            this.cbxIdSede.Name = "cbxIdSede";
            this.cbxIdSede.Size = new System.Drawing.Size(121, 21);
            this.cbxIdSede.TabIndex = 20;
            // 
            // cbxIdJornada
            // 
            this.cbxIdJornada.FormattingEnabled = true;
            this.cbxIdJornada.Location = new System.Drawing.Point(137, 168);
            this.cbxIdJornada.Name = "cbxIdJornada";
            this.cbxIdJornada.Size = new System.Drawing.Size(121, 21);
            this.cbxIdJornada.TabIndex = 23;
            // 
            // txtIdJornada
            // 
            this.txtIdJornada.Location = new System.Drawing.Point(278, 168);
            this.txtIdJornada.Name = "txtIdJornada";
            this.txtIdJornada.Size = new System.Drawing.Size(26, 20);
            this.txtIdJornada.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Código Jornada:";
            // 
            // cbxIdSeccion
            // 
            this.cbxIdSeccion.FormattingEnabled = true;
            this.cbxIdSeccion.Location = new System.Drawing.Point(137, 207);
            this.cbxIdSeccion.Name = "cbxIdSeccion";
            this.cbxIdSeccion.Size = new System.Drawing.Size(121, 21);
            this.cbxIdSeccion.TabIndex = 26;
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(278, 207);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.Size = new System.Drawing.Size(26, 20);
            this.txtIdSeccion.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Código Sección:";
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(137, 246);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(121, 21);
            this.cbxAula.TabIndex = 29;
            // 
            // txtIdAula
            // 
            this.txtIdAula.Location = new System.Drawing.Point(278, 246);
            this.txtIdAula.Name = "txtIdAula";
            this.txtIdAula.Size = new System.Drawing.Size(26, 20);
            this.txtIdAula.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Código Aula:";
            // 
            // cbxIdCurso
            // 
            this.cbxIdCurso.FormattingEnabled = true;
            this.cbxIdCurso.Location = new System.Drawing.Point(137, 284);
            this.cbxIdCurso.Name = "cbxIdCurso";
            this.cbxIdCurso.Size = new System.Drawing.Size(121, 21);
            this.cbxIdCurso.TabIndex = 32;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(278, 284);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(26, 20);
            this.txtIdCurso.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Código Curso:";
            // 
            // cbxIdMaestro
            // 
            this.cbxIdMaestro.FormattingEnabled = true;
            this.cbxIdMaestro.Location = new System.Drawing.Point(137, 324);
            this.cbxIdMaestro.Name = "cbxIdMaestro";
            this.cbxIdMaestro.Size = new System.Drawing.Size(121, 21);
            this.cbxIdMaestro.TabIndex = 35;
            // 
            // txtIdMaestro
            // 
            this.txtIdMaestro.Location = new System.Drawing.Point(278, 324);
            this.txtIdMaestro.Name = "txtIdMaestro";
            this.txtIdMaestro.Size = new System.Drawing.Size(26, 20);
            this.txtIdMaestro.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código Maestro:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(186, 536);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(104, 20);
            this.txtBuscar.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Digite ID a consultar: ";
            // 
            // AsignarCursoMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 586);
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
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarCursoMaestro";
            this.Text = "AsignarCursoMaestro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtNombre;
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
    }
}