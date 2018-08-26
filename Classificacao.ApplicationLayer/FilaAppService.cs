using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Services;
using Classificacao.ApplicationLayer.Interface;

namespace Classificacao.ApplicationLayer
{
    public class FilaAppService : AppServiceBase<Fila>, IFilaAppService
    {
        private readonly IFilaService _filaService;
        public FilaAppService(IFilaService filaService) : base(filaService)
        {
            _filaService = filaService;
        }
    }
}
