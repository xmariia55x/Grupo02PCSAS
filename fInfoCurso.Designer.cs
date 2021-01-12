using System;
using System.Windows.Forms;

namespace Grupo02PCSAS
{
    partial class fInfoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInfoCurso));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bAccederPruebaConocimiento = new System.Windows.Forms.Button();
            this.lValorar = new System.Windows.Forms.Label();
            this.bValorar = new System.Windows.Forms.Button();
            this.dgvDescargas = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lHoraF = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.lHoraInicio = new System.Windows.Forms.Label();
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lLugar = new System.Windows.Forms.Label();
            this.lPlazasTotales = new System.Windows.Forms.Label();
            this.lPlazasDisp = new System.Windows.Forms.Label();
            this.lNombreProf = new System.Windows.Forms.Label();
            this.lHoraFin = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lProfesor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lInscrito = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lNombreCurso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lRol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescargas)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.bAccederPruebaConocimiento);
            this.panel5.Controls.Add(this.lValorar);
            this.panel5.Controls.Add(this.bValorar);
            this.panel5.Controls.Add(this.dgvDescargas);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Location = new System.Drawing.Point(0, 651);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1649, 481);
            this.panel5.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1186, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prueba de conocimiento";
            // 
            // bAccederPruebaConocimiento
            // 
            this.bAccederPruebaConocimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAccederPruebaConocimiento.BackColor = System.Drawing.Color.White;
            this.bAccederPruebaConocimiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAccederPruebaConocimiento.BackgroundImage")));
            this.bAccederPruebaConocimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAccederPruebaConocimiento.Location = new System.Drawing.Point(1114, 108);
            this.bAccederPruebaConocimiento.Name = "bAccederPruebaConocimiento";
            this.bAccederPruebaConocimiento.Size = new System.Drawing.Size(67, 60);
            this.bAccederPruebaConocimiento.TabIndex = 17;
            this.bAccederPruebaConocimiento.UseVisualStyleBackColor = false;
            this.bAccederPruebaConocimiento.Click += new System.EventHandler(this.bAccederPruebaConocimiento_Click);
            // 
            // lValorar
            // 
            this.lValorar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lValorar.AutoSize = true;
            this.lValorar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValorar.Location = new System.Drawing.Point(1187, 45);
            this.lValorar.Name = "lValorar";
            this.lValorar.Size = new System.Drawing.Size(131, 26);
            this.lValorar.TabIndex = 16;
            this.lValorar.Text = "Valorar curso";
            // 
            // bValorar
            // 
            this.bValorar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bValorar.BackColor = System.Drawing.Color.White;
            this.bValorar.BackgroundImage = global::Grupo02PCSAS.Properties.Resources.estrella;
            this.bValorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bValorar.Location = new System.Drawing.Point(1114, 30);
            this.bValorar.Name = "bValorar";
            this.bValorar.Size = new System.Drawing.Size(67, 60);
            this.bValorar.TabIndex = 5;
            this.bValorar.UseVisualStyleBackColor = false;
            this.bValorar.Click += new System.EventHandler(this.bValorar_Click);
            // 
            // dgvDescargas
            // 
            this.dgvDescargas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDescargas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescargas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescargas.Location = new System.Drawing.Point(460, 70);
            this.dgvDescargas.Name = "dgvDescargas";
            this.dgvDescargas.RowHeadersWidth = 62;
            this.dgvDescargas.RowTemplate.Height = 28;
            this.dgvDescargas.Size = new System.Drawing.Size(412, 129);
            this.dgvDescargas.TabIndex = 4;
            this.dgvDescargas.SelectionChanged += new System.EventHandler(this.dgvDescargas_SelectionChanged);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(596, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(211, 26);
            this.label20.TabIndex = 2;
            this.label20.Text = "ARCHIVOS Y ENLACES";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lHoraF);
            this.panel4.Controls.Add(this.lFechaFin);
            this.panel4.Controls.Add(this.lHoraInicio);
            this.panel4.Controls.Add(this.lFechaInicio);
            this.panel4.Controls.Add(this.lLugar);
            this.panel4.Controls.Add(this.lPlazasTotales);
            this.panel4.Controls.Add(this.lPlazasDisp);
            this.panel4.Controls.Add(this.lNombreProf);
            this.panel4.Controls.Add(this.lHoraFin);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lProfesor);
            this.panel4.Location = new System.Drawing.Point(718, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 308);
            this.panel4.TabIndex = 10;
            // 
            // lHoraF
            // 
            this.lHoraF.AutoSize = true;
            this.lHoraF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoraF.Location = new System.Drawing.Point(455, 246);
            this.lHoraF.Name = "lHoraF";
            this.lHoraF.Size = new System.Drawing.Size(23, 26);
            this.lHoraF.TabIndex = 15;
            this.lHoraF.Text = "X";
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaFin.Location = new System.Drawing.Point(467, 182);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(23, 26);
            this.lFechaFin.TabIndex = 14;
            this.lFechaFin.Text = "X";
            // 
            // lHoraInicio
            // 
            this.lHoraInicio.AutoSize = true;
            this.lHoraInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoraInicio.Location = new System.Drawing.Point(484, 117);
            this.lHoraInicio.Name = "lHoraInicio";
            this.lHoraInicio.Size = new System.Drawing.Size(23, 26);
            this.lHoraInicio.TabIndex = 13;
            this.lHoraInicio.Text = "X";
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaInicio.Location = new System.Drawing.Point(497, 55);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(23, 26);
            this.lFechaInicio.TabIndex = 12;
            this.lFechaInicio.Text = "X";
            // 
            // lLugar
            // 
            this.lLugar.AutoSize = true;
            this.lLugar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLugar.Location = new System.Drawing.Point(110, 246);
            this.lLugar.Name = "lLugar";
            this.lLugar.Size = new System.Drawing.Size(23, 26);
            this.lLugar.TabIndex = 11;
            this.lLugar.Text = "X";
            // 
            // lPlazasTotales
            // 
            this.lPlazasTotales.AutoSize = true;
            this.lPlazasTotales.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlazasTotales.Location = new System.Drawing.Point(186, 182);
            this.lPlazasTotales.Name = "lPlazasTotales";
            this.lPlazasTotales.Size = new System.Drawing.Size(23, 26);
            this.lPlazasTotales.TabIndex = 10;
            this.lPlazasTotales.Text = "X";
            // 
            // lPlazasDisp
            // 
            this.lPlazasDisp.AutoSize = true;
            this.lPlazasDisp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlazasDisp.Location = new System.Drawing.Point(232, 117);
            this.lPlazasDisp.Name = "lPlazasDisp";
            this.lPlazasDisp.Size = new System.Drawing.Size(23, 26);
            this.lPlazasDisp.TabIndex = 9;
            this.lPlazasDisp.Text = "X";
            // 
            // lNombreProf
            // 
            this.lNombreProf.AutoSize = true;
            this.lNombreProf.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreProf.Location = new System.Drawing.Point(139, 55);
            this.lNombreProf.Name = "lNombreProf";
            this.lNombreProf.Size = new System.Drawing.Size(196, 26);
            this.lNombreProf.TabIndex = 8;
            this.lNombreProf.Text = "nombre del profesor";
            // 
            // lHoraFin
            // 
            this.lHoraFin.AutoSize = true;
            this.lHoraFin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHoraFin.Location = new System.Drawing.Point(356, 246);
            this.lHoraFin.Name = "lHoraFin";
            this.lHoraFin.Size = new System.Drawing.Size(94, 26);
            this.lHoraFin.TabIndex = 7;
            this.lHoraFin.Text = "Hora fin:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(356, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "Fecha fin:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(356, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 26);
            this.label18.TabIndex = 5;
            this.label18.Text = "Hora inicio:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(356, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 26);
            this.label19.TabIndex = 4;
            this.label19.Text = "Fecha inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 26);
            this.label15.TabIndex = 3;
            this.label15.Text = "Lugar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 26);
            this.label14.TabIndex = 2;
            this.label14.Text = "Plazas totales:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Plazas disponibles:";
            // 
            // lProfesor
            // 
            this.lProfesor.AutoSize = true;
            this.lProfesor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesor.Location = new System.Drawing.Point(34, 55);
            this.lProfesor.Name = "lProfesor";
            this.lProfesor.Size = new System.Drawing.Size(99, 26);
            this.lProfesor.TabIndex = 0;
            this.lProfesor.Text = "Profesor:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lDescripcion);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 308);
            this.panel3.TabIndex = 9;
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(42, 67);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(661, 231);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = resources.GetString("lDescripcion.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "BREVE DESCRIPCIÓN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lInscrito);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lNombreCurso);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 166);
            this.panel2.TabIndex = 8;
            // 
            // lInscrito
            // 
            this.lInscrito.AutoSize = true;
            this.lInscrito.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInscrito.Location = new System.Drawing.Point(1303, 67);
            this.lInscrito.Name = "lInscrito";
            this.lInscrito.Size = new System.Drawing.Size(80, 26);
            this.lInscrito.TabIndex = 6;
            this.lInscrito.Text = "Inscrito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1215, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "ESTADO:";
            // 
            // lNombreCurso
            // 
            this.lNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombreCurso.AutoSize = true;
            this.lNombreCurso.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreCurso.Location = new System.Drawing.Point(438, 51);
            this.lNombreCurso.Name = "lNombreCurso";
            this.lNombreCurso.Size = new System.Drawing.Size(171, 49);
            this.lNombreCurso.TabIndex = 4;
            this.lNombreCurso.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 49);
            this.label6.TabIndex = 3;
            this.label6.Text = "CURSO:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(8, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.panel1.Size = new System.Drawing.Size(1465, 178);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1349, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1338, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.Location = new System.Drawing.Point(639, 93);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(63, 26);
            this.lRol.TabIndex = 5;
            this.lRol.Text = "Tu rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
            // 
            // lNombreUser
            // 
            this.lNombreUser.AutoSize = true;
            this.lNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreUser.Location = new System.Drawing.Point(699, 30);
            this.lNombreUser.Name = "lNombreUser";
            this.lNombreUser.Size = new System.Drawing.Size(346, 44);
            this.lNombreUser.TabIndex = 3;
            this.lNombreUser.Text = "Nombre y apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 30);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Grupo02PCSAS.Properties.Resources.carpeta3;
            this.pictureBox4.Location = new System.Drawing.Point(677, 72);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // fInfoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fInfoCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fInfoCurso_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescargas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lHoraF;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.Label lHoraInicio;
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lLugar;
        private System.Windows.Forms.Label lPlazasTotales;
        private System.Windows.Forms.Label lPlazasDisp;
        private System.Windows.Forms.Label lNombreProf;
        private System.Windows.Forms.Label lHoraFin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lProfesor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lInscrito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lNombreCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDescargas;
        private PictureBox pictureBox4;
        private Button bValorar;
        private Label lValorar;
        private Label label3;
        private Button bAccederPruebaConocimiento;
    }
}