using Classificacao.ApplicationCore.Entity;
using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Interfaces.Repository
{
    public interface ICitacaoRepository : IClassificacaoRepository<Citacao>
    {
        IList<Citacao> GetCitacoesByIdFila(int idFila);
    }
}
