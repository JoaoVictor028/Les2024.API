using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoLes2024.Data.Contextos;
using ProjetoLes2024.Data.DAO;
using ProjetoLes2024.Data.DTO;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _context;
        private IDao _dao;
        private IMapper _mapper;
        public ClienteController(ClienteContext context, IMapper mapper)
        {
            _context = context;
            _dao = new ClienteDAO(_context);
            _mapper = mapper;
        }

        [HttpPost("Inserir")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Inserir([FromBody] ClienteCreateDTO clienteDTO)
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDTO);
            _dao.Inserir(cliente);
            return Ok();
        }

    }
}
