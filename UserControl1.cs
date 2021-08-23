using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
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
            CLapiz MiLapiz; //Declaración de la variable.
            MiLapiz = new CLapiz(); //Se construye un objeto, o instancia, de clase CLapiz.
            MessageBox.Show(MiLapiz.Identificar());
            MiLapiz.Trazar(4); //Se usa el objeto o instancia.
        }
    }
}
