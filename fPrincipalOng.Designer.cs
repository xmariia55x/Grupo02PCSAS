namespace Grupo02PCSAS
{
    partial class fPrincipalOng
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
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bEventos = new System.Windows.Forms.Button();
            this.bAccederAlForo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.actividadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet = new Grupo02PCSAS.apsgrupo02DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.bInformacion = new System.Windows.Forms.Button();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadTableAdapter = new Grupo02PCSAS.apsgrupo02DataSetTableAdapters.ActividadTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 177);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1176, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1157, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(888, 114);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(621, 39);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(346, 44);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bEventos
            // 
            this.bEventos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEventos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEventos.Location = new System.Drawing.Point(850, 692);
            this.bEventos.Name = "bEventos";
            this.bEventos.Size = new System.Drawing.Size(181, 63);
            this.bEventos.TabIndex = 55;
            this.bEventos.Text = "Eventos";
            this.bEventos.UseVisualStyleBackColor = false;
            this.bEventos.Click += new System.EventHandler(this.bEventos_Click);
            // 
            // bAccederAlForo
            // 
            this.bAccederAlForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAccederAlForo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccederAlForo.Location = new System.Drawing.Point(155, 692);
            this.bAccederAlForo.Name = "bAccederAlForo";
            this.bAccederAlForo.Size = new System.Drawing.Size(181, 63);
            this.bAccederAlForo.TabIndex = 54;
            this.bAccederAlForo.Text = "Acceder al foro";
            this.bAccederAlForo.UseVisualStyleBackColor = false;
            this.bAccederAlForo.Click += new System.EventHandler(this.bAccederAlForo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.actividadBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(113, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 319);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.nombreActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreActividadDataGridViewTextBoxColumn.Width = 87;
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
            this.lugarActividadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lugarActividadDataGridViewTextBoxColumn.DataPropertyName = "lugarActividad";
            this.lugarActividadDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarActividadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lugarActividadDataGridViewTextBoxColumn.Name = "lugarActividadDataGridViewTextBoxColumn";
            this.lugarActividadDataGridViewTextBoxColumn.ReadOnly = true;
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
            // actividadBindingSource1
            // 
            this.actividadBindingSource1.DataMember = "Actividad";
            this.actividadBindingSource1.DataSource = this.apsgrupo02DataSet;
            // 
            // apsgrupo02DataSet
            // 
            this.apsgrupo02DataSet.DataSetName = "apsgrupo02DataSet";
            this.apsgrupo02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 49);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mis actividades";
            // 
            // bInformacion
            // 
            this.bInformacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInformacion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInformacion.Location = new System.Drawing.Point(1105, 469);
            this.bInformacion.Name = "bInformacion";
            this.bInformacion.Size = new System.Drawing.Size(181, 63);
            this.bInformacion.TabIndex = 56;
            this.bInformacion.Text = "Información";
            this.bInformacion.UseVisualStyleBackColor = false;
            this.bInformacion.Click += new System.EventHandler(this.bInformacion_Click);
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.apsgrupo02DataSet;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // fPrincipalOng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1302, 819);
            this.Controls.Add(this.bInformacion);
            this.Controls.Add(this.bEventos);
            this.Controls.Add(this.bAccederAlForo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "fPrincipalOng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidad";
            this.Load += new System.EventHandler(this.fPrincipalOng_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bEventos;
        private System.Windows.Forms.Button bAccederAlForo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bInformacion;
        private apsgrupo02DataSet apsgrupo02DataSet;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private apsgrupo02DataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.BindingSource actividadBindingSource1;
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
    }
}