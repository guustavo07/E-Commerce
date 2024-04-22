using AutoMapper;
using E_Commerce.Domain.Entities;

namespace E_Commerce.Application.UseCases.CreateUser;
public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}
