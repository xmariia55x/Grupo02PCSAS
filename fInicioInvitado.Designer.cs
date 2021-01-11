
namespace Grupo02PCSAS
{
    partial class fInicioInvitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInicioInvitado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lError = new System.Windows.Forms.Label();
            this.bRegistrate = new System.Windows.Forms.Button();
            this.bIniciarSesión = new System.Windows.Forms.Button();
            this.lTienesCuenta = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
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
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aforoActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bInfoCurso = new System.Windows.Forms.Button();
            this.bInfoActividad = new System.Windows.Forms.Button();
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.actividadTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.ActividadTableAdapter();
            this.lRecuperarContrasenia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lRecuperarContrasenia);
            this.panel1.Controls.Add(this.lError);
            this.panel1.Controls.Add(this.bRegistrate);
            this.panel1.Controls.Add(this.bIniciarSesión);
            this.panel1.Controls.Add(this.lTienesCuenta);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 177);
            this.panel1.TabIndex = 7;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lError.ForeColor = System.Drawing.Color.Red;
            this.lError.Location = new System.Drawing.Point(425, 102);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 26);
            this.lError.TabIndex = 13;
            // 
            // bRegistrate
            // 
            this.bRegistrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRegistrate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRegistrate.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrate.Location = new System.Drawing.Point(1052, 87);
            this.bRegistrate.Name = "bRegistrate";
            this.bRegistrate.Size = new System.Drawing.Size(238, 73);
            this.bRegistrate.TabIndex = 12;
            this.bRegistrate.Text = "Regístrate";
            this.bRegistrate.UseVisualStyleBackColor = false;
            this.bRegistrate.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // bIniciarSesión
            // 
            this.bIniciarSesión.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bIniciarSesión.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bIniciarSesión.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciarSesión.Location = new System.Drawing.Point(1052, 8);
            this.bIniciarSesión.Name = "bIniciarSesión";
            this.bIniciarSesión.Size = new System.Drawing.Size(238, 73);
            this.bIniciarSesión.TabIndex = 11;
            this.bIniciarSesión.Text = "Iniciar sesión";
            this.bIniciarSesión.UseVisualStyleBackColor = false;
            this.bIniciarSesión.Click += new System.EventHandler(this.bIniciarSesión_Click);
            // 
            // lTienesCuenta
            // 
            this.lTienesCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lTienesCuenta.AutoSize = true;
            this.lTienesCuenta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTienesCuenta.Location = new System.Drawing.Point(813, 111);
            this.lTienesCuenta.Name = "lTienesCuenta";
            this.lTienesCuenta.Size = new System.Drawing.Size(179, 26);
            this.lTienesCuenta.TabIndex = 10;
            this.lTienesCuenta.Text = "¿No tienes cuenta?";
            this.lTienesCuenta.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(701, 19);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(334, 35);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "Password";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsuario.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(362, 19);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(334, 35);
            this.tbUsuario.TabIndex = 8;
            this.tbUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Quiénes somos?";
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(6, 298);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(387, 231);
            this.lDescripcion.TabIndex = 14;
            this.lDescripcion.Text = resources.GetString("lDescripcion.Text");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nuestros cursos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToOrderColumns = true;
            this.dgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursos.AutoGenerateColumns = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCursos.DataSource = this.cursoBindingSource;
            this.dgvCursos.Location = new System.Drawing.Point(411, 260);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidth = 62;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(666, 193);
            this.dgvCursos.TabIndex = 15;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            this.dgvCursos.SelectionChanged += new System.EventHandler(this.dgvCursos_SelectionChanged);
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCursoDataGridViewTextBoxColumn.Visible = false;
            this.idCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // profesorCursoDataGridViewTextBoxColumn
            // 
            this.profesorCursoDataGridViewTextBoxColumn.DataPropertyName = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.HeaderText = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profesorCursoDataGridViewTextBoxColumn.Name = "profesorCursoDataGridViewTextBoxColumn";
            this.profesorCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesorCursoDataGridViewTextBoxColumn.Visible = false;
            this.profesorCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionCursoDataGridViewTextBoxColumn
            // 
            this.descripcionCursoDataGridViewTextBoxColumn.DataPropertyName = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.HeaderText = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionCursoDataGridViewTextBoxColumn.Name = "descripcionCursoDataGridViewTextBoxColumn";
            this.descripcionCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionCursoDataGridViewTextBoxColumn.Visible = false;
            this.descripcionCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioCursoDataGridViewTextBoxColumn
            // 
            this.fechaInicioCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.fechaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Name = "fechaInicioCursoDataGridViewTextBoxColumn";
            this.fechaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Width = 112;
            // 
            // fechaFinCursoDataGridViewTextBoxColumn
            // 
            this.fechaFinCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn.HeaderText = "Fecha fin";
            this.fechaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaFinCursoDataGridViewTextBoxColumn.Name = "fechaFinCursoDataGridViewTextBoxColumn";
            this.fechaFinCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinCursoDataGridViewTextBoxColumn.Width = 95;
            // 
            // horaInicioCursoDataGridViewTextBoxColumn
            // 
            this.horaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.HeaderText = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaInicioCursoDataGridViewTextBoxColumn.Name = "horaInicioCursoDataGridViewTextBoxColumn";
            this.horaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioCursoDataGridViewTextBoxColumn.Visible = false;
            this.horaInicioCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaFinCursoDataGridViewTextBoxColumn
            // 
            this.horaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.HeaderText = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaFinCursoDataGridViewTextBoxColumn.Name = "horaFinCursoDataGridViewTextBoxColumn";
            this.horaFinCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaFinCursoDataGridViewTextBoxColumn.Visible = false;
            this.horaFinCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // lugarCursoDataGridViewTextBoxColumn
            // 
            this.lugarCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lugarCursoDataGridViewTextBoxColumn.DataPropertyName = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lugarCursoDataGridViewTextBoxColumn.Name = "lugarCursoDataGridViewTextBoxColumn";
            this.lugarCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lugarCursoDataGridViewTextBoxColumn.Width = 74;
            // 
            // aforoCursoDataGridViewTextBoxColumn
            // 
            this.aforoCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aforoCursoDataGridViewTextBoxColumn.DataPropertyName = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn.HeaderText = "Aforo";
            this.aforoCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aforoCursoDataGridViewTextBoxColumn.Name = "aforoCursoDataGridViewTextBoxColumn";
            this.aforoCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.aforoCursoDataGridViewTextBoxColumn.Width = 71;
            // 
            // onlineCursoDataGridViewTextBoxColumn
            // 
            this.onlineCursoDataGridViewTextBoxColumn.DataPropertyName = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.HeaderText = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onlineCursoDataGridViewTextBoxColumn.Name = "onlineCursoDataGridViewTextBoxColumn";
            this.onlineCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.onlineCursoDataGridViewTextBoxColumn.Visible = false;
            this.onlineCursoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToOrderColumns = true;
            this.dgvActividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActividades.AutoGenerateColumns = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.creadorActividadDataGridViewTextBoxColumn,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.descripcionActividadDataGridViewTextBoxColumn,
            this.fechaInicioActividadDataGridViewTextBoxColumn,
            this.fechaFinActividadDataGridViewTextBoxColumn,
            this.horaInicioActividadDataGridViewTextBoxColumn,
            this.horaFinActividadDataGridViewTextBoxColumn,
            this.lugarActividadDataGridViewTextBoxColumn,
            this.aforoActividadDataGridViewTextBoxColumn});
            this.dgvActividades.DataSource = this.actividadBindingSource;
            this.dgvActividades.Location = new System.Drawing.Point(411, 578);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersWidth = 62;
            this.dgvActividades.RowTemplate.Height = 28;
            this.dgvActividades.Size = new System.Drawing.Size(666, 193);
            this.dgvActividades.TabIndex = 17;
            this.dgvActividades.SelectionChanged += new System.EventHandler(this.dgvActividades_SelectionChanged);
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActividadDataGridViewTextBoxColumn.Visible = false;
            this.idActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // creadorActividadDataGridViewTextBoxColumn
            // 
            this.creadorActividadDataGridViewTextBoxColumn.DataPropertyName = "creadorActividad";
            this.creadorActividadDataGridViewTextBoxColumn.HeaderText = "creadorActividad";
            this.creadorActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creadorActividadDataGridViewTextBoxColumn.Name = "creadorActividadDataGridViewTextBoxColumn";
            this.creadorActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.creadorActividadDataGridViewTextBoxColumn.Visible = false;
            this.creadorActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionActividadDataGridViewTextBoxColumn
            // 
            this.descripcionActividadDataGridViewTextBoxColumn.DataPropertyName = "descripcionActividad";
            this.descripcionActividadDataGridViewTextBoxColumn.HeaderText = "descripcionActividad";
            this.descripcionActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionActividadDataGridViewTextBoxColumn.Name = "descripcionActividadDataGridViewTextBoxColumn";
            this.descripcionActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionActividadDataGridViewTextBoxColumn.Visible = false;
            this.descripcionActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioActividadDataGridViewTextBoxColumn
            // 
            this.fechaInicioActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioActividadDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioActividad";
            this.fechaInicioActividadDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.fechaInicioActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioActividadDataGridViewTextBoxColumn.Name = "fechaInicioActividadDataGridViewTextBoxColumn";
            this.fechaInicioActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioActividadDataGridViewTextBoxColumn.Width = 112;
            // 
            // fechaFinActividadDataGridViewTextBoxColumn
            // 
            this.fechaFinActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaFinActividadDataGridViewTextBoxColumn.DataPropertyName = "fechaFinActividad";
            this.fechaFinActividadDataGridViewTextBoxColumn.HeaderText = "Fecha fin";
            this.fechaFinActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaFinActividadDataGridViewTextBoxColumn.Name = "fechaFinActividadDataGridViewTextBoxColumn";
            this.fechaFinActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinActividadDataGridViewTextBoxColumn.Width = 95;
            // 
            // horaInicioActividadDataGridViewTextBoxColumn
            // 
            this.horaInicioActividadDataGridViewTextBoxColumn.DataPropertyName = "horaInicioActividad";
            this.horaInicioActividadDataGridViewTextBoxColumn.HeaderText = "horaInicioActividad";
            this.horaInicioActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaInicioActividadDataGridViewTextBoxColumn.Name = "horaInicioActividadDataGridViewTextBoxColumn";
            this.horaInicioActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioActividadDataGridViewTextBoxColumn.Visible = false;
            this.horaInicioActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaFinActividadDataGridViewTextBoxColumn
            // 
            this.horaFinActividadDataGridViewTextBoxColumn.DataPropertyName = "horaFinActividad";
            this.horaFinActividadDataGridViewTextBoxColumn.HeaderText = "horaFinActividad";
            this.horaFinActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaFinActividadDataGridViewTextBoxColumn.Name = "horaFinActividadDataGridViewTextBoxColumn";
            this.horaFinActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaFinActividadDataGridViewTextBoxColumn.Visible = false;
            this.horaFinActividadDataGridViewTextBoxColumn.Width = 125;
            // 
            // lugarActividadDataGridViewTextBoxColumn
            // 
            this.lugarActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lugarActividadDataGridViewTextBoxColumn.DataPropertyName = "lugarActividad";
            this.lugarActividadDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lugarActividadDataGridViewTextBoxColumn.Name = "lugarActividadDataGridViewTextBoxColumn";
            this.lugarActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.lugarActividadDataGridViewTextBoxColumn.Width = 74;
            // 
            // aforoActividadDataGridViewTextBoxColumn
            // 
            this.aforoActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aforoActividadDataGridViewTextBoxColumn.DataPropertyName = "aforoActividad";
            this.aforoActividadDataGridViewTextBoxColumn.HeaderText = "Aforo";
            this.aforoActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aforoActividadDataGridViewTextBoxColumn.Name = "aforoActividadDataGridViewTextBoxColumn";
            this.aforoActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.aforoActividadDataGridViewTextBoxColumn.Width = 71;
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nuestras Actividades";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources.logo_uma;
            this.pictureBox3.Location = new System.Drawing.Point(11, 641);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(357, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.Logo_Informatica;
            this.pictureBox2.Location = new System.Drawing.Point(50, 551);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // bInfoCurso
            // 
            this.bInfoCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfoCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoCurso.Location = new System.Drawing.Point(1123, 298);
            this.bInfoCurso.Name = "bInfoCurso";
            this.bInfoCurso.Size = new System.Drawing.Size(157, 88);
            this.bInfoCurso.TabIndex = 20;
            this.bInfoCurso.Text = "Informacion del curso";
            this.bInfoCurso.UseVisualStyleBackColor = false;
            this.bInfoCurso.Click += new System.EventHandler(this.bInfoCurso_Click);
            // 
            // bInfoActividad
            // 
            this.bInfoActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfoActividad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoActividad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoActividad.Location = new System.Drawing.Point(1123, 620);
            this.bInfoActividad.Name = "bInfoActividad";
            this.bInfoActividad.Size = new System.Drawing.Size(157, 110);
            this.bInfoActividad.TabIndex = 21;
            this.bInfoActividad.Text = "Informacion de la Actividad";
            this.bInfoActividad.UseVisualStyleBackColor = false;
            this.bInfoActividad.Click += new System.EventHandler(this.bInfoActividad_Click);
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // lRecuperarContrasenia
            // 
            this.lRecuperarContrasenia.AutoSize = true;
            this.lRecuperarContrasenia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecuperarContrasenia.Location = new System.Drawing.Point(425, 87);
            this.lRecuperarContrasenia.Name = "lRecuperarContrasenia";
            this.lRecuperarContrasenia.Size = new System.Drawing.Size(210, 26);
            this.lRecuperarContrasenia.TabIndex = 14;
            this.lRecuperarContrasenia.Text = "Recuperar contraseña";
            this.lRecuperarContrasenia.Click += new System.EventHandler(this.lRecuperarContrasenia_Click);
            // 
            // fInicioInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1469, 840);
            this.Controls.Add(this.bInfoActividad);
            this.Controls.Add(this.bInfoCurso);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fInicioInvitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fInicioInvitado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegistrate;
        private System.Windows.Forms.Button bIniciarSesión;
        private System.Windows.Forms.Label lTienesCuenta;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.Button bInfoCurso;
        private System.Windows.Forms.Button bInfoActividad;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private apsgrupo02DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private apsgrupo02DataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadorActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aforoActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lRecuperarContrasenia;
    }
}