using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Authentication.Queries.Models;
using SchoolSystem.Core.Resources;

namespace SchoolSystem.Core.Features.Authentication.Queries.Validators
{
    public class ConfirmResetPasswordQueryValidator : AbstractValidator<ConfirmResetPasswordQuery>
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        public ConfirmResetPasswordQueryValidator(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Code)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
            RuleFor(x => x.Email)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

        }
    }
}
