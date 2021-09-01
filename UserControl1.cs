using System;
using System.Windows.Forms;

namespace SSPP21B
{
    public partial class SSPP21b: UserControl
    {
        public SSPP21b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola mundo!");
        }

        private void SSPP21b_Load(object sender, EventArgs e)
        {

        }

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
    }
}
