using ERP.Ramos.Domain.Entities.Base;
using ERP.Ramos.Domain.Enum;
using System;

namespace ERP.Ramos.Domain.Entities
{
    public class Video : EntitiBase
    {

        public Canal Canal { get; set; }
        public PlayList PlayList { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public int OrdenPlayList { get; set; }
        public string idYouTube { get; set; }
        public EnumStatus Status { get; set; }
    }
}
