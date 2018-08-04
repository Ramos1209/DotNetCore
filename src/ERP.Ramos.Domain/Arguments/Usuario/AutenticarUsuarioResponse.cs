using System;
using ERP.Ramos.Domain.Entities;

namespace ERP.Ramos.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Usuario v)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = v.Id,
                PrimeiroNome = v.Nome.PrimeiroNome
            };
        }
    }
}
