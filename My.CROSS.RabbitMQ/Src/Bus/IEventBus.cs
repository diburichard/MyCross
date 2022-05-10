using MS.COTAS.Cross.RabbitMQ.Src.Commands;
using MS.COTAS.Cross.RabbitMQ.Src.Events;
using System.Threading.Tasks;

namespace MS.COTAS.Cross.RabbitMQ.Src.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
