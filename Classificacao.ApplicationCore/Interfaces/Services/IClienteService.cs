using Classificacao.ApplicationCore.Entity;
using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Interfaces.Services
{
    public interface IClienteService : IClassificacaoService<Cliente>
    {
        IList<Cliente> GetClientesByIdFila(int idFila);
    }
}