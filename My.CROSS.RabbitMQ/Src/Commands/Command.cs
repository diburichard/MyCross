using MS.COTAS.Cross.RabbitMQ.Src.Events;
using System;

namespace MS.COTAS.Cross.RabbitMQ.Src.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
