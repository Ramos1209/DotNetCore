using ERP.Ramos.Domain.Entities.Base;

namespace ERP.Ramos.Domain.Entities
{
    public class Favorito :EntitiBase
    {
        public Video Video { get; set; }

        public Usuario Usuario { get; set; }
    }
}
