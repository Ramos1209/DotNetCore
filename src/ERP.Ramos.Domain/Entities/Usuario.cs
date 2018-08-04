using ERP.Ramos.Domain.Entities.Base;
using ERP.Ramos.Domain.ValueObjects;
using ERP.Ramos.Domain.Extension;
using prmToolkit.NotificationPattern;

namespace ERP.Ramos.Domain.Entities
{
    public class Usuario :EntitiBase
    {
        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(x => x.Senha, 1, 8);
            AddNotifications(email);
            Senha = Senha.ConvertToMD5();
        }

        public Usuario()
        {
         
            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(x => x.Senha, 1, 8);
          

            Senha = Senha.ConvertToMD5();
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
    }
}
