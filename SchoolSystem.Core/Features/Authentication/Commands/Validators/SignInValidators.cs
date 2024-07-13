using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Authentication.Commands.Models;
using SchoolSystem.Core.Resources;

namespace SchoolSystem.Core.Features.Authentication.Commands.Validators
{
    public class SignInValidators : AbstractValidator<SignInCommand>
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        public SignInValidators(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.UserName)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }

    }
}
