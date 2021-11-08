using System;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase que representa una calculadora financiera del método de
    //evaluación Valor Presente Neto.
    //NJSA. 08/11/2021.
    //---------------------------------------------------------------------
    public class CCalculadoraFinancieraVPN
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private double Inversion; //Inversión inicial del proyecto.
        private double Tasa; //Tasa de descuento (%).
        private double[] FlujosFuturos;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCalculadoraFinancieraVPN(double Inversion, double Tasa, double[] FlujosFuturos)
        {
            this.Inversion = Inversion;
            this.Tasa = Tasa;
            this.FlujosFuturos = FlujosFuturos;
        }

        //---------------------------------------------------------------------
        //Calcula el Valor Presente Neto.
        //---------------------------------------------------------------------
        public double CalculaVPN()
        {
            double Sumatoria;

            Sumatoria = 0;

            for (int i = 0; i < FlujosFuturos.Length; i++)
            {
                Sumatoria = Sumatoria + CalculaValorPresente(FlujosFuturos[i], i + 1);
            }
            return -Inversion + Sumatoria;
        }

        //---------------------------------------------------------------------
        //Calcula el Valor Presente de un valor futuro.
        //---------------------------------------------------------------------
        private double CalculaValorPresente(double ValorFuturo, int Año)
        {
            double Calculo;

            Calculo = 1 + (Tasa/100);
            Calculo = Math.Pow(Calculo, Año);
            Calculo = ValorFuturo / Calculo;

            return Calculo;
        }
    }
}
