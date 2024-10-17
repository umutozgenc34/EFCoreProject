

using AutoMapper;
using EFCore.CodeFirst.DAL;
using EFCore.CodeFirst.Dtos;

namespace EFCore.CodeFirst.Mappers;

public class ObjectMapper
{
    private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<CustomMapping>();
        });
        return config.CreateMapper();
    });

    public static IMapper Mapper => lazy.Value;
}

internal class CustomMapping : Profile
{
    public CustomMapping()
    {
        CreateMap<PDto, Product>().ReverseMap();
    }
}