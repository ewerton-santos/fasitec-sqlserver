using AutoMapper;
using Fasitec.Business.Dto;
using Fasitec.Business.Entities;

namespace Fasitec.Data.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<User, UserInput>().ReverseMap();
            CreateMap<User, UserOutput>().ReverseMap();
            CreateMap<UserInput, UserOutput>().ReverseMap();

            CreateMap<Parcela, ParcelaInput>().ReverseMap();
            CreateMap<Parcela, ParcelaOutput>().ReverseMap();

            CreateMap<Contrato, ContratoInput>().ReverseMap();
            CreateMap<Contrato, ContratoOutput>().ReverseMap();
        }
    }
}