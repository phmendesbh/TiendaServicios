using System;
using System.Threading.Tasks;
using TiendaServicios.Api.Gateway.LibroRemote;

namespace TiendaServicios.Api.Gateway.InterfaceRemote
{
    public interface IAutorRemote
    {
        Task<(bool resultado, AutorModeloRemote autor, string ErrorMessage)> GetAutor(Guid AutorId);
    }
}
