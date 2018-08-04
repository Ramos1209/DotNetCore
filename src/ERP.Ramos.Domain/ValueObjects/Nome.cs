using ERP.Ramos.Domain.Resources;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;

namespace ERP.Ramos.Domain.ValueObjects
{
    public class Nome :Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                  .IfNullOrInvalidLength(x => x.PrimeiroNome, 1, 50, MSG.A_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Primeiro nome 1 ,50"))
                  .IfNullOrInvalidLength(x => x.UltimoNome, 1, 50, MSG.A_X0_DEVE_SER_MAIOR_OU_IGUAL_A_X1.ToFormat("Primeiro nome 1 ,50"));
        }

        public string PrimeiroNome { get;private set; }
        public string UltimoNome { get; private set; }
    }
}
