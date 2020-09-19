using System.Linq;
using Fasitec.Business.Dto;

namespace Fasitec.Business.ApplicationServices
{
    public interface IContratoFacade
    {
        IQueryable<ContratoOutput> All();        
        ContratoOutput ById(int contratoId);
        ContratoOutput Create(ContratoInput contratoInput);
        ContratoOutput Modify(ContratoInput contratoInput);
        void Remove(int contratoId);
    }
}