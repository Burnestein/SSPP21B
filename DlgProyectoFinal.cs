using SSPP21B;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Diálogo principal del proyecto final.
    //NJSA. 08/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgProyectoFinal : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private Graphics AreaDibujoReservaciones;
        private int X;
        private int Y;
        private bool Cambio = false;
        private Color MiColor;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgProyectoFinal()
        {
            InitializeComponent();

            AreaDibujoReservaciones = TpgReservaciones.CreateGraphics();
            X = 0;
            Y = 0;
            MiColor = Color.Blue;
        }

        //---------------------------------------------------------------------
        //Limpia los campos de datos.
        //---------------------------------------------------------------------
        private void TsbNuevo_Click(object sender, System.EventArgs e)
        {
            TbxCodigo.Text = "";
            TbxNombre.Text = "";
            TbxApellidoP.Text = "";
            TbxApellidoM.Text = "";
            TbxTelefonoMovil.Text = "";
            TbxCorreo.Text = "";
            TbxFechaNacimiento.Text = "";
            TbxLugarProcedencia.Text = "";
            CbxEstadoCivil.SelectedIndex = -1;
        }

        //---------------------------------------------------------------------
        //Guarda los campos de datos en la base de datos.
        //---------------------------------------------------------------------
        private void TsbGuardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro Guardado.");
        }

        //---------------------------------------------------------------------
        //Cierra la aplicación.
        //---------------------------------------------------------------------
        private void TsbCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //---------------------------------------------------------------------
        //Eliminar un registro.
        //---------------------------------------------------------------------
        private void TsbEliminar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro eliminado.");
            TsbNuevo_Click(sender, e);
        }

        //---------------------------------------------------------------------
        //Dibuja un cuadrado.
        //---------------------------------------------------------------------
        private void BtnDibujar_Click(object sender, System.EventArgs e)
        {
            CCuadrado MiCuadrado;

            MiCuadrado = new CCuadrado(X, Y, 100, MiColor);
            MiCuadrado.Dibuja(AreaDibujoReservaciones);
            X = X + 3;

            if (Cambio==false)
            {
                Y = Y + 3;
            }
            if (Y >= 390)
            {
                Cambio = true;
                MiColor = Color.Red;
            }
            if (Cambio == true)
            {
                Y = Y - 3;
            }
            if (Y <= 0)
            {
                Cambio = false;
                MiColor = Color.Blue;
            }
        }

        //---------------------------------------------------------------------
        //Dibuja un circulo.
        //---------------------------------------------------------------------
        private void BtnDibujarCirculo_Click(object sender, System.EventArgs e)
        {
            CCirculo MiCirculo;
            Color MiColor;

            MiColor = Color.Black;
            MiCirculo = new CCirculo(200+X, 110, 90, MiColor);
            MiCirculo.Dibuja(TpgReservaciones.CreateGraphics());

            MiColor = Color.Blue;
            MiCirculo = new CCirculo(212+X, 122, 50, MiColor);
            MiCirculo.Dibuja(TpgReservaciones.CreateGraphics());

            MiColor = Color.Orange;
            MiCirculo = new CCirculo(313, 150+Y, 30, MiColor);
            MiCirculo.Dibuja(TpgReservaciones.CreateGraphics());

            MiColor = Color.Red;
            MiCirculo = new CCirculo(230, 90+Y, 110, MiColor);
            MiCirculo.Dibuja(TpgReservaciones.CreateGraphics());

        }

        //---------------------------------------------------------------------
        //Dibuja un rectangulo.
        //---------------------------------------------------------------------
        private void BtnDibujarRectangulo_Click(object sender, System.EventArgs e)
        {
            CRectangulo MiRectangulo;
            Graphics Lienzo;
            CColor MiColor;
            Color ColorPrimitivo;

            Lienzo = TpgReservaciones.CreateGraphics();
            MiColor = new CColor(255, 0, 0);
            ColorPrimitivo = MiColor.GetColorPrimitivo();

            MiRectangulo = new CRectangulo(X + 50,Y + 50,250,50,ColorPrimitivo);
            MiRectangulo.Dibuja(Lienzo);
        }

        //---------------------------------------------------------------------
        //Dibuja un polígono.
        //---------------------------------------------------------------------
        private void BtnDibujarPoligono_Click(object sender, System.EventArgs e)
        {
            CPoligono MiPoligono;
            Graphics Lienzo;
            Point[] Puntos;
            Point[] PuntosFor;

            Puntos = new Point[]
            {
                new Point {X=10, Y=50},
                new Point {X=110, Y=50},
                new Point {X=26, Y=104},
                new Point {X=60, Y=20},
                new Point {X=94, Y=106}
            };

            PuntosFor = new Point[10];
            for (int i=0; i<10; i++)
            {
                PuntosFor[i] = new Point { X= (int)Math.Pow(2,i), Y = i * i};
            };

            Lienzo = TpgReservaciones.CreateGraphics();

            MiPoligono = new CPoligono(Puntos, Color.Purple);
            MiPoligono.Dibuja(Lienzo);

            MiPoligono = new CPoligono(PuntosFor, Color.Orange);
            MiPoligono.Dibuja(Lienzo);
        }
    }
}
