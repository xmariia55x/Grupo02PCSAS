
namespace Grupo02PCSAS
{
    partial class PantallaBorrarCurso 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBorrarCurso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lProfesor = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.lHola = new System.Windows.Forms.Label();
            this.lMiPerfil = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbPcsas = new System.Windows.Forms.PictureBox();
            this.lCursos = new System.Windows.Forms.Label();
            this.bAtras = new System.Windows.Forms.Button();
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.bAccesoForo = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bBasura = new System.Windows.Forms.Button();
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
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
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPcsas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lProfesor);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.lHola);
            this.panel1.Controls.Add(this.lMiPerfil);
            this.panel1.Controls.Add(this.pbUsuario);
            this.panel1.Controls.Add(this.pbPcsas);
            this.panel1.Location = new System.Drawing.Point(-4, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 276);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lProfesor
            // 
            this.lProfesor.AutoSize = true;
            this.lProfesor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesor.Location = new System.Drawing.Point(1088, 188);
            this.lProfesor.Name = "lProfesor";
            this.lProfesor.Size = new System.Drawing.Size(101, 29);
            this.lProfesor.TabIndex = 6;
            this.lProfesor.Text = "Profesor";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(1027, 188);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(55, 29);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(845, 108);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(371, 55);
            this.lNombreApellidos.TabIndex = 4;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(723, 108);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(129, 55);
            this.lHola.TabIndex = 3;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // lMiPerfil
            // 
            this.lMiPerfil.AutoSize = true;
            this.lMiPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiPerfil.Location = new System.Drawing.Point(1295, 222);
            this.lMiPerfil.Name = "lMiPerfil";
            this.lMiPerfil.Size = new System.Drawing.Size(102, 29);
            this.lMiPerfil.TabIndex = 2;
            this.lMiPerfil.Text = "Mi perfil";
            // 
            // pbUsuario
            // 
            this.pbUsuario.ImageLocation = "C:\\Users\\Javi\\Source\\Repos\\xmariia55x\\Grupo02PCSAS\\Resources\\usuario.png";
            this.pbUsuario.Location = new System.Drawing.Point(1277, 54);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(144, 151);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // pbPcsas
            // 
            this.pbPcsas.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pbPcsas.Location = new System.Drawing.Point(-14, 4);
            this.pbPcsas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPcsas.Name = "pbPcsas";
            this.pbPcsas.Size = new System.Drawing.Size(276, 271);
            this.pbPcsas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPcsas.TabIndex = 0;
            this.pbPcsas.TabStop = false;
            this.pbPcsas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lCursos
            // 
            this.lCursos.AutoSize = true;
            this.lCursos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCursos.Location = new System.Drawing.Point(622, 331);
            this.lCursos.Name = "lCursos";
            this.lCursos.Size = new System.Drawing.Size(187, 44);
            this.lCursos.TabIndex = 7;
            this.lCursos.Text = "Mis Cursos";
            // 
            // bAtras
            // 
            this.bAtras.AutoSize = true;
            this.bAtras.Image = ((System.Drawing.Image)(resources.GetObject("bAtras.Image")));
            this.bAtras.Location = new System.Drawing.Point(25, 294);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(119, 132);
            this.bAtras.TabIndex = 8;
            this.bAtras.Text = "bAtras";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.AutoGenerateColumns = false;
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvMisCursos.DataSource = this.cursoBindingSource1;
            this.dgvMisCursos.Location = new System.Drawing.Point(55, 496);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.RowHeadersWidth = 62;
            this.dgvMisCursos.RowTemplate.Height = 28;
            this.dgvMisCursos.Size = new System.Drawing.Size(1352, 300);
            this.dgvMisCursos.TabIndex = 9;
            this.dgvMisCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisCursos_CellContentClick);
            // 
            // bAccesoForo
            // 
            this.bAccesoForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAccesoForo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccesoForo.Location = new System.Drawing.Point(97, 871);
            this.bAccesoForo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAccesoForo.Name = "bAccesoForo";
            this.bAccesoForo.Size = new System.Drawing.Size(272, 64);
            this.bAccesoForo.TabIndex = 10;
            this.bAccesoForo.Text = "Acceder Al Foro";
            this.bAccesoForo.UseVisualStyleBackColor = false;
            // 
            // bEventos
            // 
            this.bEventos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEventos.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(479, 871);
            this.bEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(272, 64);
            this.bEventos.TabIndex = 11;
            this.bEventos.Text = "Eventos Inscritos";
            this.bEventos.UseVisualStyleBackColor = false;
            this.bEventos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrearCurso.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearCurso.Location = new System.Drawing.Point(850, 871);
            this.bCrearCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(272, 64);
            this.bCrearCurso.TabIndex = 12;
            this.bCrearCurso.Text = "Crear Curso";
            this.bCrearCurso.UseVisualStyleBackColor = false;
            // 
            // bBasura
            // 
            this.bBasura.AutoSize = true;
            this.bBasura.Image = ((System.Drawing.Image)(resources.GetObject("bBasura.Image")));
            this.bBasura.Location = new System.Drawing.Point(1274, 829);
            this.bBasura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBasura.Name = "bBasura";
            this.bBasura.Size = new System.Drawing.Size(119, 132);
            this.bBasura.TabIndex = 13;
            this.bBasura.UseVisualStyleBackColor = true;
            this.bBasura.Click += new System.EventHandler(this.bBasura_Click);
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apsgrupo02DataSetBindingSource
            // 
            this.apsgrupo02DataSetBindingSource.DataSource = this.apsgrupo02DataSet;
            this.apsgrupo02DataSetBindingSource.Position = 0;
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
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.apsgrupo02DataSetBindingSource;
            // 
            // PantallaBorrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.bBasura);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.bEventos);
            this.Controls.Add(this.bAccesoForo);
            this.Controls.Add(this.dgvMisCursos);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.lCursos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaBorrarCurso";
            this.Text = "PantallaBorrarCurso";
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPcsas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lProfesor;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label lHola;
        private System.Windows.Forms.Label lMiPerfil;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbPcsas;
        private System.Windows.Forms.Label lCursos;
        private System.Windows.Forms.Button bAtras;
        private System.Windows.Forms.DataGridView dgvMisCursos;
        private System.Windows.Forms.Button bAccesoForo;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bBasura;
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
        private System.Windows.Forms.BindingSource cursoBindingSource1;
    }
}