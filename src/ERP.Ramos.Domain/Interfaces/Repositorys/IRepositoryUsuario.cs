using ERP.Ramos.Domain.Entities;
using System;

namespace ERP.Ramos.Domain.Interfaces.Repositorys
{
    public interface IRepositoryUsuario
    {
        Usuario Obter(Guid id);
        Usuario Obter(string senha,string email);
        void Salvar(Usuario usuario);
        bool Existe(string email);

    }
}
