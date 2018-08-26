using AutoMapper;
using Classificacao.ApplicationCore.Entity;
using Classificacao.WebApiApplication.ViewModels;

namespace Classificacao.WebApiApplication.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<FilaViewModel, Fila>();
            CreateMap<CitacaoViewModel, Citacao>();
        }
    }
}
