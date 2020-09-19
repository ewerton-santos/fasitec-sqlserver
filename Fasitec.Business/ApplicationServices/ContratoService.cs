using System.Linq;
using AutoMapper;
using Fasitec.Business.Dto;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;
using Fasitec.Business.Unities;

namespace Fasitec.Business.ApplicationServices
{
    public class ContratoService : IContratoFacade
    {
        private readonly IContratoRepository _contratoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContratoService(IContratoRepository contratoRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _contratoRepository = contratoRepository; 
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IQueryable<ContratoOutput> All()
        {
            var contratos = _contratoRepository.GetAll();
            return _mapper.ProjectTo<ContratoOutput>(contratos);
        }

        public ContratoOutput ById(int contratoId)
        {
            return _mapper.Map<ContratoOutput>(_contratoRepository.GetById(contratoId));
        }

        public ContratoOutput Create(ContratoInput contratoInput)
        {            
            var contrato = _mapper.Map<Contrato>(contratoInput);
            var novoContrato = _contratoRepository.Insert(contrato);
            _unitOfWork.Commit();
            return _mapper.Map<ContratoOutput>(novoContrato);
        }

        public ContratoOutput Modify(UserInput contratoInput)
        {           
            var contrato = _mapper.Map<Contrato>(contratoInput);
            var contratoModificado = _contratoRepository.Update(contrato);
            _unitOfWork.Commit();
            return _mapper.Map<ContratoOutput>(contratoModificado);
        }

        public void Remove(int contratoId)
        {            
            _contratoRepository.Remove(contratoId);
            _unitOfWork.Commit();
        }
    }
}