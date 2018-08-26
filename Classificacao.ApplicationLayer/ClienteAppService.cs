using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationCore.Interfaces.Services;
using Classificacao.ApplicationLayer.Interface;

namespace Classificacao.ApplicationLayer
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }
    }
}
