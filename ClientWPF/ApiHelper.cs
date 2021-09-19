using System.Net.Http;
using System.Net.Http.Headers;

namespace ClientWPF
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; private set; }
        public static readonly string BASEURL = "https://localhost:5001/api/";

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
