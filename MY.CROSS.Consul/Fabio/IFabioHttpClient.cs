using System.Threading.Tasks;

namespace MS.COTAS.Cross.Consul.Fabio
{
    public interface IFabioHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}