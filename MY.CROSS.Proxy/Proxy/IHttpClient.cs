using System.Net.Http;
using System.Threading.Tasks;

namespace MS.COTAS.Cross.Proxy.Proxy
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri);
        Task<HttpResponseMessage> GetAsync(string uri);
        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);
        Task<HttpResponseMessage> PutAsync<T>(string uri, T item);
    }
}
