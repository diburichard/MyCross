using MS.COTAS.Cross.RabbitMQ.Src.Events;
using System.Threading.Tasks;

namespace MS.COTAS.Cross.RabbitMQ.Src.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
         where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
