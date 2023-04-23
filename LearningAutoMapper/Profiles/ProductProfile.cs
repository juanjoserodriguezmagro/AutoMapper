using AutoMapper;
using LearningAutoMapper.DTOs;
using LearningAutoMapper.Entities;

namespace LearningAutoMapper.Profiles;

public class ProductProfile : Profile {
    public ProductProfile() {
        CreateMap<Product, ProductDTO>();
    }
}
