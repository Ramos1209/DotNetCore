

using ERP.Ramos.Domain.Arguments.Usuario;
using ERP.Ramos.Domain.Interfaces.Services.Base;

namespace ERP.Ramos.Domain.Interfaces.Services
{
    public interface IServiceUsuario  :IServiceBase
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }
}
