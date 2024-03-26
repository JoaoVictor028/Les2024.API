using AutoMapper;
using ProjetoLes2024.Data.DTO;
using ProjetoLes2024.Models;

namespace ProjetoLes2024.Profiles
{
    public class CidadeProfile : Profile
    {
        public CidadeProfile()
        {
            CreateMap<CidadeCreateDTO, Cidade>();

        }
    }
}
