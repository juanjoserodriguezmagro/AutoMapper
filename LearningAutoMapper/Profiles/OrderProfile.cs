using AutoMapper;
using LearningAutoMapper.DTOs;
using LearningAutoMapper.Entities;

namespace LearningAutoMapper.Profiles;

public class OrderProfile : Profile {
    public OrderProfile() {
        CreateMap<Order, OrderDTO>();
    }
}
