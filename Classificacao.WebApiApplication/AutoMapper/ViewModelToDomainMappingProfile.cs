using AutoMapper;
using Classificacao.ApplicationCore.Entity;
using Classificacao.WebApiApplication.ViewModels;

namespace Classificacao.WebApiApplication.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Fila, FilaViewModel>();
            CreateMap<Citacao, CitacaoViewModel>();
        }
    }
}
