
using ERP.Ramos.Domain.Entities.Base;
using ERP.Ramos.Domain.Enum;

namespace ERP.Ramos.Domain.Entities
{
    public class PlayList:EntitiBase
    {
        public string Nome { get; private set; }
        public Usuario Usuario { get; private set; }
        public EnumStatus Status { get; private set; }
    }
}
