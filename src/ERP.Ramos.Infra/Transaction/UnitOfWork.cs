using ERP.Ramos.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Ramos.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork

    {

        private readonly RamosContext _context;
     
        public UnitOfWork(RamosContext context)

        {
            _context = context;
        }
    
        public void Commit()

        {
            _context.SaveChanges();
        }

    }
}
