using System.Threading.Tasks;
using Consul;

namespace MY.CROSS.Consul.Consul
{
    public interface IConsulServicesRegistry
    {
        Task<AgentService> GetAsync(string name);
    }
}