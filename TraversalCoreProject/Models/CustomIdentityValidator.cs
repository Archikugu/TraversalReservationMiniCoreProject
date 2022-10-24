using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Password must contain at least {length} characters"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError() { Code = "PasswordRequiresUpper", Description = "Password must contain at least 1 uppercase letter" };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError() { Code = "PasswordRequiresLower", Description = "Password must contain at least 1 lowercase letter" };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Password must contain at least 1 symbol"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = $"Password must contain at least 1 digit ('0'.'9')."
            };
        }


    }
}

