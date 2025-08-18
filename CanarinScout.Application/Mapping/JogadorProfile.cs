using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.Mapping
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile() 
        {
            CreateMap<Jogador, JogadorDto>();

            CreateMap<Defensivas, DefensivasDto>();
        }
    }
}
