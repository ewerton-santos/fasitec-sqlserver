using System;
using System.Linq;
using System.Linq.Expressions;
using Fasitec.Business.Entities;

namespace Fasitec.Business.Repositories
{
    public interface IContratoRepository
    {
        IQueryable<Contrato> GetAll();
        IQueryable<Contrato> GetAll(string include = "");
        IQueryable<Contrato> Search(Expression<Func<Contrato, bool>> predicate, string include = "");
        Contrato GetById(int contratoId);
        Contrato Insert(Contrato contrato);
        Contrato Update(Contrato contrato);
        void Remove(int contratoId);
    }
}