using System;
using System.Net.Http;
using System.Threading.Tasks;
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
        private string Llave;
        private string Lugar;
        public string Descripcion;
        public string Latitud;
        public string Longitud;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCoordenadasGeo(string Lugar)
        {
            //Recibe parámetros.
            this.Lugar = Lugar;

            //inicializa la llave de acceso a los servicios de geolocalización de Google.

            Llave = "AIzaSyCdUe6rwa9wdPN_me-2aZpYH772GTdz9ME";

        }

        //---------------------------------------------------------------------
        //Obtiene las coordenadas y descripcion de el lugar.
        //NOTA: Al finalizar el método, las coordenadas estarán almacenadas en
        //los atributos: Latitud y Longitud. (Se ejecutará de forma asíncrona).
        //---------------------------------------------------------------------
        public async Task GetCoordenadas()
        {
            HttpClient clienteHttp;
            Uri direccion;
            HttpResponseMessage respuestaHttp;
            string contenidoHttp;
            XmlDocument documentoXML;
            XmlNodeList elemList;
            XmlElement bookElement;

            //Consulta la API de geolocalización de google maps.

            clienteHttp = new HttpClient();
            direccion = new Uri("https://maps.googleapis.com/maps/api/geocode/");//Api de mapas de google
            clienteHttp.BaseAddress = direccion;

            respuestaHttp = await clienteHttp.GetAsync("xml?address=" + Lugar + "&key=" + Llave);
            contenidoHttp = await respuestaHttp.Content.ReadAsStringAsync();

            //Extrae el formatted_address, la latitud y la longitud del XML.

            documentoXML = new XmlDocument();
            documentoXML.LoadXml(contenidoHttp);

            elemList = documentoXML.GetElementsByTagName("formatted_address");
            bookElement = (XmlElement)elemList[0];
            Descripcion = bookElement.InnerText;

            elemList = documentoXML.GetElementsByTagName("location");//Busca la etiqueta 
            bookElement = (XmlElement)elemList[0];
            Latitud = bookElement["lat"].InnerText;
            Longitud = bookElement["lng"].InnerText;

        }
    }
}
