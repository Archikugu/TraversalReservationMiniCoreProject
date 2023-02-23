using DTO.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.ContactUsValidationRules
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail field cannot be empty");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Subject field cannot be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Message Body field cannot be empty");

            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Please enter a minimum of 5 characters in the subject field.");
            RuleFor(x => x.Subject).MaximumLength(150).WithMessage("Please enter a maximum of 150 characters in the subject field.");

            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Please enter a minimum of 5 characters in the mail field.");
            RuleFor(x => x.Mail).MaximumLength(150).WithMessage("Please enter a maximum of 150 characters in the mail field.");
        }
    }
}
