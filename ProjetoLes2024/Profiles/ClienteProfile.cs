using AutoMapper;
using ProjetoLes2024.Data.DTO;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile() 
        {
            CreateMap<ClienteCreateDTO, Cliente>();
        }
    }
}
