using MediatR;

namespace E_Commerce.Application.UseCases.CreateUser;
public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;