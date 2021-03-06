﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesignOnPanel
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private float xv1;
        private float yv1;
        private float xv2;
        private float yv2;

        public List<Vector> Vectores { get; }
        public int Contador { get; }

        public Form1()
        {
            InitializeComponent();
            Vectores = new List<Vector>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnVectorContenedor.BackColor = Color.White;
            TxtManoIzquierdaX.Text = "0";
            TxtManoIzquierdaY.Text = "0";
            TxtManoDerechaX.Text = "0";
            TxtManoDerechaY.Text = "0";
            v1.Text = "0";
            txtMagnitud.Text = "0";
            txtDireccion.Text = "0";
            v2.Text = "0";
            txtMagnitud2.Text = "0";
            txtDireccion2.Text = "0";
            contador = 0;
            Compov1.Text = "0";
            Compov2.Text = "0";
            txtSuma.Text = "0";
            txtResta.Text = "0";
            txtCruz.Text = "0";
            txtEscalarv1.Text = "0";
            txtEscalarv2.Text = "0";
            txtPunto.Text = "0";
            txtV1Escalar.Text = "0";
            txtV2Escalar.Text = "0";
        }

        private void btnCrearVector_Click(object sender, EventArgs e)
        {
            pnVectorContenedor.Invalidate(); // esta linea la tienen que llamar cada vez que los joints/skelton valores cambien
        }

        public void pnVectorContenedor_Paint(object sender, PaintEventArgs e)
        {
            
            Pen bluePen = new Pen(Color.Blue, 1);

            Graphics graphics = pnVectorContenedor.CreateGraphics();

            //Dibuja las lines azules en el contenedor
            var anchoContenedor = float.Parse(pnVectorContenedor.Width.ToString());
            var altoContendor = float.Parse(pnVectorContenedor.Height.ToString());
            graphics.DrawLine(bluePen, 0, altoContendor / 2, anchoContenedor, altoContendor / 2);
            graphics.DrawLine(bluePen, anchoContenedor / 2, 0, anchoContenedor / 2, altoContendor);

            //Dibuja los vectores guardados en memoria
            foreach (var vector in Vectores)
            {
                DibujaVector(vector, graphics);
                
            }

            //Dibuja el vector actual
            DibujarVectorActual(graphics);
           
        }

        private void DibujarVectorActual(Graphics graphics)
        {
            DibujaVector(ObtenerVectorActual(), graphics);
        }

        public void DibujaVector(Vector vector, Graphics graphics)
        {
            Pen redPen = new Pen(Color.Red, 1);

            var x1 = ObtenerValorEnX(vector.Punto1.X/10);
            var y1 = ObtenerValorEnY(vector.Punto1.Y/10);

            var x2 = ObtenerValorEnX(vector.Punto2.X/10);
            var y2 = ObtenerValorEnY(vector.Punto2.Y/10);

            graphics.DrawLine(redPen, x1, y1, x2, y2);
            
        }

        

        private float ObtenerValorEnX(float valor)
        {
            var anchoContenedor = float.Parse(pnVectorContenedor.Width.ToString());
            var mitadDelAnchoDelContenedor = anchoContenedor / 2;
            //var valorAEscalaDelContenedor = valor * anchoContenedor;

            float valorEscalaContendor = 0;
            if (valor > 0)
            {
                valorEscalaContendor = valor * mitadDelAnchoDelContenedor;
            }
            else
            {
                valorEscalaContendor = valor * mitadDelAnchoDelContenedor;
            }

            return mitadDelAnchoDelContenedor + valorEscalaContendor;
        }

        private float ObtenerValorEnY(float valor)
        {
            var altoContenedor = float.Parse(pnVectorContenedor.Height.ToString());
            var mitadAltoContenedor = altoContenedor / 2;

            float valorEscalaContendor = 0;
            if (valor > 0)
            {
                valorEscalaContendor = valor * mitadAltoContenedor;
                //return mitadAltoContenedor - valorEscalaContendor;
            }
            else
            {
                valorEscalaContendor = valor * mitadAltoContenedor;
            }
            
            return mitadAltoContenedor - valorEscalaContendor;
        }

        private void btnGuardarVector_Click(object sender, EventArgs e)
        {
            GuardarVectorActual();
        }

        private void GuardarVectorActual()
        {
            Vectores.Add(ObtenerVectorActual()); // esta linea la van a utilizar cuando detecten la voz del kinect
        }

        public Vector ObtenerVectorActual()
        {
            var punto1 = new CoordenadaDeVector(float.Parse(TxtManoIzquierdaX.Text), float.Parse(TxtManoIzquierdaY.Text));
            var punto2 = new CoordenadaDeVector(float.Parse(TxtManoDerechaX.Text), float.Parse(TxtManoDerechaY.Text));
            return new Vector(punto1, punto2);
        }
       
        private void TxtManoIzquierdaX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMagnitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
            TxtManoIzquierdaX.Text = "0";
            TxtManoIzquierdaY.Text = "0";
            TxtManoDerechaX.Text = "0";
            TxtManoDerechaY.Text = "0";


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnVectorContenedor.CreateGraphics();
            TxtManoIzquierdaX.Text = "0";
            TxtManoIzquierdaY.Text = "0";
            TxtManoDerechaX.Text = "0";
            TxtManoDerechaY.Text = "0";
            v1.Text = "";
            txtMagnitud.Text = "";
            txtDireccion.Text = "";
            v2.Text = "";
            txtMagnitud2.Text = "";
            txtDireccion2.Text = "";
            contador = 0;
            Compov1.Text = "";
            Compov2.Text = "";
            txtSuma.Text = " ";
            txtResta.Text = "";
            txtCruz.Text = "";
            txtEscalarv1.Text = "";
            txtEscalarv2.Text = "";
            txtPunto.Text = "";
            txtV1Escalar.Text = "";
            txtV2Escalar.Text = "";


            


        }



        private void Calcular()
        {
            Vectores.Add(ObtenerVectorActual());
            contador++;
            if (contador == 1){
                var izqX = float.Parse(TxtManoIzquierdaX.Text);//Magnitud = raiz de (x2-x1)al cuadrado + (y2-y1)al cuadrado
                var izqy = float.Parse(TxtManoIzquierdaY.Text);//Direccion = Contangente (y2-y1)/(x2-x1)
                var derx = float.Parse(TxtManoDerechaX.Text);
                var dery = float.Parse(TxtManoDerechaY.Text);

                //Coordenadas del vector 1
                v1.Text ="( "+izqX.ToString()+", "+izqy.ToString()+") "+ "( " + derx.ToString() + ", " + dery.ToString() + ")";

                //Componentes del vector 1 AB=(X2- X1, Y2-Y1)
                xv1 = derx - izqX;
                yv1 = dery - izqy;
                Compov1.Text="(" +xv1.ToString()+ ", "+ yv1.ToString()+")";

                //Magnitud
                var x = Math.Pow(derx - izqX, 2);
                var y = Math.Pow(dery - izqy, 2);
                var magnitud = Math.Sqrt(x + y);
                txtMagnitud.Text = magnitud.ToString();

                //Direccion
                var x1 = derx - izqX;
                var y1 = dery - izqy;
                var direccion = Math.Atan(y1 / x1) * 180 / Math.PI;
                txtDireccion.Text = direccion.ToString();
            }
            else {
                var izqX = float.Parse(TxtManoIzquierdaX.Text);//Magnitud = raiz de (x2-x1)al cuadrado + (y2-y1)al cuadrado
                var izqy = float.Parse(TxtManoIzquierdaY.Text);//Direccion = Contangente (y2-y1)/(x2-x1)
                var derx = float.Parse(TxtManoDerechaX.Text);
                var dery = float.Parse(TxtManoDerechaY.Text);
               //Coordenadas del vector 2
                v2.Text = "( " + izqX.ToString() + ", " + izqy.ToString() + ") " + "( " + derx.ToString() + ", " + dery.ToString() + ")";

                //Componentes del vector 2 AB=(X2- X1, Y2-Y1)
                xv2 = derx - izqX;
                yv2 = dery - izqy;
                Compov2.Text = "(" + xv2.ToString() + ", " + yv2.ToString() + ")";

                //Magnitud
                var x = Math.Pow(derx - izqX, 2);
                var y = Math.Pow(dery - izqy, 2);
                var magnitud = Math.Sqrt(x + y);
                txtMagnitud2.Text = magnitud.ToString();
                //Direccion
                var x1 = derx - izqX;
                var y1 = dery - izqy;
                double direccion = Math.Atan(y1 / x1) * 180 / Math.PI;
                txtDireccion2.Text = direccion.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Sumav();
            Resta();
            Punto();
            PorCruz();
            Escalar();
            
      

        }
        private void Sumav()
        {
            //Suma de vectores formula: A + B = (Xv1 + Xv2, Yv1 + Yv2)
            //xv1;
            //yv1;
            //xv2;
            //yv2;
            var x = xv1 + xv2;
            var y = yv1 + yv2;
            txtSuma.Text = "(" + x.ToString() + ", " + y.ToString() + ")";
        }
        private void Resta()
        {

            //Resta de vectores formula: A - B = (Xv1 - Xv2, Yv1 - Yv2)
            //xv1;
            //yv1;
            //xv2;
            //yv2;
            var x = xv1 - xv2;
            var y = yv1 - yv2;
            txtResta.Text = "(" + x.ToString() + ", " + y.ToString() + ")";
        }
        private void Punto()
        {

            //proPunto=(Xv1*XV2)+(Yv1*Yv2)
            //xv1;
            //yv1;
            //xv2;
            //yv2;
            var proPunto = (xv1 * xv2) + (yv1 * yv2);
            txtPunto.Text = proPunto.ToString();
        }
        private void PorCruz()
        {

            //Producto por Cruz Formula: Z =[(Xv1 * YV2) - (XV2 * YV1)]
            //xv1;
            //yv1;
            //xv2;
            //yv2;
            var z= (xv1 * yv2 ) + (xv2* yv1);
            txtCruz.Text = "(0, 0, " + z.ToString()+" )k";

        }
        private void Escalar()
        {
            float escalaV1 = float.Parse(txtEscalarv1.Text);
            float escalaV2 = float.Parse(txtEscalarv2.Text);
            //Producto escalar fromula:Producto por escalar
            //Escalax1 = escalaV1 * Xv1
            //    Escalay1 = escalaV1 * Yv1
            //    Escalax2 = escalaV2 * Xv2
            //    Escalay2 = escalaV2 * Yv2
            float escalax1 = escalaV1 * xv1;
            float escalay1 = escalaV1 * yv1;
            float escalax2 = escalaV2 * xv2;
            float escalay2 = escalaV2 * yv2;
            txtV1Escalar.Text = "(" + escalax1.ToString() + ", " + escalay1.ToString() + ")";
            txtV2Escalar.Text = "(" + escalax2.ToString() + ", " + escalay2.ToString() + ")";

        }
        private void Resta_Click(object sender, EventArgs e)
        {

        }
        
        private void Formulas_Click(object sender, EventArgs e)
        {
            
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void txtSuma_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
