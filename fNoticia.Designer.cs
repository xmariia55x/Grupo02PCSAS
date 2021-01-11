
namespace Grupo02PCSAS
{
    partial class fNoticia
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNoticias = new System.Windows.Forms.DataGridView();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuerpoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noticiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet1 = new Grupo02PCSAS.apsgrupo02DataSet1();
            this.bInfNot = new System.Windows.Forms.Button();
            this.bDelNot = new System.Windows.Forms.Button();
            this.bAddNoticia = new System.Windows.Forms.Button();
            this.apsgrupo02DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noticiasTableAdapter = new Grupo02PCSAS.apsgrupo02DataSet1TableAdapters.NoticiasTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1631, 221);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1296, 158);
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
            this.pictureBox2.Location = new System.Drawing.Point(1277, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lRol
            // 
            this.lRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(737, 145);
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
            this.label2.Location = new System.Drawing.Point(671, 145);
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
            this.lNombreUser.Location = new System.Drawing.Point(799, 48);
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
            this.label3.Location = new System.Drawing.Point(666, 48);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F);
            this.label1.Location = new System.Drawing.Point(640, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOTICIAS";
            // 
            // dgvNoticias
            // 
            this.dgvNoticias.AllowUserToAddRows = false;
            this.dgvNoticias.AllowUserToDeleteRows = false;
            this.dgvNoticias.AllowUserToOrderColumns = true;
            this.dgvNoticias.AutoGenerateColumns = false;
            this.dgvNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoticias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.cuerpoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvNoticias.DataSource = this.noticiasBindingSource;
            this.dgvNoticias.Location = new System.Drawing.Point(195, 327);
            this.dgvNoticias.Name = "dgvNoticias";
            this.dgvNoticias.ReadOnly = true;
            this.dgvNoticias.RowHeadersWidth = 62;
            this.dgvNoticias.RowTemplate.Height = 28;
            this.dgvNoticias.Size = new System.Drawing.Size(1013, 316);
            this.dgvNoticias.TabIndex = 24;
            this.dgvNoticias.SelectionChanged += new System.EventHandler(this.dgvNoticias_SelectionChanged);
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuerpoDataGridViewTextBoxColumn
            // 
            this.cuerpoDataGridViewTextBoxColumn.DataPropertyName = "cuerpo";
            this.cuerpoDataGridViewTextBoxColumn.HeaderText = "cuerpo";
            this.cuerpoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cuerpoDataGridViewTextBoxColumn.Name = "cuerpoDataGridViewTextBoxColumn";
            this.cuerpoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuerpoDataGridViewTextBoxColumn.Visible = false;
            this.cuerpoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha creación";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 154;
            // 
            // noticiasBindingSource
            // 
            this.noticiasBindingSource.DataMember = "Noticias";
            this.noticiasBindingSource.DataSource = this.apsgrupo02DataSet1;
            // 
            // apsgrupo02DataSet1
            // 
            this.apsgrupo02DataSet1.DataSetName = "apsgrupo02DataSet1";
            this.apsgrupo02DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bInfNot
            // 
            this.bInfNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bInfNot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfNot.Font = new System.Drawing.Font("Trebuchet MS", 10.8F);
            this.bInfNot.Location = new System.Drawing.Point(1319, 272);
            this.bInfNot.Name = "bInfNot";
            this.bInfNot.Size = new System.Drawing.Size(175, 80);
            this.bInfNot.TabIndex = 25;
            this.bInfNot.Text = "Info Noticia";
            this.bInfNot.UseVisualStyleBackColor = false;
            this.bInfNot.Click += new System.EventHandler(this.bInfNot_Click);
            // 
            // bDelNot
            // 
            this.bDelNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelNot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelNot.Font = new System.Drawing.Font("Trebuchet MS", 10.8F);
            this.bDelNot.Location = new System.Drawing.Point(1319, 393);
            this.bDelNot.Name = "bDelNot";
            this.bDelNot.Size = new System.Drawing.Size(175, 79);
            this.bDelNot.TabIndex = 26;
            this.bDelNot.Text = "Eliminar Noticia";
            this.bDelNot.UseVisualStyleBackColor = false;
            this.bDelNot.Click += new System.EventHandler(this.bDelNot_Click);
            // 
            // bAddNoticia
            // 
            this.bAddNoticia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddNoticia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddNoticia.Font = new System.Drawing.Font("Trebuchet MS", 10.8F);
            this.bAddNoticia.Location = new System.Drawing.Point(1319, 514);
            this.bAddNoticia.Name = "bAddNoticia";
            this.bAddNoticia.Size = new System.Drawing.Size(179, 75);
            this.bAddNoticia.TabIndex = 27;
            this.bAddNoticia.Text = "Añadir Noticia";
            this.bAddNoticia.UseVisualStyleBackColor = false;
            this.bAddNoticia.Click += new System.EventHandler(this.bAddNoticia_Click);
            // 
            // apsgrupo02DataSet1BindingSource
            // 
            this.apsgrupo02DataSet1BindingSource.DataSource = this.apsgrupo02DataSet1;
            this.apsgrupo02DataSet1BindingSource.Position = 0;
            // 
            // noticiasTableAdapter
            // 
            this.noticiasTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(12, 231);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // fNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1631, 672);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bAddNoticia);
            this.Controls.Add(this.bDelNot);
            this.Controls.Add(this.bInfNot);
            this.Controls.Add(this.dgvNoticias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNoticia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fNoticia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoticias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noticiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNoticias;
        private System.Windows.Forms.Button bInfNot;
        private System.Windows.Forms.Button bDelNot;
        private System.Windows.Forms.Button bAddNoticia;
        private System.Windows.Forms.BindingSource apsgrupo02DataSet1BindingSource;
        private apsgrupo02DataSet1 apsgrupo02DataSet1;
        private System.Windows.Forms.BindingSource noticiasBindingSource;
        private apsgrupo02DataSet1TableAdapters.NoticiasTableAdapter noticiasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuerpoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}