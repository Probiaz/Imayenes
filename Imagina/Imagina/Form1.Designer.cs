namespace Imagina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openc = new System.Windows.Forms.LinkLabel();
            this.ucol = new System.Windows.Forms.LinkLabel();
            this.discc = new System.Windows.Forms.LinkLabel();
            this.eleima = new System.Windows.Forms.Button();
            this.sal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openc
            // 
            this.openc.AutoSize = true;
            this.openc.Location = new System.Drawing.Point(429, 98);
            this.openc.Name = "openc";
            this.openc.Size = new System.Drawing.Size(87, 13);
            this.openc.TabIndex = 1;
            this.openc.TabStop = true;
            this.openc.Text = "Abrir Calculadora";
            this.openc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Openc_LinkClicked);
            // 
            // ucol
            // 
            this.ucol.AutoSize = true;
            this.ucol.Location = new System.Drawing.Point(510, 157);
            this.ucol.Name = "ucol";
            this.ucol.Size = new System.Drawing.Size(70, 13);
            this.ucol.TabIndex = 2;
            this.ucol.TabStop = true;
            this.ucol.Text = "www.ucol.mx";
            this.ucol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ucol_LinkClicked);
            // 
            // discc
            // 
            this.discc.AutoSize = true;
            this.discc.Location = new System.Drawing.Point(576, 219);
            this.discc.Name = "discc";
            this.discc.Size = new System.Drawing.Size(85, 13);
            this.discc.TabIndex = 3;
            this.discc.TabStop = true;
            this.discc.Text = "Explorar Disco C";
            this.discc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Discc_LinkClicked);
            // 
            // eleima
            // 
            this.eleima.Location = new System.Drawing.Point(432, 27);
            this.eleima.Name = "eleima";
            this.eleima.Size = new System.Drawing.Size(199, 31);
            this.eleima.TabIndex = 4;
            this.eleima.Text = "Elegir Imagen";
            this.eleima.UseVisualStyleBackColor = true;
            this.eleima.Click += new System.EventHandler(this.Eleima_Click);
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(493, 317);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(90, 23);
            this.sal.TabIndex = 5;
            this.sal.Text = "Salir";
            this.sal.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.eleima);
            this.Controls.Add(this.discc);
            this.Controls.Add(this.ucol);
            this.Controls.Add(this.openc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel openc;
        private System.Windows.Forms.LinkLabel ucol;
        private System.Windows.Forms.LinkLabel discc;
        private System.Windows.Forms.Button eleima;
        private System.Windows.Forms.Button sal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

