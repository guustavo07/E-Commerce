using FluentValidation;

namespace E_Commerce.Application.UseCases.CreateUser;
public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    public CreateUserValidator() 
    { 
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
    }
}
