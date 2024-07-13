using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Authorization.Commands.Models;
using SchoolSystem.Core.Resources;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Authorization.Commands.Validators
{
    public class AddRoleValidators : AbstractValidator<AddRoleCommand>
    {
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IAuthorizationService _authorizationService;

        public AddRoleValidators(IStringLocalizer<SharedResources> stringLocalizer,
                                 IAuthorizationService authorizationService)
        {
            _stringLocalizer = stringLocalizer;
            _authorizationService = authorizationService;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.RoleName)
                 .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.RoleName)
                .MustAsync(async (Key, CancellationToken) => !await _authorizationService.IsRoleExistByName(Key))
                .WithMessage(_stringLocalizer[SharedResourcesKeys.IsExist]);
        }
    }
}
