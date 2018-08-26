using AutoMapper;
using Classificacao.ApplicationCore.Entity;
using Classificacao.ApplicationLayer.Interface;
using Classificacao.WebApiApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Classificacao.WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper, IClienteAppService clienteApp)
        {
            _mapper = mapper;
            _clienteApp = clienteApp;
        }


        // GET: api/Cliente
        [HttpGet]
        public IList<ClienteViewModel> Get()
        {
            var clienteViewModel = _mapper.Map<IList<Cliente>, IList<ClienteViewModel>>(_clienteApp.ListAll());
            return clienteViewModel; ;
        }

        //// GET: api/Cliente/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Cliente
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Cliente/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
