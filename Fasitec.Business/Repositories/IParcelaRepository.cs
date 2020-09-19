using System;
using System.Linq;
using System.Linq.Expressions;
using Fasitec.Business.Entities;

namespace Fasitec.Business.Repositories
{
    public interface IParcelaRepository
    {
        IQueryable<Parcela> GetAll();
        IQueryable<Parcela> GetAll(string include = "");
        IQueryable<Parcela> Search(Expression<Func<Parcela, bool>> predicate, string include = "");
        Parcela GetById(int parcelaId);
        Parcela Insert(Parcela parcela);
        Parcela Update(Parcela parcela);
        void Remove(int parcelaId);
    }
}