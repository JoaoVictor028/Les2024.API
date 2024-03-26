namespace ProjetoLes2024.Models
{
    public class Endereco : EntidadeDominio
    {

        public string Numero { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public long CidadeId { get; set; }
        public Cidade Cidade { get; set; }


    }
}
