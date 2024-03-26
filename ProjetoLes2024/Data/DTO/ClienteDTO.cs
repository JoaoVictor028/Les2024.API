namespace ProjetoLes2024.Data.DTO
{
    public class ClienteCreateDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public EnderecoCreateDTO Endereco { get; set; }
    }

    public class ClienteReadDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public EnderecoReadDTO Endereco { get; set; }
    }

    public class ClienteUpdateDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
    }
}
