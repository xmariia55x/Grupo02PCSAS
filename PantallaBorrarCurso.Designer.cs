
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreApellidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.dgvMisCursos.AllowUserToAddRows = false;
            this.dgvMisCursos.AllowUserToDeleteRows = false;
            this.dgvMisCursos.AllowUserToOrderColumns = true;
            this.dgvMisCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisCursos.Location = new System.Drawing.Point(49, 397);
            this.dgvMisCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisCursos.Name = "dgvMisCursos";
            this.dgvMisCursos.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombreApellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 177);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1153, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            this.label5.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1135, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(551, 116);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
            // 
            // lNombreApellidos
            // 
            this.lNombreApellidos.AutoSize = true;
            this.lNombreApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidos.Location = new System.Drawing.Point(621, 39);
            this.lNombreApellidos.Name = "lNombreApellidos";
            this.lNombreApellidos.Size = new System.Drawing.Size(346, 44);
            this.lNombreApellidos.TabIndex = 3;
            this.lNombreApellidos.Text = "Nombre y apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hola,";
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
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox4.Location = new System.Drawing.Point(94, 227);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // PantallaBorrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1302, 819);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.bEventos);
            this.Controls.Add(this.bAccesoForo);
            this.Controls.Add(this.dgvMisCursos);
            this.Controls.Add(this.lCursos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaBorrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lCursos;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}