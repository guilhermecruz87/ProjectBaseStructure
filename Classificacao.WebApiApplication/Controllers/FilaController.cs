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
    public class FilaController : Controller
    {
        private readonly IFilaAppService _filaApp;
        private readonly IMapper _mapper;

        public FilaController(IMapper mapper, IFilaAppService filaApp)
        {
            _mapper = mapper;
            _filaApp = filaApp;
        }

        // GET: api/Fila
        [HttpGet]
        public IList<FilaViewModel> Get()
        {
            var filaViewModel = _mapper.Map<IList<Fila>, IList<FilaViewModel>>(_filaApp.ListAll());
            return filaViewModel;
        }

        //// GET: api/Fila/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Fila
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Fila/5
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
