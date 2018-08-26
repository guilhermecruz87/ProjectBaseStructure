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
    public class CitacaoController : Controller
    {
        private readonly ICitacaoAppService _citacaoApp;
        private readonly IMapper _mapper;

        public CitacaoController(IMapper mapper, ICitacaoAppService citacaoApp)
        {
            _mapper = mapper;
            _citacaoApp = citacaoApp;
        }

        // GET: api/Citacao
        [HttpGet]
        public IList<CitacaoViewModel> Get()
        {
            var citacaoViewModel = _mapper.Map<IList<Citacao>, IList<CitacaoViewModel>>(_citacaoApp.ListAll());
            return citacaoViewModel; ;
        }

        //// GET: api/Citacao/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Citacao
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Citacao/5
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
