﻿namespace DesignOnPanel
{
    partial class Form1
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
            this.pnVectorContenedor = new System.Windows.Forms.Panel();
            this.TxtManoIzquierdaX = new System.Windows.Forms.TextBox();
            this.lblManoIzquierdaX = new System.Windows.Forms.Label();
            this.lblManoIzquierdaY = new System.Windows.Forms.Label();
            this.TxtManoIzquierdaY = new System.Windows.Forms.TextBox();
            this.lblManoDerechaX = new System.Windows.Forms.Label();
            this.TxtManoDerechaX = new System.Windows.Forms.TextBox();
            this.lblManoDerechaY = new System.Windows.Forms.Label();
            this.TxtManoDerechaY = new System.Windows.Forms.TextBox();
            this.btnCrearVector = new System.Windows.Forms.Button();
            this.btnGuardarVector = new System.Windows.Forms.Button();
            this.Punto1 = new System.Windows.Forms.Label();
            this.Punto2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.txtMagnitud2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnVectorContenedor
            // 
            this.pnVectorContenedor.Location = new System.Drawing.Point(12, 27);
            this.pnVectorContenedor.Name = "pnVectorContenedor";
            this.pnVectorContenedor.Size = new System.Drawing.Size(491, 369);
            this.pnVectorContenedor.TabIndex = 1;
            this.pnVectorContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnVectorContenedor_Paint);
            // 
            // TxtManoIzquierdaX
            // 
            this.TxtManoIzquierdaX.Location = new System.Drawing.Point(662, 42);
            this.TxtManoIzquierdaX.Name = "TxtManoIzquierdaX";
            this.TxtManoIzquierdaX.Size = new System.Drawing.Size(100, 20);
            this.TxtManoIzquierdaX.TabIndex = 2;
            this.TxtManoIzquierdaX.TextChanged += new System.EventHandler(this.TxtManoIzquierdaX_TextChanged);
            // 
            // lblManoIzquierdaX
            // 
            this.lblManoIzquierdaX.AutoSize = true;
            this.lblManoIzquierdaX.Location = new System.Drawing.Point(546, 45);
            this.lblManoIzquierdaX.Name = "lblManoIzquierdaX";
            this.lblManoIzquierdaX.Size = new System.Drawing.Size(93, 13);
            this.lblManoIzquierdaX.TabIndex = 3;
            this.lblManoIzquierdaX.Text = "Mano Izquierda X:";
            // 
            // lblManoIzquierdaY
            // 
            this.lblManoIzquierdaY.AutoSize = true;
            this.lblManoIzquierdaY.Location = new System.Drawing.Point(546, 71);
            this.lblManoIzquierdaY.Name = "lblManoIzquierdaY";
            this.lblManoIzquierdaY.Size = new System.Drawing.Size(93, 13);
            this.lblManoIzquierdaY.TabIndex = 5;
            this.lblManoIzquierdaY.Text = "Mano Izquierda Y:";
            // 
            // TxtManoIzquierdaY
            // 
            this.TxtManoIzquierdaY.Location = new System.Drawing.Point(662, 68);
            this.TxtManoIzquierdaY.Name = "TxtManoIzquierdaY";
            this.TxtManoIzquierdaY.Size = new System.Drawing.Size(100, 20);
            this.TxtManoIzquierdaY.TabIndex = 4;
            // 
            // lblManoDerechaX
            // 
            this.lblManoDerechaX.AutoSize = true;
            this.lblManoDerechaX.Location = new System.Drawing.Point(546, 122);
            this.lblManoDerechaX.Name = "lblManoDerechaX";
            this.lblManoDerechaX.Size = new System.Drawing.Size(91, 13);
            this.lblManoDerechaX.TabIndex = 7;
            this.lblManoDerechaX.Text = "Mano Derecha X:";
            // 
            // TxtManoDerechaX
            // 
            this.TxtManoDerechaX.Location = new System.Drawing.Point(662, 119);
            this.TxtManoDerechaX.Name = "TxtManoDerechaX";
            this.TxtManoDerechaX.Size = new System.Drawing.Size(100, 20);
            this.TxtManoDerechaX.TabIndex = 6;
            // 
            // lblManoDerechaY
            // 
            this.lblManoDerechaY.AutoSize = true;
            this.lblManoDerechaY.Location = new System.Drawing.Point(546, 148);
            this.lblManoDerechaY.Name = "lblManoDerechaY";
            this.lblManoDerechaY.Size = new System.Drawing.Size(91, 13);
            this.lblManoDerechaY.TabIndex = 9;
            this.lblManoDerechaY.Text = "Mano Derecha Y:";
            // 
            // TxtManoDerechaY
            // 
            this.TxtManoDerechaY.Location = new System.Drawing.Point(662, 145);
            this.TxtManoDerechaY.Name = "TxtManoDerechaY";
            this.TxtManoDerechaY.Size = new System.Drawing.Size(100, 20);
            this.TxtManoDerechaY.TabIndex = 8;
            // 
            // btnCrearVector
            // 
            this.btnCrearVector.Location = new System.Drawing.Point(549, 186);
            this.btnCrearVector.Name = "btnCrearVector";
            this.btnCrearVector.Size = new System.Drawing.Size(213, 23);
            this.btnCrearVector.TabIndex = 14;
            this.btnCrearVector.Text = "Crear Vector";
            this.btnCrearVector.UseVisualStyleBackColor = true;
            this.btnCrearVector.Click += new System.EventHandler(this.btnCrearVector_Click);
            // 
            // btnGuardarVector
            // 
            this.btnGuardarVector.Location = new System.Drawing.Point(549, 215);
            this.btnGuardarVector.Name = "btnGuardarVector";
            this.btnGuardarVector.Size = new System.Drawing.Size(213, 23);
            this.btnGuardarVector.TabIndex = 15;
            this.btnGuardarVector.Text = "Guardar Vector";
            this.btnGuardarVector.UseVisualStyleBackColor = true;
            this.btnGuardarVector.Click += new System.EventHandler(this.btnGuardarVector_Click);
            // 
            // Punto1
            // 
            this.Punto1.AutoSize = true;
            this.Punto1.Location = new System.Drawing.Point(546, 18);
            this.Punto1.Name = "Punto1";
            this.Punto1.Size = new System.Drawing.Size(44, 13);
            this.Punto1.TabIndex = 16;
            this.Punto1.Text = "Punto 1";
            this.Punto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Punto2
            // 
            this.Punto2.AutoSize = true;
            this.Punto2.Location = new System.Drawing.Point(546, 99);
            this.Punto2.Name = "Punto2";
            this.Punto2.Size = new System.Drawing.Size(44, 13);
            this.Punto2.TabIndex = 17;
            this.Punto2.Text = "Punto 2";
            this.Punto2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Direccion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Magnitud";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(870, 122);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 22;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(870, 85);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 21;
            this.txtMagnitud.TextChanged += new System.EventHandler(this.txtMagnitud_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1022, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1022, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Magnitud";
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Location = new System.Drawing.Point(1100, 80);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion2.TabIndex = 27;
            // 
            // txtMagnitud2
            // 
            this.txtMagnitud2.Location = new System.Drawing.Point(1100, 42);
            this.txtMagnitud2.Name = "txtMagnitud2";
            this.txtMagnitud2.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud2.TabIndex = 26;
            this.txtMagnitud2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(796, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Vector 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1022, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Vector 2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(870, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 515);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion2);
            this.Controls.Add(this.txtMagnitud2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtMagnitud);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Punto2);
            this.Controls.Add(this.Punto1);
            this.Controls.Add(this.btnGuardarVector);
            this.Controls.Add(this.btnCrearVector);
            this.Controls.Add(this.lblManoDerechaY);
            this.Controls.Add(this.TxtManoDerechaY);
            this.Controls.Add(this.lblManoDerechaX);
            this.Controls.Add(this.TxtManoDerechaX);
            this.Controls.Add(this.lblManoIzquierdaY);
            this.Controls.Add(this.TxtManoIzquierdaY);
            this.Controls.Add(this.lblManoIzquierdaX);
            this.Controls.Add(this.TxtManoIzquierdaX);
            this.Controls.Add(this.pnVectorContenedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnVectorContenedor;
        private System.Windows.Forms.TextBox TxtManoIzquierdaX;
        private System.Windows.Forms.Label lblManoIzquierdaX;
        private System.Windows.Forms.Label lblManoIzquierdaY;
        private System.Windows.Forms.TextBox TxtManoIzquierdaY;
        private System.Windows.Forms.Label lblManoDerechaX;
        private System.Windows.Forms.TextBox TxtManoDerechaX;
        private System.Windows.Forms.Label lblManoDerechaY;
        private System.Windows.Forms.TextBox TxtManoDerechaY;
        private System.Windows.Forms.Button btnCrearVector;
        private System.Windows.Forms.Button btnGuardarVector;
        private System.Windows.Forms.Label Punto1;
        private System.Windows.Forms.Label Punto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion2;
        private System.Windows.Forms.TextBox txtMagnitud2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

