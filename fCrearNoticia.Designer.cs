
namespace Grupo02PCSAS
{
    partial class fCrearNoticia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCuerpo = new System.Windows.Forms.TextBox();
            this.bAddNot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Grupo02PCSAS.Properties.Resources.WhatsApp_Image_2020_12_06_at_17_27_26;
            this.pictureBox1.Location = new System.Drawing.Point(556, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Grupo02PCSAS.Properties.Resources._60577;
            this.pictureBox3.Location = new System.Drawing.Point(53, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 46);
            this.label1.TabIndex = 37;
            this.label1.Text = "Crear Noticia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Titulo noticia: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cuerpo noticia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 40;
            this.label4.Text = "Autor noticia: ";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTitulo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(372, 368);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(543, 31);
            this.tbTitulo.TabIndex = 41;
            // 
            // tbAutor
            // 
            this.tbAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAutor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAutor.Location = new System.Drawing.Point(372, 425);
            this.tbAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(543, 31);
            this.tbAutor.TabIndex = 42;
            // 
            // tbCuerpo
            // 
            this.tbCuerpo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCuerpo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuerpo.Location = new System.Drawing.Point(372, 482);
            this.tbCuerpo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCuerpo.Multiline = true;
            this.tbCuerpo.Name = "tbCuerpo";
            this.tbCuerpo.Size = new System.Drawing.Size(543, 202);
            this.tbCuerpo.TabIndex = 43;
            // 
            // bAddNot
            // 
            this.bAddNot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddNot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddNot.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddNot.Location = new System.Drawing.Point(532, 712);
            this.bAddNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAddNot.Name = "bAddNot";
            this.bAddNot.Size = new System.Drawing.Size(207, 43);
            this.bAddNot.TabIndex = 44;
            this.bAddNot.Text = "Crear noticia";
            this.bAddNot.UseVisualStyleBackColor = false;
            this.bAddNot.Click += new System.EventHandler(this.bAddNot_Click);
            // 
            // fCrearNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1469, 840);
            this.Controls.Add(this.bAddNot);
            this.Controls.Add(this.tbCuerpo);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fCrearNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear noticia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbCuerpo;
        private System.Windows.Forms.Button bAddNot;
    }
}