
using System;
using System.Windows.Forms;

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
            this.lNuevosCursos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNuevosCursos = new System.Windows.Forms.DataGridView();
            this.cursoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.cursoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvNuevasActividades = new System.Windows.Forms.DataGridView();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.idCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforoCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineCursoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bInfoCurso = new System.Windows.Forms.Button();
            this.bInsCurso = new System.Windows.Forms.Button();
            this.bInsAct = new System.Windows.Forms.Button();
            this.bInfoAct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Noticias = new System.Windows.Forms.Button();
            this.bInscribirActividad = new System.Windows.Forms.Button();
            this.bInscribirCurso = new System.Windows.Forms.Button();
            this.bInformacionActividad = new System.Windows.Forms.Button();
            this.bInformacionCurso = new System.Windows.Forms.Button();
            this.lNoCursos = new System.Windows.Forms.Label();
            this.lNoActividades = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lCursos = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.bMisAct = new System.Windows.Forms.Button();
            this.dgvMisAct = new System.Windows.Forms.DataGridView();
            this.idActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforoActividadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet1 = new Grupo02PCSAS.apsgrupo02DataSet1();
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.actividadTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.ActividadTableAdapter();
            this.cursosRealizadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosRealizadosTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursosRealizadosTableAdapter();
            this.actividadesRealizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadesRealizadasTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.ActividadesRealizadasTableAdapter();
            this.actividadTableAdapter1 = new Grupo02PCSAS.apsgrupo02DataSet1TableAdapters.ActividadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosRealizadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesRealizadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lNuevosCursos
            // 
            this.lNuevosCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNuevosCursos.AutoSize = true;
            this.lNuevosCursos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNuevosCursos.Location = new System.Drawing.Point(464, 225);
            this.lNuevosCursos.Name = "lNuevosCursos";
            this.lNuevosCursos.Size = new System.Drawing.Size(163, 29);
            this.lNuevosCursos.TabIndex = 7;
            this.lNuevosCursos.Text = "Nuevos cursos";
            this.lNuevosCursos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevas actividades";
            // 
            // dgvNuevosCursos
            // 
            this.dgvNuevosCursos.AllowUserToAddRows = false;
            this.dgvNuevosCursos.AllowUserToDeleteRows = false;
            this.dgvNuevosCursos.AllowUserToOrderColumns = true;
            this.dgvNuevosCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNuevosCursos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvNuevosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevosCursos.Location = new System.Drawing.Point(395, 271);
            this.dgvNuevosCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevosCursos.MultiSelect = false;
            this.dgvNuevosCursos.Name = "dgvNuevosCursos";
            this.dgvNuevosCursos.ReadOnly = true;
            this.dgvNuevosCursos.RowHeadersWidth = 62;
            this.dgvNuevosCursos.RowTemplate.Height = 28;
            this.dgvNuevosCursos.Size = new System.Drawing.Size(832, 206);
            this.dgvNuevosCursos.TabIndex = 9;
            this.dgvNuevosCursos.SelectionChanged += new System.EventHandler(this.dgvNuevosCursos_SelectionChanged);
            // 
            // cursoBindingSource3
            // 
            this.cursoBindingSource3.DataMember = "Curso";
            this.cursoBindingSource3.DataSource = this.apsgrupo02DataSet;
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dgvNuevasActividades
            // 
            this.dgvNuevasActividades.AllowUserToAddRows = false;
            this.dgvNuevasActividades.AllowUserToDeleteRows = false;
            this.dgvNuevasActividades.AllowUserToOrderColumns = true;
            this.dgvNuevasActividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNuevasActividades.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvNuevasActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevasActividades.Location = new System.Drawing.Point(395, 576);
            this.dgvNuevasActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNuevasActividades.MultiSelect = false;
            this.dgvNuevasActividades.Name = "dgvNuevasActividades";
            this.dgvNuevasActividades.ReadOnly = true;
            this.dgvNuevasActividades.RowHeadersWidth = 62;
            this.dgvNuevasActividades.RowTemplate.Height = 28;
            this.dgvNuevasActividades.Size = new System.Drawing.Size(832, 206);
            this.dgvNuevasActividades.TabIndex = 10;
            this.dgvNuevasActividades.SelectionChanged += new System.EventHandler(this.dgvNuevasActividades_SelectionChanged);
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 786);
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
            this.button3.Location = new System.Drawing.Point(12, 238);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 65);
            this.button3.TabIndex = 13;
            this.button3.Text = "Mis cursos ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.AllowUserToAddRows = false;
            this.dgvMisCursos.AllowUserToDeleteRows = false;
            this.dgvMisCursos.AllowUserToOrderColumns = true;
            this.dgvMisCursos.AutoGenerateColumns = false;
            this.dgvMisCursos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn1,
            this.profesorCursoDataGridViewTextBoxColumn1,
            this.nombreCursoDataGridViewTextBoxColumn1,
            this.descripcionCursoDataGridViewTextBoxColumn1,
            this.fechaInicioCursoDataGridViewTextBoxColumn1,
            this.fechaFinCursoDataGridViewTextBoxColumn1,
            this.horaInicioCursoDataGridViewTextBoxColumn1,
            this.horaFinCursoDataGridViewTextBoxColumn1,
            this.lugarCursoDataGridViewTextBoxColumn1,
            this.aforoCursoDataGridViewTextBoxColumn1,
            this.onlineCursoDataGridViewTextBoxColumn1});
            this.dgvMisCursos.DataSource = this.cursoBindingSource4;
            this.dgvMisCursos.Location = new System.Drawing.Point(12, 301);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.MultiSelect = false;
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.ReadOnly = true;
            this.dgvMisCursos.RowHeadersWidth = 62;
            this.dgvMisCursos.RowTemplate.Height = 28;
            this.dgvMisCursos.Size = new System.Drawing.Size(312, 206);
            this.dgvMisCursos.TabIndex = 15;
            this.dgvMisCursos.SelectionChanged += new System.EventHandler(this.dgvMisCursos_SelectionChanged);
            // 
            // idCursoDataGridViewTextBoxColumn1
            // 
            this.idCursoDataGridViewTextBoxColumn1.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn1.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idCursoDataGridViewTextBoxColumn1.Name = "idCursoDataGridViewTextBoxColumn1";
            this.idCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idCursoDataGridViewTextBoxColumn1.Visible = false;
            this.idCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // profesorCursoDataGridViewTextBoxColumn1
            // 
            this.profesorCursoDataGridViewTextBoxColumn1.DataPropertyName = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn1.HeaderText = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.profesorCursoDataGridViewTextBoxColumn1.Name = "profesorCursoDataGridViewTextBoxColumn1";
            this.profesorCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.profesorCursoDataGridViewTextBoxColumn1.Visible = false;
            this.profesorCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombreCursoDataGridViewTextBoxColumn1
            // 
            this.nombreCursoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCursoDataGridViewTextBoxColumn1.DataPropertyName = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreCursoDataGridViewTextBoxColumn1.Name = "nombreCursoDataGridViewTextBoxColumn1";
            this.nombreCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionCursoDataGridViewTextBoxColumn1
            // 
            this.descripcionCursoDataGridViewTextBoxColumn1.DataPropertyName = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn1.HeaderText = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descripcionCursoDataGridViewTextBoxColumn1.Name = "descripcionCursoDataGridViewTextBoxColumn1";
            this.descripcionCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionCursoDataGridViewTextBoxColumn1.Visible = false;
            this.descripcionCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fechaInicioCursoDataGridViewTextBoxColumn1
            // 
            this.fechaInicioCursoDataGridViewTextBoxColumn1.DataPropertyName = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn1.HeaderText = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaInicioCursoDataGridViewTextBoxColumn1.Name = "fechaInicioCursoDataGridViewTextBoxColumn1";
            this.fechaInicioCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaInicioCursoDataGridViewTextBoxColumn1.Visible = false;
            this.fechaInicioCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fechaFinCursoDataGridViewTextBoxColumn1
            // 
            this.fechaFinCursoDataGridViewTextBoxColumn1.DataPropertyName = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn1.HeaderText = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaFinCursoDataGridViewTextBoxColumn1.Name = "fechaFinCursoDataGridViewTextBoxColumn1";
            this.fechaFinCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaFinCursoDataGridViewTextBoxColumn1.Visible = false;
            this.fechaFinCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // horaInicioCursoDataGridViewTextBoxColumn1
            // 
            this.horaInicioCursoDataGridViewTextBoxColumn1.DataPropertyName = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn1.HeaderText = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.horaInicioCursoDataGridViewTextBoxColumn1.Name = "horaInicioCursoDataGridViewTextBoxColumn1";
            this.horaInicioCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horaInicioCursoDataGridViewTextBoxColumn1.Visible = false;
            this.horaInicioCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // horaFinCursoDataGridViewTextBoxColumn1
            // 
            this.horaFinCursoDataGridViewTextBoxColumn1.DataPropertyName = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn1.HeaderText = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.horaFinCursoDataGridViewTextBoxColumn1.Name = "horaFinCursoDataGridViewTextBoxColumn1";
            this.horaFinCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horaFinCursoDataGridViewTextBoxColumn1.Visible = false;
            this.horaFinCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lugarCursoDataGridViewTextBoxColumn1
            // 
            this.lugarCursoDataGridViewTextBoxColumn1.DataPropertyName = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn1.HeaderText = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lugarCursoDataGridViewTextBoxColumn1.Name = "lugarCursoDataGridViewTextBoxColumn1";
            this.lugarCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lugarCursoDataGridViewTextBoxColumn1.Visible = false;
            this.lugarCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aforoCursoDataGridViewTextBoxColumn1
            // 
            this.aforoCursoDataGridViewTextBoxColumn1.DataPropertyName = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn1.HeaderText = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aforoCursoDataGridViewTextBoxColumn1.Name = "aforoCursoDataGridViewTextBoxColumn1";
            this.aforoCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aforoCursoDataGridViewTextBoxColumn1.Visible = false;
            this.aforoCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // onlineCursoDataGridViewTextBoxColumn1
            // 
            this.onlineCursoDataGridViewTextBoxColumn1.DataPropertyName = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn1.HeaderText = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.onlineCursoDataGridViewTextBoxColumn1.Name = "onlineCursoDataGridViewTextBoxColumn1";
            this.onlineCursoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.onlineCursoDataGridViewTextBoxColumn1.Visible = false;
            this.onlineCursoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cursoBindingSource4
            // 
            this.cursoBindingSource4.DataMember = "Curso";
            this.cursoBindingSource4.DataSource = this.apsgrupo02DataSet;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // bInfoCurso
            // 
            this.bInfoCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfoCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoCurso.Location = new System.Drawing.Point(1262, 301);
            this.bInfoCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInfoCurso.Name = "bInfoCurso";
            this.bInfoCurso.Size = new System.Drawing.Size(177, 65);
            this.bInfoCurso.TabIndex = 17;
            this.bInfoCurso.Text = "Info";
            this.bInfoCurso.UseVisualStyleBackColor = false;
            this.bInfoCurso.Click += new System.EventHandler(this.bInfoCurso_Click);
            // 
            // bInsCurso
            // 
            this.bInsCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInsCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInsCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsCurso.Location = new System.Drawing.Point(1262, 390);
            this.bInsCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInsCurso.Name = "bInsCurso";
            this.bInsCurso.Size = new System.Drawing.Size(177, 65);
            this.bInsCurso.TabIndex = 18;
            this.bInsCurso.Text = "Inscribirse";
            this.bInsCurso.UseVisualStyleBackColor = false;
            this.bInsCurso.Click += new System.EventHandler(this.bInsCurso_Click);
            // 
            // bInsAct
            // 
            this.bInsAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInsAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInsAct.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsAct.Location = new System.Drawing.Point(1262, 694);
            this.bInsAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInsAct.Name = "bInsAct";
            this.bInsAct.Size = new System.Drawing.Size(177, 65);
            this.bInsAct.TabIndex = 20;
            this.bInsAct.Text = "Inscribirse";
            this.bInsAct.UseVisualStyleBackColor = false;
            this.bInsAct.Click += new System.EventHandler(this.bInsAct_Click);
            // 
            // bInfoAct
            // 
            this.bInfoAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfoAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoAct.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoAct.Location = new System.Drawing.Point(1262, 605);
            this.bInfoAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInfoAct.Name = "bInfoAct";
            this.bInfoAct.Size = new System.Drawing.Size(177, 65);
            this.bInfoAct.TabIndex = 19;
            this.bInfoAct.Text = "Info";
            this.bInfoAct.UseVisualStyleBackColor = false;
            this.bInfoAct.Click += new System.EventHandler(this.bInfoAct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lNombreUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 221);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1318, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1299, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // lRol
            // 
            this.lRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(759, 145);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(73, 29);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(693, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(821, 48);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(408, 52);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hola,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;

            // 
            // Noticias
            // 
            this.Noticias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Noticias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Noticias.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noticias.Location = new System.Drawing.Point(395, 801);
            this.Noticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Noticias.Name = "Noticias";
            this.Noticias.Size = new System.Drawing.Size(834, 65);
            this.Noticias.TabIndex = 22;
            this.Noticias.Text = "Noticias";
            this.Noticias.UseVisualStyleBackColor = false;
            this.Noticias.Click += new System.EventHandler(this.Noticias_Click);
            // 
            // bInscribirActividad
            // 
            this.bInscribirActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInscribirActividad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInscribirActividad.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInscribirActividad.Location = new System.Drawing.Point(1070, 1155);
            this.bInscribirActividad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bInscribirActividad.Name = "bInscribirActividad";
            this.bInscribirActividad.Size = new System.Drawing.Size(145, 70);
            this.bInscribirActividad.TabIndex = 79;
            this.bInscribirActividad.Text = "Inscribir";
            this.bInscribirActividad.UseVisualStyleBackColor = false;
            this.bInscribirActividad.Click += new System.EventHandler(this.bInscribirActividad_Click);
            // 
            // bInscribirCurso
            // 
            this.bInscribirCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInscribirCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInscribirCurso.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInscribirCurso.Location = new System.Drawing.Point(1070, 975);
            this.bInscribirCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bInscribirCurso.Name = "bInscribirCurso";
            this.bInscribirCurso.Size = new System.Drawing.Size(145, 70);
            this.bInscribirCurso.TabIndex = 78;
            this.bInscribirCurso.Text = "Inscribir";
            this.bInscribirCurso.UseVisualStyleBackColor = false;
            this.bInscribirCurso.Click += new System.EventHandler(this.bInscribirCurso_Click);
            // 
            // bInformacionActividad
            // 
            this.bInformacionActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInformacionActividad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInformacionActividad.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInformacionActividad.Location = new System.Drawing.Point(1070, 1078);
            this.bInformacionActividad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bInformacionActividad.Name = "bInformacionActividad";
            this.bInformacionActividad.Size = new System.Drawing.Size(145, 70);
            this.bInformacionActividad.TabIndex = 77;
            this.bInformacionActividad.Text = "Información";
            this.bInformacionActividad.UseVisualStyleBackColor = false;
            this.bInformacionActividad.Click += new System.EventHandler(this.bInformacionActividad_Click);
            // 
            // bInformacionCurso
            // 
            this.bInformacionCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInformacionCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInformacionCurso.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInformacionCurso.Location = new System.Drawing.Point(1070, 898);
            this.bInformacionCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bInformacionCurso.Name = "bInformacionCurso";
            this.bInformacionCurso.Size = new System.Drawing.Size(145, 70);
            this.bInformacionCurso.TabIndex = 76;
            this.bInformacionCurso.Text = "Información";
            this.bInformacionCurso.UseVisualStyleBackColor = false;
            this.bInformacionCurso.Click += new System.EventHandler(this.bInformacionCurso_Click);
            // 
            // lNoCursos
            // 
            this.lNoCursos.AutoSize = true;
            this.lNoCursos.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoCursos.Location = new System.Drawing.Point(431, 975);
            this.lNoCursos.Name = "lNoCursos";
            this.lNoCursos.Size = new System.Drawing.Size(0, 27);
            this.lNoCursos.TabIndex = 75;
            // 
            // lNoActividades
            // 
            this.lNoActividades.AutoSize = true;
            this.lNoActividades.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoActividades.Location = new System.Drawing.Point(431, 1126);
            this.lNoActividades.Name = "lNoActividades";
            this.lNoActividades.Size = new System.Drawing.Size(0, 27);
            this.lNoActividades.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 1069);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 36);
            this.label4.TabIndex = 73;
            this.label4.Text = "Actividades programadas para el día seleccionado";
            // 
            // lCursos
            // 
            this.lCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lCursos.AutoSize = true;
            this.lCursos.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCursos.Location = new System.Drawing.Point(389, 889);
            this.lCursos.Name = "lCursos";
            this.lCursos.Size = new System.Drawing.Size(577, 36);
            this.lCursos.TabIndex = 72;
            this.lCursos.Text = "Cursos programados para el día seleccionado";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToOrderColumns = true;
            this.dgvActividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActividades.AutoGenerateColumns = false;
            this.dgvActividades.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvActividades.DataSource = this.actividadBindingSource;
            this.dgvActividades.Location = new System.Drawing.Point(395, 1109);
            this.dgvActividades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvActividades.MultiSelect = false;
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersWidth = 51;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(636, 116);
            this.dgvActividades.TabIndex = 71;
            this.dgvActividades.SelectionChanged += new System.EventHandler(this.dgvActividades_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idActividad";
            this.dataGridViewTextBoxColumn1.HeaderText = "idActividad";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "creadorActividad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Creador";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombreActividad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcionActividad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fechaInicioActividad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha de inicio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechaFinActividad";
            this.dataGridViewTextBoxColumn6.HeaderText = "fechaFinActividad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "horaInicioActividad";
            this.dataGridViewTextBoxColumn7.HeaderText = "horaInicioActividad";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "horaFinActividad";
            this.dataGridViewTextBoxColumn8.HeaderText = "horaFinActividad";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "lugarActividad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Lugar";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "aforoActividad";
            this.dataGridViewTextBoxColumn10.HeaderText = "Aforo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToOrderColumns = true;
            this.dgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dgvCursos.DataSource = this.cursoBindingSource;
            this.dgvCursos.Location = new System.Drawing.Point(395, 929);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.Size = new System.Drawing.Size(636, 116);
            this.dgvCursos.TabIndex = 70;
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn11.HeaderText = "idCurso";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "profesorCurso";
            this.dataGridViewTextBoxColumn12.HeaderText = "Profesor";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "nombreCurso";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 101;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "descripcionCurso";
            this.dataGridViewTextBoxColumn14.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "fechaInicioCurso";
            this.dataGridViewTextBoxColumn15.HeaderText = "Fecha de inicio";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "fechaFinCurso";
            this.dataGridViewTextBoxColumn16.HeaderText = "fechaFinCurso";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "horaInicioCurso";
            this.dataGridViewTextBoxColumn17.HeaderText = "horaInicioCurso";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "horaFinCurso";
            this.dataGridViewTextBoxColumn18.HeaderText = "horaFinCurso";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "lugarCurso";
            this.dataGridViewTextBoxColumn19.HeaderText = "Lugar";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "aforoCurso";
            this.dataGridViewTextBoxColumn20.HeaderText = "Aforo";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "onlineCurso";
            this.dataGridViewTextBoxColumn21.HeaderText = "onlineCurso";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(98, 898);
            this.calendario.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 69;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // bMisAct
            // 
            this.bMisAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMisAct.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMisAct.Location = new System.Drawing.Point(12, 511);
            this.bMisAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bMisAct.Name = "bMisAct";
            this.bMisAct.Size = new System.Drawing.Size(312, 65);
            this.bMisAct.TabIndex = 80;
            this.bMisAct.Text = "Mis actividades";
            this.bMisAct.UseVisualStyleBackColor = false;
            // 
            // dgvMisAct
            // 
            this.dgvMisAct.AllowUserToAddRows = false;
            this.dgvMisAct.AllowUserToDeleteRows = false;
            this.dgvMisAct.AllowUserToOrderColumns = true;
            this.dgvMisAct.AutoGenerateColumns = false;
            this.dgvMisAct.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvMisAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn1,
            this.creadorActividadDataGridViewTextBoxColumn1,
            this.nombreActividadDataGridViewTextBoxColumn1,
            this.descripcionActividadDataGridViewTextBoxColumn1,
            this.fechaInicioActividadDataGridViewTextBoxColumn1,
            this.fechaFinActividadDataGridViewTextBoxColumn1,
            this.horaInicioActividadDataGridViewTextBoxColumn1,
            this.horaFinActividadDataGridViewTextBoxColumn1,
            this.lugarActividadDataGridViewTextBoxColumn1,
            this.aforoActividadDataGridViewTextBoxColumn1});
            this.dgvMisAct.DataSource = this.actividadBindingSource1;
            this.dgvMisAct.Location = new System.Drawing.Point(12, 576);
            this.dgvMisAct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisAct.MultiSelect = false;
            this.dgvMisAct.Name = "dgvMisAct";
            this.dgvMisAct.ReadOnly = true;
            this.dgvMisAct.RowHeadersWidth = 62;
            this.dgvMisAct.RowTemplate.Height = 28;
            this.dgvMisAct.Size = new System.Drawing.Size(312, 206);
            this.dgvMisAct.TabIndex = 81;
            this.dgvMisAct.SelectionChanged += new System.EventHandler(this.dgvMisAct_SelectionChanged);
            // 
            // idActividadDataGridViewTextBoxColumn1
            // 
            this.idActividadDataGridViewTextBoxColumn1.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn1.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idActividadDataGridViewTextBoxColumn1.Name = "idActividadDataGridViewTextBoxColumn1";
            this.idActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idActividadDataGridViewTextBoxColumn1.Visible = false;
            this.idActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // creadorActividadDataGridViewTextBoxColumn1
            // 
            this.creadorActividadDataGridViewTextBoxColumn1.DataPropertyName = "creadorActividad";
            this.creadorActividadDataGridViewTextBoxColumn1.HeaderText = "creadorActividad";
            this.creadorActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.creadorActividadDataGridViewTextBoxColumn1.Name = "creadorActividadDataGridViewTextBoxColumn1";
            this.creadorActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.creadorActividadDataGridViewTextBoxColumn1.Visible = false;
            this.creadorActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nombreActividadDataGridViewTextBoxColumn1
            // 
            this.nombreActividadDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreActividadDataGridViewTextBoxColumn1.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nombreActividadDataGridViewTextBoxColumn1.Name = "nombreActividadDataGridViewTextBoxColumn1";
            this.nombreActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionActividadDataGridViewTextBoxColumn1
            // 
            this.descripcionActividadDataGridViewTextBoxColumn1.DataPropertyName = "descripcionActividad";
            this.descripcionActividadDataGridViewTextBoxColumn1.HeaderText = "descripcionActividad";
            this.descripcionActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.descripcionActividadDataGridViewTextBoxColumn1.Name = "descripcionActividadDataGridViewTextBoxColumn1";
            this.descripcionActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionActividadDataGridViewTextBoxColumn1.Visible = false;
            this.descripcionActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // fechaInicioActividadDataGridViewTextBoxColumn1
            // 
            this.fechaInicioActividadDataGridViewTextBoxColumn1.DataPropertyName = "fechaInicioActividad";
            this.fechaInicioActividadDataGridViewTextBoxColumn1.HeaderText = "fechaInicioActividad";
            this.fechaInicioActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fechaInicioActividadDataGridViewTextBoxColumn1.Name = "fechaInicioActividadDataGridViewTextBoxColumn1";
            this.fechaInicioActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaInicioActividadDataGridViewTextBoxColumn1.Visible = false;
            this.fechaInicioActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // fechaFinActividadDataGridViewTextBoxColumn1
            // 
            this.fechaFinActividadDataGridViewTextBoxColumn1.DataPropertyName = "fechaFinActividad";
            this.fechaFinActividadDataGridViewTextBoxColumn1.HeaderText = "fechaFinActividad";
            this.fechaFinActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fechaFinActividadDataGridViewTextBoxColumn1.Name = "fechaFinActividadDataGridViewTextBoxColumn1";
            this.fechaFinActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaFinActividadDataGridViewTextBoxColumn1.Visible = false;
            this.fechaFinActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // horaInicioActividadDataGridViewTextBoxColumn1
            // 
            this.horaInicioActividadDataGridViewTextBoxColumn1.DataPropertyName = "horaInicioActividad";
            this.horaInicioActividadDataGridViewTextBoxColumn1.HeaderText = "horaInicioActividad";
            this.horaInicioActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.horaInicioActividadDataGridViewTextBoxColumn1.Name = "horaInicioActividadDataGridViewTextBoxColumn1";
            this.horaInicioActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horaInicioActividadDataGridViewTextBoxColumn1.Visible = false;
            this.horaInicioActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // horaFinActividadDataGridViewTextBoxColumn1
            // 
            this.horaFinActividadDataGridViewTextBoxColumn1.DataPropertyName = "horaFinActividad";
            this.horaFinActividadDataGridViewTextBoxColumn1.HeaderText = "horaFinActividad";
            this.horaFinActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.horaFinActividadDataGridViewTextBoxColumn1.Name = "horaFinActividadDataGridViewTextBoxColumn1";
            this.horaFinActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horaFinActividadDataGridViewTextBoxColumn1.Visible = false;
            this.horaFinActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lugarActividadDataGridViewTextBoxColumn1
            // 
            this.lugarActividadDataGridViewTextBoxColumn1.DataPropertyName = "lugarActividad";
            this.lugarActividadDataGridViewTextBoxColumn1.HeaderText = "lugarActividad";
            this.lugarActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.lugarActividadDataGridViewTextBoxColumn1.Name = "lugarActividadDataGridViewTextBoxColumn1";
            this.lugarActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lugarActividadDataGridViewTextBoxColumn1.Visible = false;
            this.lugarActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // aforoActividadDataGridViewTextBoxColumn1
            // 
            this.aforoActividadDataGridViewTextBoxColumn1.DataPropertyName = "aforoActividad";
            this.aforoActividadDataGridViewTextBoxColumn1.HeaderText = "aforoActividad";
            this.aforoActividadDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.aforoActividadDataGridViewTextBoxColumn1.Name = "aforoActividadDataGridViewTextBoxColumn1";
            this.aforoActividadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aforoActividadDataGridViewTextBoxColumn1.Visible = false;
            this.aforoActividadDataGridViewTextBoxColumn1.Width = 150;
            // 
            // actividadBindingSource1
            // 
            this.actividadBindingSource1.DataMember = "Actividad";
            this.actividadBindingSource1.DataSource = this.apsgrupo02DataSet1;
            // 
            // apsgrupo02DataSet1
            // 
            this.apsgrupo02DataSet1.DataSetName = "apsgrupo02DataSet1";
            this.apsgrupo02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // cursosRealizadosBindingSource
            // 
            this.cursosRealizadosBindingSource.DataMember = "CursosRealizados";
            this.cursosRealizadosBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // cursosRealizadosTableAdapter
            // 
            this.cursosRealizadosTableAdapter.ClearBeforeFill = true;
            // 
            // actividadesRealizadasBindingSource
            // 
            this.actividadesRealizadasBindingSource.DataMember = "ActividadesRealizadas";
            this.actividadesRealizadasBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // actividadesRealizadasTableAdapter
            // 
            this.actividadesRealizadasTableAdapter.ClearBeforeFill = true;
            // 
            // actividadTableAdapter1
            // 
            this.actividadTableAdapter1.ClearBeforeFill = true;
            // 
            // fPantallaPrincipalAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1653, 1238);
            this.Controls.Add(this.dgvMisAct);
            this.Controls.Add(this.bMisAct);
            this.Controls.Add(this.bInscribirActividad);
            this.Controls.Add(this.bInscribirCurso);
            this.Controls.Add(this.bInformacionActividad);
            this.Controls.Add(this.bInformacionCurso);
            this.Controls.Add(this.lNoCursos);
            this.Controls.Add(this.lNoActividades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lCursos);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.Noticias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bInsAct);
            this.Controls.Add(this.bInfoAct);
            this.Controls.Add(this.bInsCurso);
            this.Controls.Add(this.bInfoCurso);
            this.Controls.Add(this.dgvMisCursos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvNuevasActividades);
            this.Controls.Add(this.dgvNuevosCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNuevosCursos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fPantallaPrincipalAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fPantallaPrincipalAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevosCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosRealizadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesRealizadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvMisCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
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
        private System.Windows.Forms.BindingSource cursoBindingSource2;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.BindingSource cursoBindingSource3;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private apsgrupo02DataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.BindingSource cursosRealizadosBindingSource;
        private apsgrupo02DataSetTableAdapters.CursosRealizadosTableAdapter cursosRealizadosTableAdapter;
        private System.Windows.Forms.BindingSource actividadesRealizadasBindingSource;
        private apsgrupo02DataSetTableAdapters.ActividadesRealizadasTableAdapter actividadesRealizadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aforoCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineCursoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource cursoBindingSource4;
        private System.Windows.Forms.Button bInfoCurso;
        private System.Windows.Forms.Button bInsCurso;
        private System.Windows.Forms.Button bInsAct;
        private System.Windows.Forms.Button bInfoAct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Noticias;
        private Button bInscribirActividad;
        private Button bInscribirCurso;
        private Button bInformacionActividad;
        private Button bInformacionCurso;
        private Label lNoCursos;
        private Label lNoActividades;
        private Label label4;
        private Label lCursos;
        private DataGridView dgvActividades;
        private DataGridView dgvCursos;
        private MonthCalendar calendario;
        private Button bMisAct;
        private DataGridView dgvMisAct;
        private apsgrupo02DataSet1 apsgrupo02DataSet1;
        private BindingSource actividadBindingSource1;
        private apsgrupo02DataSet1TableAdapters.ActividadTableAdapter actividadTableAdapter1;
        private DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creadorActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descripcionActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaInicioActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaFinActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn horaInicioActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn horaFinActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lugarActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn aforoActividadDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}