using Classificacao.ApplicationCore.Entity;
using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Interfaces.Services
{
    public interface ICitacaoService : IClassificacaoService<Citacao>
    {
        IList<Citacao> GetCitacoesByIdFila(int idFila);
    }
}
