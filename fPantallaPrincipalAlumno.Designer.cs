
namespace Grupo02PCSAS
{
    partial class fPantallaPrincipalAlumno
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lMiPerfil = new System.Windows.Forms.Label();
            this.lAlumno = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.lHola = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lNuevosCursos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNuevosCursos = new System.Windows.Forms.DataGridView();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.dgvNuevasActividades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lMiPerfil);
            this.panel1.Controls.Add(this.lAlumno);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.lHola);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, -9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 274);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lMiPerfil
            // 
            this.lMiPerfil.AutoSize = true;
            this.lMiPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiPerfil.Location = new System.Drawing.Point(1300, 212);
            this.lMiPerfil.Name = "lMiPerfil";
            this.lMiPerfil.Size = new System.Drawing.Size(101, 29);
            this.lMiPerfil.TabIndex = 6;
            this.lMiPerfil.Text = "Mi Perfil";
            this.lMiPerfil.Click += new System.EventHandler(this.lMiPerfil_Click);
            // 
            // lAlumno
            // 
            this.lAlumno.AutoSize = true;
            this.lAlumno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlumno.Location = new System.Drawing.Point(951, 201);
            this.lAlumno.Name = "lAlumno";
            this.lAlumno.Size = new System.Drawing.Size(93, 29);
            this.lAlumno.TabIndex = 5;
            this.lAlumno.Text = "Alumno";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(890, 201);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(55, 29);
            this.lRol.TabIndex = 4;
            this.lRol.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(735, 120);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(371, 55);
            this.lNombreApellidos.TabIndex = 3;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(600, 120);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(129, 55);
            this.lHola.TabIndex = 2;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(1261, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.pcsas;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lNuevosCursos
            // 
            this.lNuevosCursos.AutoSize = true;
            this.lNuevosCursos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNuevosCursos.Location = new System.Drawing.Point(590, 334);
            this.lNuevosCursos.Name = "lNuevosCursos";
            this.lNuevosCursos.Size = new System.Drawing.Size(163, 29);
            this.lNuevosCursos.TabIndex = 7;
            this.lNuevosCursos.Text = "Nuevos cursos";
            this.lNuevosCursos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevas actividades";
            // 
            // dgvNuevosCursos
            // 
            this.dgvNuevosCursos.AutoGenerateColumns = false;
            this.dgvNuevosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevosCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.profesorCursoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.descripcionCursoDataGridViewTextBoxColumn,
            this.fechaInicioCursoDataGridViewTextBoxColumn,
            this.fechaFinCursoDataGridViewTextBoxColumn,
            this.horaInicioCursoDataGridViewTextBoxColumn,
            this.horaFinCursoDataGridViewTextBoxColumn,
            this.lugarCursoDataGridViewTextBoxColumn,
            this.aforoCursoDataGridViewTextBoxColumn,
            this.onlineCursoDataGridViewTextBoxColumn});
            this.dgvNuevosCursos.DataSource = this.cursoBindingSource2;
            this.dgvNuevosCursos.Location = new System.Drawing.Point(521, 380);
            this.dgvNuevosCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevosCursos.Name = "dgvNuevosCursos";
            this.dgvNuevosCursos.RowHeadersWidth = 62;
            this.dgvNuevosCursos.RowTemplate.Height = 28;
            this.dgvNuevosCursos.Size = new System.Drawing.Size(832, 206);
            this.dgvNuevosCursos.TabIndex = 9;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // profesorCursoDataGridViewTextBoxColumn
            // 
            this.profesorCursoDataGridViewTextBoxColumn.DataPropertyName = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.HeaderText = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.profesorCursoDataGridViewTextBoxColumn.Name = "profesorCursoDataGridViewTextBoxColumn";
            this.profesorCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionCursoDataGridViewTextBoxColumn
            // 
            this.descripcionCursoDataGridViewTextBoxColumn.DataPropertyName = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.HeaderText = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionCursoDataGridViewTextBoxColumn.Name = "descripcionCursoDataGridViewTextBoxColumn";
            this.descripcionCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaInicioCursoDataGridViewTextBoxColumn
            // 
            this.fechaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn.HeaderText = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Name = "fechaInicioCursoDataGridViewTextBoxColumn";
            this.fechaInicioCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaFinCursoDataGridViewTextBoxColumn
            // 
            this.fechaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn.HeaderText = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaFinCursoDataGridViewTextBoxColumn.Name = "fechaFinCursoDataGridViewTextBoxColumn";
            this.fechaFinCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // horaInicioCursoDataGridViewTextBoxColumn
            // 
            this.horaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.HeaderText = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaInicioCursoDataGridViewTextBoxColumn.Name = "horaInicioCursoDataGridViewTextBoxColumn";
            this.horaInicioCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // horaFinCursoDataGridViewTextBoxColumn
            // 
            this.horaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.HeaderText = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaFinCursoDataGridViewTextBoxColumn.Name = "horaFinCursoDataGridViewTextBoxColumn";
            this.horaFinCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // lugarCursoDataGridViewTextBoxColumn
            // 
            this.lugarCursoDataGridViewTextBoxColumn.DataPropertyName = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn.HeaderText = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lugarCursoDataGridViewTextBoxColumn.Name = "lugarCursoDataGridViewTextBoxColumn";
            this.lugarCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // aforoCursoDataGridViewTextBoxColumn
            // 
            this.aforoCursoDataGridViewTextBoxColumn.DataPropertyName = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn.HeaderText = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aforoCursoDataGridViewTextBoxColumn.Name = "aforoCursoDataGridViewTextBoxColumn";
            this.aforoCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // onlineCursoDataGridViewTextBoxColumn
            // 
            this.onlineCursoDataGridViewTextBoxColumn.DataPropertyName = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.HeaderText = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.onlineCursoDataGridViewTextBoxColumn.Name = "onlineCursoDataGridViewTextBoxColumn";
            this.onlineCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cursoBindingSource2
            // 
            this.cursoBindingSource2.DataMember = "Curso";
            this.cursoBindingSource2.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // apsgrupo02DataSetBindingSource
            // 
            this.apsgrupo02DataSetBindingSource.DataSource = this.apsgrupo02DataSet;
            this.apsgrupo02DataSetBindingSource.Position = 0;
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvNuevasActividades
            // 
            this.dgvNuevasActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevasActividades.Location = new System.Drawing.Point(521, 685);
            this.dgvNuevasActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevasActividades.Name = "dgvNuevasActividades";
            this.dgvNuevasActividades.RowHeadersWidth = 62;
            this.dgvNuevasActividades.RowTemplate.Height = 28;
            this.dgvNuevasActividades.Size = new System.Drawing.Size(832, 206);
            this.dgvNuevasActividades.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 912);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Acceder al foro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 644);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 65);
            this.button3.TabIndex = 13;
            this.button3.Text = "           Mis cursos        ▼";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Location = new System.Drawing.Point(12, 701);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.RowHeadersWidth = 62;
            this.dgvMisCursos.RowTemplate.Height = 28;
            this.dgvMisCursos.Size = new System.Drawing.Size(312, 206);
            this.dgvMisCursos.TabIndex = 15;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(54, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // fPantallaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgvMisCursos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNuevasActividades);
            this.Controls.Add(this.dgvNuevosCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNuevosCursos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fPantallaPrincipalAlumno";
            this.Text = "fPantallaPrincipalAlumno";
            this.Load += new System.EventHandler(this.fPantallaPrincipalAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lHola;
        private System.Windows.Forms.Label lMiPerfil;
        private System.Windows.Forms.Label lAlumno;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label lNuevosCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNuevosCursos;
        private System.Windows.Forms.DataGridView dgvNuevasActividades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvMisCursos;
        private System.Windows.Forms.BindingSource apsgrupo02DataSetBindingSource;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private apsgrupo02DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aforoCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cursoBindingSource2;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}