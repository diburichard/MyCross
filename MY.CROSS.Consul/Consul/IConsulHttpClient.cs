using System.Threading.Tasks;

namespace MY.CROSS.Consul.Consul
{
    public interface IConsulHttpClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}

