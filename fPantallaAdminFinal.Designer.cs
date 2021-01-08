
using System.Windows.Forms;

namespace Grupo02PCSAS
{
    partial class fPantallaAdminFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.bCurso = new System.Windows.Forms.Button();
            this.bActividades = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.bForos = new System.Windows.Forms.Button();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.actividadTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.ActividadTableAdapter();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.UsuarioTableAdapter();
            this.dgvForos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet1 = new Grupo02PCSAS.apsgrupo02DataSet1();
            this.creadorDebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debateTableAdapter1 = new Grupo02PCSAS.apsgrupo02DataSet1TableAdapters.DebateTableAdapter();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bNoticias = new System.Windows.Forms.Button();
            this.dgvDebates = new System.Windows.Forms.DataGridView();
            this.debateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 177);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1161, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mi perfil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1147, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lRol
            // 
            this.lRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(671, 116);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rol: ";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(726, 38);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(346, 44);
            this.lNombreApellidos.TabIndex = 3;
            this.lNombreApellidos.Text = "Nombre y apellidos";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hola,";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 178);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // bUsuarios
            // 
            this.bUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bUsuarios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUsuarios.Location = new System.Drawing.Point(616, 240);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(215, 50);
            this.bUsuarios.TabIndex = 60;
            this.bUsuarios.Text = "Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = false;
            this.bUsuarios.Click += new System.EventHandler(this.bUsuarios_Click);
            // 
            // bCurso
            // 
            this.bCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCurso.Location = new System.Drawing.Point(404, 240);
            this.bCurso.Name = "bCurso";
            this.bCurso.Size = new System.Drawing.Size(215, 50);
            this.bCurso.TabIndex = 59;
            this.bCurso.Text = "Cursos";
            this.bCurso.UseVisualStyleBackColor = false;
            this.bCurso.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bActividades
            // 
            this.bActividades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bActividades.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bActividades.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActividades.Location = new System.Drawing.Point(192, 240);
            this.bActividades.Name = "bActividades";
            this.bActividades.Size = new System.Drawing.Size(215, 50);
            this.bActividades.TabIndex = 58;
            this.bActividades.Text = "Actividades";
            this.bActividades.UseVisualStyleBackColor = false;
            this.bActividades.Click += new System.EventHandler(this.bActividades_Click);
            // 
            // bCrear
            // 
            this.bCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCrear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrear.Location = new System.Drawing.Point(298, 699);
            this.bCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(172, 50);
            this.bCrear.TabIndex = 57;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = false;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // bForos
            // 
            this.bForos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bForos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bForos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForos.Location = new System.Drawing.Point(827, 240);
            this.bForos.Name = "bForos";
            this.bForos.Size = new System.Drawing.Size(215, 50);
            this.bForos.TabIndex = 63;
            this.bForos.Text = "Foros";
            this.bForos.UseVisualStyleBackColor = false;
            this.bForos.Click += new System.EventHandler(this.bForos_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToOrderColumns = true;
            this.dgvActividades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvActividades.AutoGenerateColumns = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.creadorActividadDataGridViewTextBoxColumn,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.fechaInicioActividadDataGridViewTextBoxColumn,
            this.horaInicioActividadDataGridViewTextBoxColumn,
            this.lugarActividadDataGridViewTextBoxColumn});
            this.dgvActividades.DataSource = this.actividadBindingSource;
            this.dgvActividades.Location = new System.Drawing.Point(119, 329);
            this.dgvActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersWidth = 62;
            this.dgvActividades.RowTemplate.Height = 28;
            this.dgvActividades.Size = new System.Drawing.Size(1012, 326);
            this.dgvActividades.TabIndex = 64;
            this.dgvActividades.SelectionChanged += new System.EventHandler(this.dgvActividades_SelectionChanged);
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToOrderColumns = true;
            this.dgvCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.profesorCursoDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.fechaInicioCursoDataGridViewTextBoxColumn,
            this.horaInicioCursoDataGridViewTextBoxColumn,
            this.lugarCursoDataGridViewTextBoxColumn,
            this.onlineCursoDataGridViewTextBoxColumn});
            this.dgvCursos.DataSource = this.cursoBindingSource;
            this.dgvCursos.Location = new System.Drawing.Point(119, 329);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 62;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(1012, 326);
            this.dgvCursos.TabIndex = 65;
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correoUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.contraseniaUsuarioDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.niuDataGridViewTextBoxColumn,
            this.rolUsuarioDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuarioBindingSource;
            this.dgvUsuarios.Location = new System.Drawing.Point(119, 329);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(1012, 326);
            this.dgvUsuarios.TabIndex = 66;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // dgvForos
            // 
            this.dgvForos.AllowUserToAddRows = false;
            this.dgvForos.AllowUserToDeleteRows = false;
            this.dgvForos.AllowUserToOrderColumns = true;
            this.dgvForos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvForos.AutoGenerateColumns = false;
            this.dgvForos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.creadorDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.mensajeDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn});
            this.dgvForos.DataSource = this.debateBindingSource1;
            this.dgvForos.Location = new System.Drawing.Point(97, 334);
            this.dgvForos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvForos.Name = "dgvForos";
            this.dgvForos.ReadOnly = true;
            this.dgvForos.RowHeadersWidth = 62;
            this.dgvForos.RowTemplate.Height = 28;
            this.dgvForos.Size = new System.Drawing.Size(1012, 326);
            this.dgvForos.TabIndex = 67;
            this.dgvForos.SelectionChanged += new System.EventHandler(this.dgvForos_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // creadorDataGridViewTextBoxColumn
            // 
            this.creadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.creadorDataGridViewTextBoxColumn.DataPropertyName = "creador";
            this.creadorDataGridViewTextBoxColumn.HeaderText = "Creador";
            this.creadorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creadorDataGridViewTextBoxColumn.Name = "creadorDataGridViewTextBoxColumn";
            this.creadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creadorDataGridViewTextBoxColumn.Width = 125;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            this.asuntoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mensajeDataGridViewTextBoxColumn
            // 
            this.mensajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mensajeDataGridViewTextBoxColumn.DataPropertyName = "mensaje";
            this.mensajeDataGridViewTextBoxColumn.HeaderText = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensajeDataGridViewTextBoxColumn.Name = "mensajeDataGridViewTextBoxColumn";
            this.mensajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 125;
            // 
            // debateBindingSource1
            // 
            this.debateBindingSource1.DataMember = "Debate";
            this.debateBindingSource1.DataSource = this.apsgrupo02DataSet1;
            // 
            // apsgrupo02DataSet1
            // 
            this.apsgrupo02DataSet1.DataSetName = "apsgrupo02DataSet1";
            this.apsgrupo02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creadorDebateDataGridViewTextBoxColumn
            // 
            this.creadorDebateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creadorDebateDataGridViewTextBoxColumn.Name = "creadorDebateDataGridViewTextBoxColumn";
            this.creadorDebateDataGridViewTextBoxColumn.Width = 125;
            // 
            // asuntoDebateDataGridViewTextBoxColumn
            // 
            this.asuntoDebateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asuntoDebateDataGridViewTextBoxColumn.Name = "asuntoDebateDataGridViewTextBoxColumn";
            this.asuntoDebateDataGridViewTextBoxColumn.Width = 125;
            // 
            // mensajeDebateDataGridViewTextBoxColumn
            // 
            this.mensajeDebateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensajeDebateDataGridViewTextBoxColumn.Name = "mensajeDebateDataGridViewTextBoxColumn";
            this.mensajeDebateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // debateTableAdapter1
            // 
            this.debateTableAdapter1.ClearBeforeFill = true;
            // 
            // bBorrar
            // 
            this.bBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bBorrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBorrar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(784, 699);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(172, 50);
            this.bBorrar.TabIndex = 68;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = false;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bNoticias
            // 
            this.bNoticias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bNoticias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNoticias.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNoticias.Location = new System.Drawing.Point(538, 699);
            this.bNoticias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNoticias.Name = "bNoticias";
            this.bNoticias.Size = new System.Drawing.Size(172, 50);
            this.bNoticias.TabIndex = 69;
            this.bNoticias.Text = "Noticias";
            this.bNoticias.UseVisualStyleBackColor = false;
            this.bNoticias.Click += new System.EventHandler(this.bNoticias_Click);
            // 
            // dgvDebates
            // 
            this.dgvDebates.AllowUserToAddRows = false;
            this.dgvDebates.AllowUserToDeleteRows = false;
            this.dgvDebates.AllowUserToOrderColumns = true;
            this.dgvDebates.AutoGenerateColumns = false;
            this.dgvDebates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.creadorDataGridViewTextBoxColumn1,
            this.asuntoDataGridViewTextBoxColumn1,
            this.mensajeDataGridViewTextBoxColumn1,
            this.fechaInicioDataGridViewTextBoxColumn1});
            this.dgvDebates.DataSource = this.debateBindingSource;
            this.dgvDebates.Location = new System.Drawing.Point(119, 329);
            this.dgvDebates.Name = "dgvDebates";
            this.dgvDebates.ReadOnly = true;
            this.dgvDebates.RowHeadersWidth = 51;
            this.dgvDebates.RowTemplate.Height = 24;
            this.dgvDebates.Size = new System.Drawing.Size(1012, 326);
            this.dgvDebates.TabIndex = 70;
            this.dgvDebates.SelectionChanged += new System.EventHandler(this.dgvDebates_SelectionChanged);
            // 
            // debateBindingSource
            // 
            this.debateBindingSource.DataMember = "Debate";
            this.debateBindingSource.DataSource = this.apsgrupo02DataSet1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // creadorDataGridViewTextBoxColumn1
            // 
            this.creadorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.creadorDataGridViewTextBoxColumn1.DataPropertyName = "creador";
            this.creadorDataGridViewTextBoxColumn1.HeaderText = "Creador";
            this.creadorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creadorDataGridViewTextBoxColumn1.Name = "creadorDataGridViewTextBoxColumn1";
            this.creadorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.creadorDataGridViewTextBoxColumn1.Width = 88;
            // 
            // asuntoDataGridViewTextBoxColumn1
            // 
            this.asuntoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.asuntoDataGridViewTextBoxColumn1.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn1.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.asuntoDataGridViewTextBoxColumn1.Name = "asuntoDataGridViewTextBoxColumn1";
            this.asuntoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.asuntoDataGridViewTextBoxColumn1.Width = 81;
            // 
            // mensajeDataGridViewTextBoxColumn1
            // 
            this.mensajeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mensajeDataGridViewTextBoxColumn1.DataPropertyName = "mensaje";
            this.mensajeDataGridViewTextBoxColumn1.HeaderText = "Mensaje";
            this.mensajeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mensajeDataGridViewTextBoxColumn1.Name = "mensajeDataGridViewTextBoxColumn1";
            this.mensajeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn1
            // 
            this.fechaInicioDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioDataGridViewTextBoxColumn1.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn1.HeaderText = "Fecha de Inicio";
            this.fechaInicioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaInicioDataGridViewTextBoxColumn1.Name = "fechaInicioDataGridViewTextBoxColumn1";
            this.fechaInicioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn1.Width = 92;
            // 
            // correoUsuarioDataGridViewTextBoxColumn
            // 
            this.correoUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "correoUsuario";
            this.correoUsuarioDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.correoUsuarioDataGridViewTextBoxColumn.Name = "correoUsuarioDataGridViewTextBoxColumn";
            this.correoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniaUsuarioDataGridViewTextBoxColumn
            // 
            this.contraseniaUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contraseniaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "contraseniaUsuario";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contraseniaUsuarioDataGridViewTextBoxColumn.Name = "contraseniaUsuarioDataGridViewTextBoxColumn";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // niuDataGridViewTextBoxColumn
            // 
            this.niuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.niuDataGridViewTextBoxColumn.DataPropertyName = "niu";
            this.niuDataGridViewTextBoxColumn.HeaderText = "NIU";
            this.niuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.niuDataGridViewTextBoxColumn.Name = "niuDataGridViewTextBoxColumn";
            this.niuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolUsuarioDataGridViewTextBoxColumn
            // 
            this.rolUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rolUsuarioDataGridViewTextBoxColumn.DataPropertyName = "rolUsuario";
            this.rolUsuarioDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rolUsuarioDataGridViewTextBoxColumn.Name = "rolUsuarioDataGridViewTextBoxColumn";
            this.rolUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolUsuarioDataGridViewTextBoxColumn.Width = 58;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCursoDataGridViewTextBoxColumn.Visible = false;
            this.idCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // profesorCursoDataGridViewTextBoxColumn
            // 
            this.profesorCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profesorCursoDataGridViewTextBoxColumn.DataPropertyName = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.profesorCursoDataGridViewTextBoxColumn.Name = "profesorCursoDataGridViewTextBoxColumn";
            this.profesorCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioCursoDataGridViewTextBoxColumn
            // 
            this.fechaInicioCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Name = "fechaInicioCursoDataGridViewTextBoxColumn";
            this.fechaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Width = 132;
            // 
            // horaInicioCursoDataGridViewTextBoxColumn
            // 
            this.horaInicioCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.horaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.HeaderText = "Hora de Inicio";
            this.horaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaInicioCursoDataGridViewTextBoxColumn.Name = "horaInicioCursoDataGridViewTextBoxColumn";
            this.horaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioCursoDataGridViewTextBoxColumn.Width = 124;
            // 
            // lugarCursoDataGridViewTextBoxColumn
            // 
            this.lugarCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lugarCursoDataGridViewTextBoxColumn.DataPropertyName = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lugarCursoDataGridViewTextBoxColumn.Name = "lugarCursoDataGridViewTextBoxColumn";
            this.lugarCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onlineCursoDataGridViewTextBoxColumn
            // 
            this.onlineCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.onlineCursoDataGridViewTextBoxColumn.DataPropertyName = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.HeaderText = "Online";
            this.onlineCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.onlineCursoDataGridViewTextBoxColumn.Name = "onlineCursoDataGridViewTextBoxColumn";
            this.onlineCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.onlineCursoDataGridViewTextBoxColumn.Width = 78;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActividadDataGridViewTextBoxColumn.Visible = false;
            this.idActividadDataGridViewTextBoxColumn.Width = 150;
            // 
            // creadorActividadDataGridViewTextBoxColumn
            // 
            this.creadorActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creadorActividadDataGridViewTextBoxColumn.DataPropertyName = "creadorActividad";
            this.creadorActividadDataGridViewTextBoxColumn.HeaderText = "Creador";
            this.creadorActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creadorActividadDataGridViewTextBoxColumn.Name = "creadorActividadDataGridViewTextBoxColumn";
            this.creadorActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioActividadDataGridViewTextBoxColumn
            // 
            this.fechaInicioActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioActividadDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioActividad";
            this.fechaInicioActividadDataGridViewTextBoxColumn.HeaderText = "Fecha de Inicio";
            this.fechaInicioActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaInicioActividadDataGridViewTextBoxColumn.Name = "fechaInicioActividadDataGridViewTextBoxColumn";
            this.fechaInicioActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioActividadDataGridViewTextBoxColumn.Width = 132;
            // 
            // horaInicioActividadDataGridViewTextBoxColumn
            // 
            this.horaInicioActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.horaInicioActividadDataGridViewTextBoxColumn.DataPropertyName = "horaInicioActividad";
            this.horaInicioActividadDataGridViewTextBoxColumn.HeaderText = "Hora de Inicio";
            this.horaInicioActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaInicioActividadDataGridViewTextBoxColumn.Name = "horaInicioActividadDataGridViewTextBoxColumn";
            this.horaInicioActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioActividadDataGridViewTextBoxColumn.Width = 124;
            // 
            // lugarActividadDataGridViewTextBoxColumn
            // 
            this.lugarActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lugarActividadDataGridViewTextBoxColumn.DataPropertyName = "lugarActividad";
            this.lugarActividadDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarActividadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lugarActividadDataGridViewTextBoxColumn.Name = "lugarActividadDataGridViewTextBoxColumn";
            this.lugarActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fPantallaAdminFinal
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.dgvDebates);
            this.Controls.Add(this.bNoticias);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.bForos);
            this.Controls.Add(this.bUsuarios);
            this.Controls.Add(this.bCurso);
            this.Controls.Add(this.bActividades);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fPantallaAdminFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fpantallaAdminFinal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bUsuarios;
        private System.Windows.Forms.Button bCurso;
        private System.Windows.Forms.Button bActividades;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Button bForos;
        private System.Windows.Forms.DataGridView dgvActividades;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private apsgrupo02DataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private apsgrupo02DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private apsgrupo02DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DataGridView dgvForos;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bNoticias;
        private apsgrupo02DataSet1 apsgrupo02DataSet1;
        private System.Windows.Forms.BindingSource debateBindingSource1;
        private apsgrupo02DataSet1TableAdapters.DebateTableAdapter debateTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creadorDebateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn asuntoDebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private DataGridView dgvDebates;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn creadorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn1;
        private BindingSource debateBindingSource;
        private DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creadorActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaInicioActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lugarActividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaInicioCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaInicioCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lugarCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn onlineCursoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseniaUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn niuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolUsuarioDataGridViewTextBoxColumn;
    }
}