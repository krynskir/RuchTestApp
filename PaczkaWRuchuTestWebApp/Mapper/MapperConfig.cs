using AutoMapper;
using OrlenPaczkaApi;
using PaczkaWRuchuTestWebApp.Models;

namespace PaczkaWRuchuTestWebApp.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<GenerateLabelViewModel, GenerateLabelBusinessPackRequest>()
                .ForMember(dest => dest.DestinationCode, opt => opt.MapFrom(src => src.PickupPoint))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.SenderEMail, opt => opt.MapFrom(src => src.SenderEMail))
                .ForMember(dest => dest.SenderFirstName, opt => opt.MapFrom(src => src.SenderFirstName))
                .ForMember(dest => dest.SenderLastName, opt => opt.MapFrom(src => src.SenderLastName))
                .ForMember(dest => dest.SenderStreetName, opt => opt.MapFrom(src => src.SenderStreetName))
                .ForMember(dest => dest.SenderBuildingNumber, opt => opt.MapFrom(src => src.SenderBuildingNumber))
                .ForMember(dest => dest.SenderCity, opt => opt.MapFrom(src => src.SenderCity))
                .ForMember(dest => dest.SenderPostCode, opt => opt.MapFrom(src => src.SenderPostCode))
                .ForMember(dest => dest.SenderPhoneNumber, opt => opt.MapFrom(src => src.SenderPhoneNumber));
        }
    }
}
