using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Authentication.Commands.Models;
using SchoolSystem.Core.Resources;

namespace SchoolSystem.Core.Features.Authentication.Commands.Validators
{
    public class SendResetPasswordCommandValidator : AbstractValidator<SendResetPasswordCommand>
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        public SendResetPasswordCommandValidator(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Email)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }
    }
}
