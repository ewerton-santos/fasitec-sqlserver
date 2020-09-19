using System.Linq;
using Fasitec.Business.Dto;

namespace Fasitec.Business.ApplicationServices
{
    public interface IParcelaFacade
    {
        IQueryable<ParcelaOutput> All();        
        ParcelaOutput ById(int parcelaId);
        ParcelaOutput Create(ParcelaInput parcelaInput);
        ParcelaOutput Modify(ParcelaInput parcelaInput);
        void Remove(int parcelaId);
    }
}