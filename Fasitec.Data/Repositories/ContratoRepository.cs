using System;
using System.Linq;
using System.Linq.Expressions;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;

namespace Fasitec.Data.Repositories
{
    public class ContratoRepository : IContratoRepository
    {
        private readonly IRepository<Contrato> _repository;

        public ContratoRepository(IRepository<Contrato> repository)
        => _repository = repository;

        public IQueryable<Contrato> GetAll() => _repository.GetAll();
        
        public IQueryable<Contrato> GetAll(string include = "") => _repository.GetAll(include);        

         public IQueryable<Contrato> Search(Expression<Func<Contrato, bool>> predicate, string include = "") 
         => _repository.Search(predicate, include);
        
        public Contrato GetById(int contratoId) => _repository.GetById(contratoId);
        
        public Contrato Insert(Contrato contrato) => _repository.Insert(contrato);
       
        public Contrato Update(Contrato contrato) => _repository.Update(contrato);
        
        public void Remove(int contratoId) => _repository.Remove(contratoId);             
    }
}