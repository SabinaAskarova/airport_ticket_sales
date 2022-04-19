using FluentValidation;
using MyProject.DTOs.UserDTOs;

namespace MyProject.Core.Validations
{
    public class UserValidator : AbstractValidator<UserToAddDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("username bosh ola bilmez!");
            RuleFor(x => x.Password).MinimumLength(8).WithErrorCode("password 8 simvol olmalidir!");
        }
    }
}
