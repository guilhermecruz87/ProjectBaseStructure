using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.ApplicationCore.Interfaces.Services;

namespace Classificacao.ApplicationCore.Services
{
    public class FilaService : ClassificacaoService<Fila>, IFilaService
    {
        private readonly IFilaRepository _filaRepository;

        public FilaService(IFilaRepository repository) : base(repository)
        {
            _filaRepository = repository;
        }
    }
}
