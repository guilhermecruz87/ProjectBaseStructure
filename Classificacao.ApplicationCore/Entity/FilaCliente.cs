namespace Classificacao.ApplicationCore.Entity
{
    public class FilaCliente
    {
        public FilaCliente()
        {

        }

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFila { get; set; }

        public Cliente Cliente { get; set; }
        public Fila Fila { get; set; }
    }
}
