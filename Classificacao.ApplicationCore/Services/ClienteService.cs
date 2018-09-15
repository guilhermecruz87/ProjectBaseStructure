using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Repository;
using Classificacao.ApplicationCore.Interfaces.Services;
using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Services
{
    public class ClienteService : ClassificacaoService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository repository) : base(repository)
        {
            _clienteRepository = repository;
        }

        public IList<Cliente> GetClientesByIdFila(int idFila)
        {
            return _clienteRepository.GetClientesByIdFila(idFila);
        }
    }
}
