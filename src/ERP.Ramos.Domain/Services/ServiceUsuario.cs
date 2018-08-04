using ERP.Ramos.Domain.Arguments.Usuario;
using ERP.Ramos.Domain.Entities;
using ERP.Ramos.Domain.Interfaces.Repositorys;
using ERP.Ramos.Domain.Interfaces.Services;
using ERP.Ramos.Domain.Resources;
using ERP.Ramos.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace ERP.Ramos.Domain.Services
{
    public class ServiceUsuario :Notifiable, IServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
           if(request == null)
            {
                AddNotification("User null", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("User"));
                return null;
            }
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);
            Usuario user = new Usuario();
            AddNotifications(user);

            if (this.IsInvalid()) return null;

            _repositoryUsuario.Salvar(user);

            return new AdicionarUsuarioResponse(user.Id);
          

        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            if(request == null)
            {
                AddNotification("Objeto e obrigatorio", "Obrigatório senha");
                return null;
            }

            var email = new Email(request.Email);
            var user = new Usuario(email, request.Senha);

            AddNotifications(user);
            if (this.IsInvalid()) return null;

            user = _repositoryUsuario.Obter(user.Email.Endereco, user.Senha);

            if(user == null)
            {
                AddNotification("", MSG.DADOS_NAO_ENCONTRADOS.ToFormat("user"));
                return null;
            }

            var response = (AutenticarUsuarioResponse)user;
           
            return response;
        }
    }
}
