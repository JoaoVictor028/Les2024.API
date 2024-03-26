using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.DAO
{
    public interface IDao
    {
        public void Inserir(EntidadeDominio entidadeDominio);
        public EntidadeDominio? BuscarPorID(int id);
        public IEnumerable<EntidadeDominio> BuscarTodos();
        public void Deletar(EntidadeDominio entidadeDominio);
        public void Alterar(EntidadeDominio entidadeDominio);
    }
}
