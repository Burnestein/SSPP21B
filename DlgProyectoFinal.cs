﻿using System.Drawing;
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
            if (Y >= 100)
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
    }
}
