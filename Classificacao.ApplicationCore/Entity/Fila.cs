using System.Collections.Generic;

namespace Classificacao.ApplicationCore.Entity
{
    public class Fila
    {
        public Fila()
        {
            //FilasClientes = new HashSet<FilasClientes>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<FilaCliente> FilasClientes { get; } = new List<FilaCliente>();
    }
}
