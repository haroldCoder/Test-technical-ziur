using System.Net;
using System.Net.Http.Json;

namespace Test_technical_ziur.core.utils
{
    public class HttpRequestApi(HttpClient http) // Esta clase la creamos con el fin de hacer peticiones http
    {
        public async Task<T?> SendAsync<T>(HttpMethod method, string endpoint, object? data = null,
                                       Dictionary<string, string>? headers = null) // con este metodo podemos armar cualquier metodo http, con el endpoind y los headers como el bearer token
        {
            using var request = new HttpRequestMessage(method, endpoint);

            if (data is not null)
                request.Content = JsonContent.Create(data);

            if (headers is not null)
                foreach (var h in headers)
                    request.Headers.TryAddWithoutValidation(h.Key, h.Value);

            using var response = await http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return response.StatusCode == HttpStatusCode.NoContent
                ? default
                : await response.Content.ReadFromJsonAsync<T>();
        }

        public Task<T?> Get<T>(string url, Dictionary<string, string>? headers = null) // por ejemplo aca tenemos el metodo http GET, representado en la case, el T, hace referencia a el tipo de datos que esperamos que el get devuelva
            => SendAsync<T>(HttpMethod.Get, url, null, headers);

        public Task<T?> Post<T>(string url, object? data = null, Dictionary<string, string>? headers = null)
            => SendAsync<T>(HttpMethod.Post, url, data, headers);

        public Task<T?> Put<T>(string url, object? data = null, Dictionary<string, string>? headers = null)
            => SendAsync<T>(HttpMethod.Put, url, data, headers);

        public Task<T?> Delete<T>(string url, Dictionary<string, string>? headers = null)
            => SendAsync<T>(HttpMethod.Delete, url, null, headers);
    }
}
