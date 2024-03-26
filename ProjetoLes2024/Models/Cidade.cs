namespace ProjetoLes2024.Models
{
    public class Cidade : EntidadeDominio
    {
        public string Nome { get; set; }
        public long EstadoId { get; set; }
        public Estado Estado { get; set; } // Cidade pertence a um Estado
    }
}
