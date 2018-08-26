using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string Guid { get; set; }
        public int Status { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Macroregiao { get; set; }

        public ICollection<FilaCliente> FilasClientes { get; } = new List<FilaCliente>();
    }
}
