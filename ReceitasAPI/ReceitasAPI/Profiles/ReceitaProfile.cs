using AutoMapper;
using ReceitasAPI.Data.DTOs;
using ReceitasAPI.Models;

namespace ReceitasAPI.Profiles
{
    public class ReceitaProfile : Profile
    {
        public ReceitaProfile()
        {
            CreateMap<UpdateReceitaDTOs, Receita>();
        }
    }
}
