using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.ApplicationCore.Interfaces.Services;

namespace Classificacao.ApplicationCore.Services
{
    public class CitacaoService : ClassificacaoService<Citacao>, ICitacaoService
    {
        private readonly ICitacaoRepository _citacaoRepository;

        public CitacaoService(ICitacaoRepository repository) : base(repository)
        {
            _citacaoRepository = repository;
        }
    }
}
