using System;
using System.Linq;
using System.Linq.Expressions;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;

namespace Fasitec.Data.Repositories
{
    public class ParcelaRepository : IParcelaRepository
    {
        private readonly IRepository<Parcela> _repository;

        public ParcelaRepository(IRepository<Parcela> repository) 
        => _repository = repository;

        public IQueryable<Parcela> GetAll() => _repository.GetAll();

        public IQueryable<Parcela> GetAll(string include = "") => _repository.GetAll(include);
        

        public IQueryable<Parcela> Search(Expression<Func<Parcela, bool>> predicate, string include = "")
         => _repository.Search(predicate, include);        

        public Parcela GetById(int parcelaId) => _repository.GetById(parcelaId);
        
        public Parcela Insert(Parcela parcela) => _repository.Insert(parcela);
        
        public Parcela Update(Parcela parcela) => _repository.Update(parcela);
        
        public void Remove(int parcelaId) => _repository.Remove(parcelaId);       
    }
}