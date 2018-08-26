using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classificacao.WebApiApplication.ViewModels
{
    public class CitacaoViewModel
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Texto { get; set; }
        public string Fonte { get; set; }
        public string UrlProfile { get; set; }
        public int IdCliente { get; set; }
        public string LinkExterno { get; set; }
        public Int16 Status { get; set; }
        public Int16 Type { get; set; }
        public DateTime DataCaptura { get; set; }
        public DateTime? DataClassificacao { get; set; }
    }
}
