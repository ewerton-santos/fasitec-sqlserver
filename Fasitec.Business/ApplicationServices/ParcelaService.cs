using System.Linq;
using AutoMapper;
using Fasitec.Business.Dto;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;
using Fasitec.Business.Unities;

namespace Fasitec.Business.ApplicationServices
{
    public class ParcelaService : IParcelaFacade
    {
        private readonly IParcelaRepository _parcelaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ParcelaService(IParcelaRepository parcelaRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _parcelaRepository = parcelaRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IQueryable<ParcelaOutput> All()
        {
            return _mapper.ProjectTo<ParcelaOutput>(_parcelaRepository.GetAll());
        }

        public ParcelaOutput ById(int parcelaId)
        {
            return _mapper.Map<ParcelaOutput>(_parcelaRepository.GetById(parcelaId));
        }

        public ParcelaOutput Create(ParcelaInput parcelaInput)
        {           
            var parcela = _mapper.Map<Parcela>(parcelaInput);
            var novaParcela = _parcelaRepository.Insert(parcela);
            _unitOfWork.Commit();
            return _mapper.Map<ParcelaOutput>(novaParcela);
        }

        public ParcelaOutput Modify(ParcelaInput parcelaInput)
        {           
            var parcela = _mapper.Map<Parcela>(parcelaInput);
            var parcelaModificada = _parcelaRepository.Update(parcela);
            _unitOfWork.Commit();
            return _mapper.Map<ParcelaOutput>(parcelaModificada);
        }

        public void Remove(int parcelaId)
        {
            _parcelaRepository.Remove(parcelaId);
            _unitOfWork.Commit();
        }
    }
}