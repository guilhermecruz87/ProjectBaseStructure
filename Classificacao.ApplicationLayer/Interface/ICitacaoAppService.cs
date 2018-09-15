using Classificacao.ApplicationCore.Entity;
using System.Collections.Generic;

namespace Classificacao.ApplicationLayer.Interface
{
    public interface ICitacaoAppService : IAppServiceBase<Citacao>
    {
        IList<Citacao> GetCitacoesByIdFila(int idFila);
    }
}
