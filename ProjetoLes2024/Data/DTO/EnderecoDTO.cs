namespace ProjetoLes2024.Data.DTO
{
    public class EnderecoCreateDTO
    {
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public CidadeCreateDTO Cidade { get; set; }
    }

    public class EnderecoReadDTO
    {
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public CidadeReadDTO Cidade { get; set; }
    }

    public class EnderecoUpdateDTO
    {
        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public long CidadeId { get; set; }
    }
}
