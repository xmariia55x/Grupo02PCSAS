﻿
namespace Grupo02PCSAS
{
    partial class PantallaPrincipalForo
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
            this.lForo = new System.Windows.Forms.Label();
            this.lDebates = new System.Windows.Forms.Label();
            this.dgvDebatesRecientes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apsgrupo02DataSet2 = new Grupo02PCSAS.apsgrupo02DataSet2();
            this.dgvMisDebates = new System.Windows.Forms.DataGridView();
            this.bAniadirDebate = new System.Windows.Forms.Button();
            this.bMisDebatesForo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bInfoDebate = new System.Windows.Forms.Button();
            this.debateTableAdapter = new Grupo02PCSAS.apsgrupo02DataSet2TableAdapters.DebateTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lForo
            // 
            this.lForo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(761, 220);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(111, 46);
            this.lForo.TabIndex = 7;
            this.lForo.Text = "FORO";
            // 
            // lDebates
            // 
            this.lDebates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDebates.AutoSize = true;
            this.lDebates.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDebates.Location = new System.Drawing.Point(701, 295);
            this.lDebates.Name = "lDebates";
            this.lDebates.Size = new System.Drawing.Size(237, 26);
            this.lDebates.TabIndex = 8;
            this.lDebates.Text = "Debates más recientes...";
            // 
            // dgvDebatesRecientes
            // 
            this.dgvDebatesRecientes.AllowUserToAddRows = false;
            this.dgvDebatesRecientes.AllowUserToDeleteRows = false;
            this.dgvDebatesRecientes.AllowUserToOrderColumns = true;
            this.dgvDebatesRecientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDebatesRecientes.AutoGenerateColumns = false;
            this.dgvDebatesRecientes.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvDebatesRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebatesRecientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.creadorDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.mensajeDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn});
            this.dgvDebatesRecientes.DataSource = this.debateBindingSource;
            this.dgvDebatesRecientes.Location = new System.Drawing.Point(465, 350);
            this.dgvDebatesRecientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDebatesRecientes.MultiSelect = false;
            this.dgvDebatesRecientes.Name = "dgvDebatesRecientes";
            this.dgvDebatesRecientes.ReadOnly = true;
            this.dgvDebatesRecientes.RowHeadersWidth = 62;
            this.dgvDebatesRecientes.RowTemplate.Height = 28;
            this.dgvDebatesRecientes.Size = new System.Drawing.Size(718, 418);
            this.dgvDebatesRecientes.TabIndex = 9;
            this.dgvDebatesRecientes.SelectionChanged += new System.EventHandler(this.dgvDebatesRecientes_SelectionChanged);
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
            this.creadorDataGridViewTextBoxColumn.Width = 88;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mensajeDataGridViewTextBoxColumn
            // 
            this.mensajeDataGridViewTextBoxColumn.DataPropertyName = "mensaje";
            this.mensajeDataGridViewTextBoxColumn.HeaderText = "mensaje";
            this.mensajeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensajeDataGridViewTextBoxColumn.Name = "mensajeDataGridViewTextBoxColumn";
            this.mensajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mensajeDataGridViewTextBoxColumn.Visible = false;
            this.mensajeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha inicio";
            this.fechaInicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaInicioDataGridViewTextBoxColumn.Width = 112;
            // 
            // debateBindingSource
            // 
            this.debateBindingSource.DataMember = "Debate";
            this.debateBindingSource.DataSource = this.apsgrupo02DataSet2;
            // 
            // apsgrupo02DataSet2
            // 
            this.apsgrupo02DataSet2.DataSetName = "apsgrupo02DataSet2";
            this.apsgrupo02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvMisDebates
            // 
            this.dgvMisDebates.AllowUserToAddRows = false;
            this.dgvMisDebates.AllowUserToDeleteRows = false;
            this.dgvMisDebates.AllowUserToOrderColumns = true;
            this.dgvMisDebates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvMisDebates.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvMisDebates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisDebates.Location = new System.Drawing.Point(41, 444);
            this.dgvMisDebates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMisDebates.MultiSelect = false;
            this.dgvMisDebates.Name = "dgvMisDebates";
            this.dgvMisDebates.ReadOnly = true;
            this.dgvMisDebates.RowHeadersWidth = 62;
            this.dgvMisDebates.RowTemplate.Height = 28;
            this.dgvMisDebates.Size = new System.Drawing.Size(257, 224);
            this.dgvMisDebates.TabIndex = 14;
            this.dgvMisDebates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bAniadirDebate
            // 
            this.bAniadirDebate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAniadirDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAniadirDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAniadirDebate.Location = new System.Drawing.Point(71, 705);
            this.bAniadirDebate.Name = "bAniadirDebate";
            this.bAniadirDebate.Size = new System.Drawing.Size(181, 63);
            this.bAniadirDebate.TabIndex = 15;
            this.bAniadirDebate.Text = "Nuevo debate";
            this.bAniadirDebate.UseVisualStyleBackColor = false;
            this.bAniadirDebate.Click += new System.EventHandler(this.bAniadirDebate_Click);
            // 
            // bMisDebatesForo
            // 
            this.bMisDebatesForo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bMisDebatesForo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMisDebatesForo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMisDebatesForo.Location = new System.Drawing.Point(71, 350);
            this.bMisDebatesForo.Name = "bMisDebatesForo";
            this.bMisDebatesForo.Size = new System.Drawing.Size(181, 63);
            this.bMisDebatesForo.TabIndex = 16;
            this.bMisDebatesForo.Text = "Mis debates";
            this.bMisDebatesForo.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(41, 220);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button1_Click);
            // 
            // bInfoDebate
            // 
            this.bInfoDebate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bInfoDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bInfoDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfoDebate.Location = new System.Drawing.Point(1224, 502);
            this.bInfoDebate.Name = "bInfoDebate";
            this.bInfoDebate.Size = new System.Drawing.Size(181, 63);
            this.bInfoDebate.TabIndex = 19;
            this.bInfoDebate.Text = "Info debate";
            this.bInfoDebate.UseVisualStyleBackColor = false;
            this.bInfoDebate.Click += new System.EventHandler(this.bInfoDebate_Click);
            // 
            // debateTableAdapter
            // 
            this.debateTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lRol);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lNombreUser);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1469, 177);
            this.panel2.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1171, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 26);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mi perfil";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1154, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
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
            this.lRol.Location = new System.Drawing.Point(674, 116);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(615, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 26);
            this.label14.TabIndex = 4;
            this.label14.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(729, 38);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(346, 44);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(611, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 49);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hola,";
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
            // PantallaPrincipalForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1469, 840);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bInfoDebate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bMisDebatesForo);
            this.Controls.Add(this.bAniadirDebate);
            this.Controls.Add(this.dgvMisDebates);
            this.Controls.Add(this.dgvDebatesRecientes);
            this.Controls.Add(this.lDebates);
            this.Controls.Add(this.lForo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipalForo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PantallaBorrarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebatesRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apsgrupo02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisDebates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lForo;
        private System.Windows.Forms.Label lDebates;
        private System.Windows.Forms.DataGridView dgvDebatesRecientes;
        private System.Windows.Forms.DataGridView dgvMisDebates;
        private System.Windows.Forms.Button bAniadirDebate;
        private System.Windows.Forms.Button bMisDebatesForo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bInfoDebate;
        private apsgrupo02DataSet2 apsgrupo02DataSet2;
        private System.Windows.Forms.BindingSource debateBindingSource;
        private apsgrupo02DataSet2TableAdapters.DebateTableAdapter debateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}