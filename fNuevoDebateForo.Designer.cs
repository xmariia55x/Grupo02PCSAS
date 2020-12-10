namespace Grupo02PCSAS
{
    partial class fNuevoDebateForo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lRolUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNombreApellidosUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lForo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tAsuntoDebate = new System.Windows.Forms.TextBox();
            this.tMensajeDebate = new System.Windows.Forms.TextBox();
            this.bEnviarDebate = new System.Windows.Forms.Button();
            this.bCancelarDebate = new System.Windows.Forms.Button();
            this.bAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lRolUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lNombreApellidosUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 217);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grupo02PCSAS.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(1300, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1314, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mi perfil";
            // 
            // lRolUsuario
            // 
            this.lRolUsuario.AutoSize = true;
            this.lRolUsuario.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRolUsuario.Location = new System.Drawing.Point(1004, 146);
            this.lRolUsuario.Name = "lRolUsuario";
            this.lRolUsuario.Size = new System.Drawing.Size(73, 29);
            this.lRolUsuario.TabIndex = 5;
            this.lRolUsuario.Text = "Tu rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(954, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol: ";
            // 
            // lNombreApellidosUsuario
            // 
            this.lNombreApellidosUsuario.AutoSize = true;
            this.lNombreApellidosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreApellidosUsuario.Location = new System.Drawing.Point(699, 49);
            this.lNombreApellidosUsuario.Name = "lNombreApellidosUsuario";
            this.lNombreApellidosUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lNombreApellidosUsuario.Size = new System.Drawing.Size(408, 52);
            this.lNombreApellidosUsuario.TabIndex = 3;
            this.lNombreApellidosUsuario.Text = "Nombre y apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hola,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.pcsas;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lForo
            // 
            this.lForo.AutoSize = true;
            this.lForo.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForo.Location = new System.Drawing.Point(709, 280);
            this.lForo.Name = "lForo";
            this.lForo.Size = new System.Drawing.Size(133, 55);
            this.lForo.TabIndex = 8;
            this.lForo.Text = "FORO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(687, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "NUEVO DEBATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Asunto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mensaje";
            // 
            // tAsuntoDebate
            // 
            this.tAsuntoDebate.Location = new System.Drawing.Point(282, 486);
            this.tAsuntoDebate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tAsuntoDebate.Multiline = true;
            this.tAsuntoDebate.Name = "tAsuntoDebate";
            this.tAsuntoDebate.Size = new System.Drawing.Size(965, 66);
            this.tAsuntoDebate.TabIndex = 12;
            // 
            // tMensajeDebate
            // 
            this.tMensajeDebate.Location = new System.Drawing.Point(282, 659);
            this.tMensajeDebate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tMensajeDebate.Multiline = true;
            this.tMensajeDebate.Name = "tMensajeDebate";
            this.tMensajeDebate.Size = new System.Drawing.Size(965, 168);
            this.tMensajeDebate.TabIndex = 13;
            // 
            // bEnviarDebate
            // 
            this.bEnviarDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEnviarDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviarDebate.Location = new System.Drawing.Point(550, 888);
            this.bEnviarDebate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEnviarDebate.Name = "bEnviarDebate";
            this.bEnviarDebate.Size = new System.Drawing.Size(204, 79);
            this.bEnviarDebate.TabIndex = 14;
            this.bEnviarDebate.Text = "Enviar al foro";
            this.bEnviarDebate.UseVisualStyleBackColor = false;
            this.bEnviarDebate.Click += new System.EventHandler(this.bEnviarDebate_Click);
            // 
            // bCancelarDebate
            // 
            this.bCancelarDebate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelarDebate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelarDebate.Location = new System.Drawing.Point(858, 888);
            this.bCancelarDebate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCancelarDebate.Name = "bCancelarDebate";
            this.bCancelarDebate.Size = new System.Drawing.Size(204, 79);
            this.bCancelarDebate.TabIndex = 15;
            this.bCancelarDebate.Text = "Cancelar";
            this.bCancelarDebate.UseVisualStyleBackColor = false;
            this.bCancelarDebate.Click += new System.EventHandler(this.bCancelarDebate_Click);
            // 
            // bAtras
            // 
            this.bAtras.Image = global::Grupo02PCSAS.Properties.Resources.Atras;
            this.bAtras.Location = new System.Drawing.Point(69, 253);
            this.bAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAtras.Name = "bAtras";
            this.bAtras.Size = new System.Drawing.Size(100, 100);
            this.bAtras.TabIndex = 16;
            this.bAtras.UseVisualStyleBackColor = true;
            this.bAtras.Click += new System.EventHandler(this.bAtras_Click);
            // 
            // fNuevoDebateForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1465, 1024);
            this.Controls.Add(this.bAtras);
            this.Controls.Add(this.bCancelarDebate);
            this.Controls.Add(this.bEnviarDebate);
            this.Controls.Add(this.tMensajeDebate);
            this.Controls.Add(this.tAsuntoDebate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lForo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fNuevoDebateForo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del curso";
            this.Load += new System.EventHandler(this.fNuevoDebateForo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lNombreApellidosUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lRolUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lForo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tAsuntoDebate;
        private System.Windows.Forms.TextBox tMensajeDebate;
        private System.Windows.Forms.Button bEnviarDebate;
        private System.Windows.Forms.Button bCancelarDebate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bAtras;
    }
}