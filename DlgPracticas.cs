using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace SSPP21B
{
    //---------------------------------------------------------------------
    //Diálogo principal de prácticas de SSPP21B.
    //NJSA. 06/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgPracticas: UserControl
    {
        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgPracticas()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        //Botón de prácticas 1.
        //---------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            DlgProyectoFinal VentanaPF;

            VentanaPF = new DlgProyectoFinal();
            VentanaPF.Show();
        }

        //---------------------------------------------------------------------
        //Botón de prácticas 2.
        //---------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            CLapiz MiLapiz1; //Declaración de la variable.
            CLapiz MiLapiz2;
            CLapiz MiLapiz3;

            MiLapiz1 = new CLapiz(comboBox1.Text, "Madera", 2); //Se construye un objeto, o instancia, de clase CLapiz.
            MiLapiz2 = new CLapiz(comboBox2.Text, "Madera", 2);
            MiLapiz3 = new CLapiz(comboBox3.Text, "Madera", 2);

            BackColor = MiLapiz1.GetColor(); //Se pide el color para pintar el fondo de ventana.
            button1.BackColor = MiLapiz2.GetColor();
            button2.BackColor = MiLapiz3.GetColor();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------
        //Botón de prácticas 3.
        //---------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal MiMenuPrincipal;

            for (int i = 0; i < 10; i++)
            {
                MiMenuPrincipal = new DlgMenuPrincipal();
                MiMenuPrincipal.Show();
            }
        }

        //---------------------------------------------------------------------
        //Botón de prácticas 4.
        //---------------------------------------------------------------------
        private void BtnCalculaVPN_Click(object sender, EventArgs e)
        {
            double[] FlujosFUturos = { 50000, 100000, 150000, 200000, 100000 };
            double Resultado;

            CCalculadoraFinancieraVPN MiCalculadoraVPN = new CCalculadoraFinancieraVPN(500000, 8, FlujosFUturos);
            
            Resultado = MiCalculadoraVPN.CalculaVPN();
            MessageBox.Show("El resultado del método VPN = " + Resultado);

            if (Resultado < 0)
            {
                MessageBox.Show("El proyecto de debe rechazar.");
            }
            else
            {
                if (Resultado > 0)
                {
                    MessageBox.Show("El proyecto de aprueba.");
                }
                else
                {
                    MessageBox.Show("El proyecto es indiferente.");
                }
            }
        }
    }
}
