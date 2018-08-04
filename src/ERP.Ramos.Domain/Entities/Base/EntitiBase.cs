using prmToolkit.NotificationPattern;
using System;

namespace ERP.Ramos.Domain.Entities.Base
{
    public class EntitiBase :Notifiable
    {
        public EntitiBase()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }
    }
}
