﻿
namespace Grupo02PCSAS
{
    partial class fCrearActividadAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCrearActividadAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tNombreAct = new System.Windows.Forms.TextBox();
            this.tFechaIniAct = new System.Windows.Forms.TextBox();
            this.tFechaFinAct = new System.Windows.Forms.TextBox();
            this.tHoraIniAct = new System.Windows.Forms.TextBox();
            this.tHoraFinAct = new System.Windows.Forms.TextBox();
            this.tLugarAct = new System.Windows.Forms.TextBox();
            this.tDescripcionAct = new System.Windows.Forms.TextBox();
            this.tAforoAct = new System.Windows.Forms.TextBox();
            this.bAniadirColaboradorAct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bGuardarCambiosAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Beige;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "C:\\Users\\maria\\OneDrive - Universidad de Málaga\\UNIVERSIDAD\\Tercer año\\1er cuatri" +
    "mestre\\Ingeniería de requisitos\\Proyecto";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Actividad";
            // 
            // tNombreAct
            // 
            this.tNombreAct.Location = new System.Drawing.Point(172, 480);
            this.tNombreAct.Name = "tNombreAct";
            this.tNombreAct.Size = new System.Drawing.Size(218, 22);
            this.tNombreAct.TabIndex = 2;
            this.tNombreAct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tFechaIniAct
            // 
            this.tFechaIniAct.Location = new System.Drawing.Point(657, 480);
            this.tFechaIniAct.Name = "tFechaIniAct";
            this.tFechaIniAct.Size = new System.Drawing.Size(218, 22);
            this.tFechaIniAct.TabIndex = 3;
            // 
            // tFechaFinAct
            // 
            this.tFechaFinAct.Location = new System.Drawing.Point(657, 585);
            this.tFechaFinAct.Name = "tFechaFinAct";
            this.tFechaFinAct.Size = new System.Drawing.Size(218, 22);
            this.tFechaFinAct.TabIndex = 4;
            // 
            // tHoraIniAct
            // 
            this.tHoraIniAct.Location = new System.Drawing.Point(1105, 480);
            this.tHoraIniAct.Name = "tHoraIniAct";
            this.tHoraIniAct.Size = new System.Drawing.Size(218, 22);
            this.tHoraIniAct.TabIndex = 5;
            // 
            // tHoraFinAct
            // 
            this.tHoraFinAct.Location = new System.Drawing.Point(1105, 585);
            this.tHoraFinAct.Name = "tHoraFinAct";
            this.tHoraFinAct.Size = new System.Drawing.Size(218, 22);
            this.tHoraFinAct.TabIndex = 6;
            // 
            // tLugarAct
            // 
            this.tLugarAct.Location = new System.Drawing.Point(657, 682);
            this.tLugarAct.Name = "tLugarAct";
            this.tLugarAct.Size = new System.Drawing.Size(218, 22);
            this.tLugarAct.TabIndex = 7;
            // 
            // tDescripcionAct
            // 
            this.tDescripcionAct.Location = new System.Drawing.Point(172, 585);
            this.tDescripcionAct.Multiline = true;
            this.tDescripcionAct.Name = "tDescripcionAct";
            this.tDescripcionAct.Size = new System.Drawing.Size(218, 151);
            this.tDescripcionAct.TabIndex = 8;
            // 
            // tAforoAct
            // 
            this.tAforoAct.Location = new System.Drawing.Point(1105, 682);
            this.tAforoAct.Name = "tAforoAct";
            this.tAforoAct.Size = new System.Drawing.Size(218, 22);
            this.tAforoAct.TabIndex = 9;
            // 
            // bAniadirColaboradorAct
            // 
            this.bAniadirColaboradorAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAniadirColaboradorAct.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAniadirColaboradorAct.Location = new System.Drawing.Point(172, 760);
            this.bAniadirColaboradorAct.Name = "bAniadirColaboradorAct";
            this.bAniadirColaboradorAct.Size = new System.Drawing.Size(132, 79);
            this.bAniadirColaboradorAct.TabIndex = 10;
            this.bAniadirColaboradorAct.Text = "Añadir colaborador";
            this.bAniadirColaboradorAct.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Breve descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre actividad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de inicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de finalización";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lugar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1100, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora de inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1100, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Hora de finalización";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1100, 643);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Aforo";
            // 
            // bGuardarCambiosAct
            // 
            this.bGuardarCambiosAct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGuardarCambiosAct.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardarCambiosAct.Location = new System.Drawing.Point(677, 768);
            this.bGuardarCambiosAct.Name = "bGuardarCambiosAct";
            this.bGuardarCambiosAct.Size = new System.Drawing.Size(181, 63);
            this.bGuardarCambiosAct.TabIndex = 19;
            this.bGuardarCambiosAct.Text = "Guardar cambios";
            this.bGuardarCambiosAct.UseVisualStyleBackColor = false;
            // 
            // fCrearActividadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1469, 1033);
            this.Controls.Add(this.bGuardarCambiosAct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAniadirColaboradorAct);
            this.Controls.Add(this.tAforoAct);
            this.Controls.Add(this.tDescripcionAct);
            this.Controls.Add(this.tLugarAct);
            this.Controls.Add(this.tHoraFinAct);
            this.Controls.Add(this.tHoraIniAct);
            this.Controls.Add(this.tFechaFinAct);
            this.Controls.Add(this.tFechaIniAct);
            this.Controls.Add(this.tNombreAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fCrearActividadAdmin";
            this.Text = "fCrearActividadAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNombreAct;
        private System.Windows.Forms.TextBox tFechaIniAct;
        private System.Windows.Forms.TextBox tFechaFinAct;
        private System.Windows.Forms.TextBox tHoraIniAct;
        private System.Windows.Forms.TextBox tHoraFinAct;
        private System.Windows.Forms.TextBox tLugarAct;
        private System.Windows.Forms.TextBox tDescripcionAct;
        private System.Windows.Forms.TextBox tAforoAct;
        private System.Windows.Forms.Button bAniadirColaboradorAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bGuardarCambiosAct;
    }
}