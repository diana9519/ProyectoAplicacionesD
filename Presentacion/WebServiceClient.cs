
using System.Net;

namespace Presentacion
{
    public class WebServiceClient
    {
        WebClient clienteJSON = new WebClient();

        public string makePost(string url, string data)
        {
            clienteJSON.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            clienteJSON.Encoding = System.Text.Encoding.UTF8;
            var responseServer = clienteJSON.UploadString(url, "POST", data);
            return responseServer;

        }
        public string makeGet(string url)
        {
            clienteJSON.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            clienteJSON.Encoding = System.Text.Encoding.UTF8;
            string responseServer = clienteJSON.DownloadString(url);
            return responseServer;
        }

        public string makeGet(string url, string param, string data)
        {
            clienteJSON.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            clienteJSON.Encoding = System.Text.Encoding.UTF8;
            string responseServer = clienteJSON.DownloadString(url + "?" + param + "=" + data);
            return responseServer;
        }
        public string makeGet(string url, string param, string data, string param2, string data2)
        {
            clienteJSON.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            clienteJSON.Encoding = System.Text.Encoding.UTF8;
            string responseServer = clienteJSON.DownloadString(url + "?" + param + "=" + data + "&" + param2 + "=" + data2);

            return responseServer;
        }
    }
}
