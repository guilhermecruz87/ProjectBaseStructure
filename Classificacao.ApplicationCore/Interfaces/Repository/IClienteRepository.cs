using Classificacao.ApplicationCore.Entity;
using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Interfaces.Repository
{
    public interface IClienteRepository : IClassificacaoRepository<Cliente>
    {
        IList<Cliente> GetClientesByIdFila(int idFila);
    }
}
