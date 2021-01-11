
namespace Grupo02PCSAS
{
    partial class fPrincipalProfesor
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.bAccederAlForo = new System.Windows.Forms.Button();
            this.bEventosInscritos = new System.Windows.Forms.Button();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bModCur = new System.Windows.Forms.Button();
            this.bDelCur = new System.Windows.Forms.Button();
            this.bInfCur = new System.Windows.Forms.Button();
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bNotProf = new System.Windows.Forms.Button();
            this.bListaParticipantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 57);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mis cursos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.cursoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 465);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 295);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.profesorCursoDataGridViewTextBoxColumn.DataPropertyName = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.HeaderText = "profesorCurso";
            this.profesorCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.profesorCursoDataGridViewTextBoxColumn.Name = "profesorCursoDataGridViewTextBoxColumn";
            this.profesorCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesorCursoDataGridViewTextBoxColumn.Visible = false;
            this.profesorCursoDataGridViewTextBoxColumn.Width = 150;
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
            // descripcionCursoDataGridViewTextBoxColumn
            // 
            this.descripcionCursoDataGridViewTextBoxColumn.DataPropertyName = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.HeaderText = "descripcionCurso";
            this.descripcionCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionCursoDataGridViewTextBoxColumn.Name = "descripcionCursoDataGridViewTextBoxColumn";
            this.descripcionCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionCursoDataGridViewTextBoxColumn.Visible = false;
            this.descripcionCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaInicioCursoDataGridViewTextBoxColumn
            // 
            this.fechaInicioCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaInicioCurso";
            this.fechaInicioCursoDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fechaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Name = "fechaInicioCursoDataGridViewTextBoxColumn";
            this.fechaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioCursoDataGridViewTextBoxColumn.Width = 131;
            // 
            // fechaFinCursoDataGridViewTextBoxColumn
            // 
            this.fechaFinCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "fechaFinCurso";
            this.fechaFinCursoDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.fechaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaFinCursoDataGridViewTextBoxColumn.Name = "fechaFinCursoDataGridViewTextBoxColumn";
            this.fechaFinCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFinCursoDataGridViewTextBoxColumn.Width = 116;
            // 
            // horaInicioCursoDataGridViewTextBoxColumn
            // 
            this.horaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.HeaderText = "horaInicioCurso";
            this.horaInicioCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaInicioCursoDataGridViewTextBoxColumn.Name = "horaInicioCursoDataGridViewTextBoxColumn";
            this.horaInicioCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaInicioCursoDataGridViewTextBoxColumn.Visible = false;
            this.horaInicioCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // horaFinCursoDataGridViewTextBoxColumn
            // 
            this.horaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.HeaderText = "horaFinCurso";
            this.horaFinCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.horaFinCursoDataGridViewTextBoxColumn.Name = "horaFinCursoDataGridViewTextBoxColumn";
            this.horaFinCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaFinCursoDataGridViewTextBoxColumn.Visible = false;
            this.horaFinCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // lugarCursoDataGridViewTextBoxColumn
            // 
            this.lugarCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lugarCursoDataGridViewTextBoxColumn.DataPropertyName = "lugarCurso";
            this.lugarCursoDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lugarCursoDataGridViewTextBoxColumn.Name = "lugarCursoDataGridViewTextBoxColumn";
            this.lugarCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lugarCursoDataGridViewTextBoxColumn.Width = 86;
            // 
            // aforoCursoDataGridViewTextBoxColumn
            // 
            this.aforoCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aforoCursoDataGridViewTextBoxColumn.DataPropertyName = "aforoCurso";
            this.aforoCursoDataGridViewTextBoxColumn.HeaderText = "Aforo";
            this.aforoCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aforoCursoDataGridViewTextBoxColumn.Name = "aforoCursoDataGridViewTextBoxColumn";
            this.aforoCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.aforoCursoDataGridViewTextBoxColumn.Width = 84;
            // 
            // onlineCursoDataGridViewTextBoxColumn
            // 
            this.onlineCursoDataGridViewTextBoxColumn.DataPropertyName = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.HeaderText = "onlineCurso";
            this.onlineCursoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.onlineCursoDataGridViewTextBoxColumn.Name = "onlineCursoDataGridViewTextBoxColumn";
            this.onlineCursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.onlineCursoDataGridViewTextBoxColumn.Visible = false;
            this.onlineCursoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.apsgrupo02DataSetBindingSource;
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
            // bAccederAlForo
            // 
            this.bAccederAlForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAccederAlForo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccederAlForo.Location = new System.Drawing.Point(104, 855);
            this.bAccederAlForo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAccederAlForo.Name = "bAccederAlForo";
            this.bAccederAlForo.Size = new System.Drawing.Size(204, 79);
            this.bAccederAlForo.TabIndex = 49;
            this.bAccederAlForo.Text = "Acceder al foro";
            this.bAccederAlForo.UseVisualStyleBackColor = false;
            this.bAccederAlForo.Click += new System.EventHandler(this.bAccederAlForo_Click);
            // 
            // bEventosInscritos
            // 
            this.bEventosInscritos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bEventosInscritos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEventosInscritos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventosInscritos.Location = new System.Drawing.Point(471, 855);
            this.bEventosInscritos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEventosInscritos.Name = "bEventosInscritos";
            this.bEventosInscritos.Size = new System.Drawing.Size(223, 79);
            this.bEventosInscritos.TabIndex = 50;
            this.bEventosInscritos.Text = "Eventos inscritos";
            this.bEventosInscritos.UseVisualStyleBackColor = false;
            this.bEventosInscritos.Click += new System.EventHandler(this.bEventosInscritos_Click);
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCrearCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrearCurso.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearCurso.Location = new System.Drawing.Point(862, 855);
            this.bCrearCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(223, 79);
            this.bCrearCurso.TabIndex = 51;
            this.bCrearCurso.Text = "Crear Curso";
            this.bCrearCurso.UseVisualStyleBackColor = false;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // bModCur
            // 
            this.bModCur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bModCur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bModCur.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.bModCur.Location = new System.Drawing.Point(1170, 686);
            this.bModCur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bModCur.Name = "bModCur";
            this.bModCur.Size = new System.Drawing.Size(223, 74);
            this.bModCur.TabIndex = 52;
            this.bModCur.Text = "Modificar Curso";
            this.bModCur.UseVisualStyleBackColor = false;
            this.bModCur.Click += new System.EventHandler(this.bModCur_Click);
            // 
            // bDelCur
            // 
            this.bDelCur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelCur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelCur.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.bDelCur.Location = new System.Drawing.Point(1170, 465);
            this.bDelCur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDelCur.Name = "bDelCur";
            this.bDelCur.Size = new System.Drawing.Size(223, 74);
            this.bDelCur.TabIndex = 53;
            this.bDelCur.Text = "Eliminar Curso";
            this.bDelCur.UseVisualStyleBackColor = false;
            this.bDelCur.Click += new System.EventHandler(this.bDelCur_Click);
            // 
            // bInfCur
            // 
            this.bInfCur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfCur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfCur.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.bInfCur.Location = new System.Drawing.Point(1170, 578);
            this.bInfCur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInfCur.Name = "bInfCur";
            this.bInfCur.Size = new System.Drawing.Size(223, 74);
            this.bInfCur.TabIndex = 54;
            this.bInfCur.Text = "Información Curso";
            this.bInfCur.UseVisualStyleBackColor = false;
            this.bInfCur.Click += new System.EventHandler(this.bInfCur_Click);
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombreUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 221);
            this.panel1.TabIndex = 55;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hola,";
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
            // bNotProf
            // 
            this.bNotProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNotProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNotProf.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNotProf.Location = new System.Drawing.Point(1170, 855);
            this.bNotProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bNotProf.Name = "bNotProf";
            this.bNotProf.Size = new System.Drawing.Size(223, 79);
            this.bNotProf.TabIndex = 56;
            this.bNotProf.Text = "Noticias";
            this.bNotProf.UseVisualStyleBackColor = false;
            this.bNotProf.Click += new System.EventHandler(this.bNotProf_Click);
            // 
            // bListaParticipantes
            // 
            this.bListaParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bListaParticipantes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bListaParticipantes.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.bListaParticipantes.Location = new System.Drawing.Point(1040, 291);
            this.bListaParticipantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bListaParticipantes.Name = "bListaParticipantes";
            this.bListaParticipantes.Size = new System.Drawing.Size(198, 59);
            this.bListaParticipantes.TabIndex = 56;
            this.bListaParticipantes.Text = "Ver participantes";
            this.bListaParticipantes.UseVisualStyleBackColor = false;
            this.bListaParticipantes.Click += new System.EventHandler(this.bListaParticipantes_Click);
            // 
            // fPrincipalProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1653, 1050);
            this.Controls.Add(this.bNotProf);
            this.ClientSize = new System.Drawing.Size(1469, 840);
            this.Controls.Add(this.bListaParticipantes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bInfCur);
            this.Controls.Add(this.bDelCur);
            this.Controls.Add(this.bModCur);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.bEventosInscritos);
            this.Controls.Add(this.bAccederAlForo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fPrincipalProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fPrincipalProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bAccederAlForo;
        private System.Windows.Forms.Button bEventosInscritos;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bModCur;
        private System.Windows.Forms.Button bDelCur;
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
        private System.Windows.Forms.Button bInfCur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bNotProf;
        private System.Windows.Forms.Button bListaParticipantes;
    }
}