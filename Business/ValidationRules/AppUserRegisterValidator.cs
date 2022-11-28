using DTO.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("SurName field cannot be empty");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email field cannot be empty");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName field cannot be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConffirmPassword field cannot be empty");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Username must be at least 5 characters");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Username must be a maximum of 20 characters");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Passwords do not match");

        }
    }
}
