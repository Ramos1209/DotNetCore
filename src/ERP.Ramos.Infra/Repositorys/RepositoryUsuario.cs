using ERP.Ramos.Domain.Entities;
using ERP.Ramos.Domain.Interfaces.Repositorys;
using ERP.Ramos.Infra.Context;
using System;
using System.Linq;

namespace ERP.Ramos.Infra.Repositorys
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly RamosContext _ramosContext;

        public RepositoryUsuario(RamosContext ramosContext)
        {
            this._ramosContext = ramosContext;
        }

        public bool Existe(string email)
        {
            return _ramosContext.Usuarios.Any(x => x.Email.Endereco == email);
        }

        public Usuario Obter(Guid id)
        {
            return _ramosContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public Usuario Obter(string senha, string email)
        {
            return _ramosContext.Usuarios.FirstOrDefault(x => x.Senha == senha && x.Email.Endereco == email);
        }

        public void Salvar(Usuario usuario)
        {
            _ramosContext.Usuarios.Add(usuario);
            _ramosContext.SaveChanges();

        }
    }
}
