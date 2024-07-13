using FluentValidation;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Features.Students.Commands.Models;
using SchoolSystem.Core.Resources;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Students.Commands.Validatiors
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        private readonly IStudentService _studentService;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public EditStudentValidator(IStudentService studentService, IStringLocalizer<SharedResources> localizer) : base()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
            _studentService = studentService;
            _localizer = localizer;
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.NameAr)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                 .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.NameAr)
                .MustAsync(async (model, Key, CancellationToken) => !await _studentService.IsNameArExistExcludeSelf(Key, model.Id))
                .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
            RuleFor(x => x.NameEn)
                .MustAsync(async (model, Key, CancellationToken) => !await _studentService.IsNameEnExistExcludeSelf(Key, model.Id))
                .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        }
    }
}
