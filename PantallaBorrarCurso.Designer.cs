
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
            this.dgvMisCursos = new System.Windows.Forms.DataGridView();
            this.cursoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.bAccesoForo = new System.Windows.Forms.Button();
            this.bEventos = new System.Windows.Forms.Button();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.CursoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPcsas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 221);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lProfesor
            // 
            this.lProfesor.AutoSize = true;
            this.lProfesor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesor.Location = new System.Drawing.Point(967, 150);
            this.lProfesor.Name = "lProfesor";
            this.lProfesor.Size = new System.Drawing.Size(86, 26);
            this.lProfesor.TabIndex = 6;
            this.lProfesor.Text = "Profesor";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(913, 150);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(47, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Rol:";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(751, 86);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(311, 46);
            this.lNombreApellidos.TabIndex = 4;
            this.lNombreApellidos.Text = "Nombre Apellidos";
            // 
            // lHola
            // 
            this.lHola.AutoSize = true;
            this.lHola.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHola.Location = new System.Drawing.Point(643, 86);
            this.lHola.Name = "lHola";
            this.lHola.Size = new System.Drawing.Size(108, 46);
            this.lHola.TabIndex = 3;
            this.lHola.Text = "Hola,";
            this.lHola.Click += new System.EventHandler(this.label1_Click);
            // 
            // lMiPerfil
            // 
            this.lMiPerfil.AutoSize = true;
            this.lMiPerfil.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiPerfil.Location = new System.Drawing.Point(1151, 178);
            this.lMiPerfil.Name = "lMiPerfil";
            this.lMiPerfil.Size = new System.Drawing.Size(88, 26);
            this.lMiPerfil.TabIndex = 2;
            this.lMiPerfil.Text = "Mi perfil";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Grupo02PCSAS.Properties.Resources._16363;
            this.pbUsuario.ImageLocation = "C:\\Users\\Javi\\Source\\Repos\\xmariia55x\\Grupo02PCSAS\\Resources\\usuario.png";
            this.pbUsuario.Location = new System.Drawing.Point(1135, 43);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(128, 121);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // pbPcsas
            // 
            this.pbPcsas.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pbPcsas.ImageLocation = "E:\\Fotos\\pcsas.JPEG";
            this.pbPcsas.Location = new System.Drawing.Point(-12, 3);
            this.pbPcsas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPcsas.Name = "pbPcsas";
            this.pbPcsas.Size = new System.Drawing.Size(245, 217);
            this.pbPcsas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPcsas.TabIndex = 0;
            this.pbPcsas.TabStop = false;
            this.pbPcsas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lCursos
            // 
            this.lCursos.AutoSize = true;
            this.lCursos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCursos.Location = new System.Drawing.Point(553, 265);
            this.lCursos.Name = "lCursos";
            this.lCursos.Size = new System.Drawing.Size(154, 38);
            this.lCursos.TabIndex = 7;
            this.lCursos.Text = "Mis Cursos";
            // 
            // dgvMisCursos
            // 
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Location = new System.Drawing.Point(49, 397);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.RowHeadersWidth = 62;
            this.dgvMisCursos.RowTemplate.Height = 28;
            this.dgvMisCursos.Size = new System.Drawing.Size(1202, 240);
            this.dgvMisCursos.TabIndex = 9;
            this.dgvMisCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisCursos_CellContentClick);
            this.dgvMisCursos.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cursoBindingSource1
            // 
            this.cursoBindingSource1.DataMember = "Curso";
            this.cursoBindingSource1.DataSource = this.apsgrupo02DataSetBindingSource;
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
            // bAccesoForo
            // 
            this.bAccesoForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAccesoForo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccesoForo.Location = new System.Drawing.Point(86, 697);
            this.bAccesoForo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAccesoForo.Name = "bAccesoForo";
            this.bAccesoForo.Size = new System.Drawing.Size(242, 51);
            this.bAccesoForo.TabIndex = 10;
            this.bAccesoForo.Text = "Acceder Al Foro";
            this.bAccesoForo.UseVisualStyleBackColor = false;
            this.bAccesoForo.Click += new System.EventHandler(this.bAccesoForo_Click);
            // 
            // bEventos
            // 
            this.bEventos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEventos.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(426, 697);
            this.bEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(242, 51);
            this.bEventos.TabIndex = 11;
            this.bEventos.Text = "Eventos Inscritos";
            this.bEventos.UseVisualStyleBackColor = false;
            this.bEventos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrearCurso.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearCurso.Location = new System.Drawing.Point(756, 697);
            this.bCrearCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(242, 51);
            this.bCrearCurso.TabIndex = 12;
            this.bCrearCurso.Text = "Crear Curso";
            this.bCrearCurso.UseVisualStyleBackColor = false;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.basura;
            this.pictureBox1.Location = new System.Drawing.Point(1132, 678);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.bBasura_Click);
            // 
            // bAtras
            // 
            this.bAtras.AutoSize = true;
            this.bAtras.Image = ((System.Drawing.Image)(resources.GetObject("bAtras.Image")));
            this.bAtras.Location = new System.Drawing.Point(22, 235);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(106, 106);
            this.bAtras.TabIndex = 8;
            this.bAtras.Text = "bAtras";
            this.bAtras.UseVisualStyleBackColor = true;
            // 
            // PantallaBorrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1302, 819);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.BindingSource apsgrupo02DataSetBindingSource;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private apsgrupo02DataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}