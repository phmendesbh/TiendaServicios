using System;

namespace TiendaServicios.RabbitMQ.Bus.Eventos
{
    public abstract class Evento
    {
        public DateTime TimeStamp { get; protected set; }

        protected Evento()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
