namespace ProjetoLes2024.Models
{
    public class Cliente : EntidadeDominio
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
