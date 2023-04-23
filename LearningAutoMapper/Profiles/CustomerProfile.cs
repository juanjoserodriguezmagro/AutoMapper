using AutoMapper;
using LearningAutoMapper.DTOs;
using LearningAutoMapper.Entities;

namespace LearningAutoMapper.Profiles;

public class CustomerProfile : Profile {
    public CustomerProfile() {
        CreateMap<Customer, CustomerDTO>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.SurName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email));
    }
}
