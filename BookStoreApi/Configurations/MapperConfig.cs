using AutoMapper;
using BookStoreApi.Data;
using BookStoreApi.Models.Author;

namespace BookStoreApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();



        }
    }
}
