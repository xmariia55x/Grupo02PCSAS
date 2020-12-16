
namespace Grupo02PCSAS
{
    partial class fPantallaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPantallaAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.correoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseniaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.bCrearActividad = new System.Windows.Forms.Button();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.UsuarioTableAdapter();
            this.bBorrarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 301);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1390, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.ImageLocation = "C:\\Users\\maria\\OneDrive - Universidad de Málaga\\UNIVERSIDAD\\Tercer año\\1er cuatri" +
    "mestre\\Ingeniería de requisitos\\Proyecto";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hola,";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(867, 125);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(191, 57);
            this.lNombre.TabIndex = 13;
            this.lNombre.Text = "NOMBRE";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.lRol.Location = new System.Drawing.Point(790, 219);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(81, 27);
            this.lRol.TabIndex = 16;
            this.lRol.Text = "TU ROL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label2.Location = new System.Drawing.Point(739, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F);
            this.label4.Location = new System.Drawing.Point(1418, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mi perfil";
            this.label4.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 57);
            this.label5.TabIndex = 49;
            this.label5.Text = "USUARIOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correoUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.contraseniaUsuarioDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.niuDataGridViewTextBoxColumn,
            this.rolUsuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 522);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 425);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // correoUsuarioDataGridViewTextBoxColumn
            // 
            this.correoUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "correoUsuario";
            this.correoUsuarioDataGridViewTextBoxColumn.HeaderText = "Correo usuario";
            this.correoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.correoUsuarioDataGridViewTextBoxColumn.Name = "correoUsuarioDataGridViewTextBoxColumn";
            this.correoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniaUsuarioDataGridViewTextBoxColumn
            // 
            this.contraseniaUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contraseniaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "contraseniaUsuario";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.HeaderText = "contraseniaUsuario";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contraseniaUsuarioDataGridViewTextBoxColumn.Name = "contraseniaUsuarioDataGridViewTextBoxColumn";
            this.contraseniaUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraseniaUsuarioDataGridViewTextBoxColumn.Visible = false;
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
            this.rolUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rolUsuarioDataGridViewTextBoxColumn.DataPropertyName = "rolUsuario";
            this.rolUsuarioDataGridViewTextBoxColumn.HeaderText = "rolUsuario";
            this.rolUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rolUsuarioDataGridViewTextBoxColumn.Name = "rolUsuarioDataGridViewTextBoxColumn";
            this.rolUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.rolUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.apsgrupo02DataSetBindingSource;
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
            // bCrearActividad
            // 
            this.bCrearActividad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrearActividad.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearActividad.Location = new System.Drawing.Point(376, 1062);
            this.bCrearActividad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bCrearActividad.Name = "bCrearActividad";
            this.bCrearActividad.Size = new System.Drawing.Size(376, 106);
            this.bCrearActividad.TabIndex = 51;
            this.bCrearActividad.Text = "Crear Actividad";
            this.bCrearActividad.UseVisualStyleBackColor = false;
            this.bCrearActividad.Click += new System.EventHandler(this.bCrearActividad_Click);
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCrearCurso.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearCurso.Location = new System.Drawing.Point(928, 1062);
            this.bCrearCurso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(376, 106);
            this.bCrearCurso.TabIndex = 52;
            this.bCrearCurso.Text = "Crear Curso";
            this.bCrearCurso.UseVisualStyleBackColor = false;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // bBorrarUsuario
            // 
            this.bBorrarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBorrarUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrarUsuario.Location = new System.Drawing.Point(1394, 626);
            this.bBorrarUsuario.Name = "bBorrarUsuario";
            this.bBorrarUsuario.Size = new System.Drawing.Size(211, 84);
            this.bBorrarUsuario.TabIndex = 53;
            this.bBorrarUsuario.Text = "Borrar Usuario";
            this.bBorrarUsuario.UseVisualStyleBackColor = false;
            this.bBorrarUsuario.Click += new System.EventHandler(this.bBorrarUsuario_Click);
            // 
            // fPantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1648, 1210);
            this.Controls.Add(this.bBorrarUsuario);
            this.Controls.Add(this.bCrearCurso);
            this.Controls.Add(this.bCrearActividad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fPantallaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.fPantallaAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCrearActividad;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.BindingSource apsgrupo02DataSetBindingSource;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private apsgrupo02DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseniaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bBorrarUsuario;
    }
}