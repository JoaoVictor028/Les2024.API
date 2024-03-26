using Microsoft.EntityFrameworkCore;
using ProjetoLes2024.Data.Contextos;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Data.DAO
{
    public class ClienteDAO : IDao
    {
        private readonly ClienteContext _context;

        public ClienteDAO(ClienteContext context)
        {
            _context = context;
        }

        public void Inserir(EntidadeDominio entidadeDominio)
        {
            Cliente cliente = (Cliente)entidadeDominio;
            _context.Estados.Add(cliente.Endereco.Cidade.Estado);
            _context.Cidades.Add(cliente.Endereco.Cidade);
            _context.Enderecos.Add(cliente.Endereco);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Alterar(EntidadeDominio entidadeDominio)
        {
            _context.Entry((Cliente)entidadeDominio).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public EntidadeDominio? BuscarPorID(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<EntidadeDominio> BuscarTodos()
        {
            return _context.Clientes.ToList();
        }

        public void Deletar(EntidadeDominio entidadeDominio)
        {
            _context.Clientes.Remove((Cliente)entidadeDominio);
            _context.SaveChanges();
        }
    }
}
