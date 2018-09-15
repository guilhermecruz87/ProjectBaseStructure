using System.Collections.Generic;
using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Services;
using Classificacao.ApplicationLayer.Interface;

namespace Classificacao.ApplicationLayer
{
    public class CitacaoAppService : AppServiceBase<Citacao>, ICitacaoAppService
    {
        private readonly ICitacaoService _citacaoService;
        public CitacaoAppService(ICitacaoService citacaoService) : base(citacaoService)
        {
            _citacaoService = citacaoService;
        }

        public IList<Citacao> GetCitacoesByIdFila(int idFila)
        {
            return _citacaoService.GetCitacoesByIdFila(idFila);
        }
    }
}
