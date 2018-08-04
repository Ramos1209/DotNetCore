

using ERP.Ramos.Domain.Entities.Base;
using System;

namespace ERP.Ramos.Domain.Entities
{
   public class Canal :EntitiBase
    {
        
        public string Nome { get; set; }
        public string  UrlLogo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
