using FluentValidation;
using UserManagementApplication.ViewModels;

namespace UserManagementApplication.Validators
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            //RuleFor(x => x.Id).Must(CheckId).WithMessage("Id must greater than 0");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("Name can not be null")
                .Length(1, 50)
                .WithMessage("Length of name must be between 1 to 50");

            RuleFor(x => x.Age)
                .NotNull()
                .WithMessage("Age can not be null")
                .GreaterThan(0)
                .WithMessage("Age must greater than 0");

            RuleFor(x => x.Address).Length(0, 50).WithMessage("Length of address must be less than 50");
        }

        private bool CheckId(int? id)
        {
            return !id.HasValue || id.Value > 0;
        }
    }
}
