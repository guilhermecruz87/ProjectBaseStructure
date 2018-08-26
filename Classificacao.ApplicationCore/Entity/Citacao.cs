using System;

namespace Classificacao.ApplicationCore.Entity
{
    public class Citacao
    {
        public Citacao()
        {
        }

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
