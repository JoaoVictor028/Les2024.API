namespace ProjetoLes2024.Data.DTO
{
    public class CidadeCreateDTO
    {
        public string Nome { get; set; }
        public EstadoCreateDTO Estado { get; set; }
    }

    public class CidadeReadDTO
    {
        public string Nome { get; set; }
        public EstadoReadDTO Estado { get; set; }
    }

    public class CidadeUpdateDTO
    {
        public string Nome { get; set; }
        public long EstadoId { get; set; }
    }
}
