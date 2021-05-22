using System.Threading.Tasks;
using TiendaServicios.RabbitMQ.Bus.BusRabbit;
using TiendaServicios.RabbitMQ.Bus.EventoQueue;

namespace TiendaServicios.Api.Autor.ManejadorRabbit
{
    public class EmailEventoManejador : IEventoManejador<EmailEventoQueue>
    {
        public EmailEventoManejador() { }

        public Task Handle(EmailEventoQueue @event)
        {
            return Task.CompletedTask;
        }
    }
}
