using ERP.Ramos.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace ERP.Ramos.Domain.ValueObjects
{
    public class Email :Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, MSG.DADOS_NAO_ENCONTRADOS.ToFormat("Endereco"));

        }

        public string Endereco { get;private set; }
    }
}
