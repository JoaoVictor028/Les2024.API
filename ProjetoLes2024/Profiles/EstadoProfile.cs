using AutoMapper;
using ProjetoLes2024.Data.DTO;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Profiles
{
    public class EstadoProfile : Profile
    {
        public EstadoProfile()
        {
            CreateMap<EstadoCreateDTO, Estado>();

        }
    }
}
