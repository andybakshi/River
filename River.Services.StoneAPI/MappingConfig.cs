using AutoMapper;
using River.Services.StoneAPI.Models;
using River.Services.StoneAPI.Models.Dto;

namespace River.Services.StoneAPI
{
    public class MappingProfile : Profile
    {

        public MappingProfile() 
        {
            CreateMap<Stone, StoneDto>()
                    .ForMember(dest =>
                        dest.StoneName,
                        opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest =>
                        dest.StoneDescription,
                        opt => opt.MapFrom(src => src.Description))
                    .ReverseMap();
        }
        //public static MapperConfiguration RegisterMaps()
        //{
        //    var mappingConfig = new MapperConfiguration(config =>
        //    {
        //        config.CreateMap<Stone, StoneDto>()
        //            .ForMember(dest =>
        //                dest.StoneName,
        //                opt => opt.MapFrom(src => src.Name))
        //            .ForMember(dest =>
        //                dest.StoneDescription,
        //                opt => opt.MapFrom(src => src.Description))
        //            .ReverseMap();
        //    });
        //    return mappingConfig;
        //}
    }
}
