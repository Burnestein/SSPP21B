using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Clase para procesar coordenadas geográficas.
    //NJSA. 01/11/2021.
    //---------------------------------------------------------------------
    class CCoordenadasGeo
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private string Lugar;
        public string Contenido;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCoordenadasGeo(string Lugar)
        {
            this.Lugar = Lugar;
        }

        //---------------------------------------------------------------------
        //Obtiene una coordenada de el lugar.
        //TipoCoordenada = 1, obtiene latitud.
        //TipoCoordenada = 2, obtiene longitud.
        //---------------------------------------------------------------------
        public async void GetCoordenada(int TipoCoordenada)
        {
            HttpClient clienteHttp;
            Uri direccion;
            HttpResponseMessage respuestaHttp;
            string contenidoHttp;
            XmlDocument documentoXML;
            string Llave;
            XmlNodeList elemList;
            XmlElement bookElement;

            Llave = "AIzaSyCdUe6rwa9wdPN_me-2aZpYH772GTdz9ME";

            clienteHttp = new HttpClient();
            direccion = new Uri("https://maps.googleapis.com/maps/api/geocode/");//Api de mapas de google
            clienteHttp.BaseAddress = direccion;

            respuestaHttp = await clienteHttp.GetAsync("xml?address=" + Lugar + "&key=" + Llave);
            contenidoHttp = await respuestaHttp.Content.ReadAsStringAsync();

            documentoXML = new XmlDocument();
            documentoXML.LoadXml(contenidoHttp);

            elemList = documentoXML.GetElementsByTagName("location");//Busca la etiqueta 
            bookElement = (XmlElement)elemList[0];
            MessageBox.Show(bookElement["lat"].InnerText);
            MessageBox.Show(bookElement["lng"].InnerText);
        }
    }
}
