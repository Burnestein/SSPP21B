using System.Windows.Forms;

namespace SSPP21B
{
    //---------------------------------------------------------------------
    //Clase que representa un lápiz.
    //NJSA. 23/08/2021.
    //---------------------------------------------------------------------
    public class CLapiz
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public CColor Color;
        public string Material;
        public int Tipo;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CLapiz()
            {
            Color = new CColor();
            Material = "madera";
            Tipo = 1;
            }

        //---------------------------------------------------------------------
        //Traza una linea.
        //---------------------------------------------------------------------
        public void Trazar(int TipoTrazo)
        {
            string Tipo;

            switch (TipoTrazo)
            {
                case 1:
                    Tipo = "dibujo";
                    break;
                case 2:
                    Tipo = "profesional";
                    break;
                case 3:
                    Tipo = "escolar";
                    break;
                default:
                    Tipo = "desconocido";
                    break;
            }

            MessageBox.Show("Estoy trazando, soy un lápiz de tipo " + Tipo + ".");
        }

        //---------------------------------------------------------------------
        //Identifica el color, material y tipo de lápiz.
        //---------------------------------------------------------------------
        public string Identificar()
        {
            return "Hola, soy un lápiz de " + Material + " de color " + Color.GetColor() + ".";
        }
    }
}
