using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Authorization.Commands.Models;
using SchoolSystem.Core.Resources;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Authorization.Commands.Validators
{
    public class DeleteRoleValidator : AbstractValidator<DeleteRoleCommand>
    {
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        public readonly IAuthorizationService _authorizationService;

        public DeleteRoleValidator(IStringLocalizer<SharedResources> stringLocalizer, IAuthorizationService authorizationService)
        {
            _stringLocalizer = stringLocalizer;
            _authorizationService = authorizationService;
            ApplyValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                 .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);
        }

    }
}
