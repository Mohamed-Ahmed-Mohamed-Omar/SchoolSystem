using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Instructors.Queries.Models;
using SchoolSystem.Core.Resources;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Instructors.Queries.Handlers
{
    public class InstructorQueryHandler : ResponseHandler,
                   IRequestHandler<GetSummationSalaryOfInstructorQuery, Response<decimal>>
    {

        #region Fileds
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IInstructorService _instructorService;
        #endregion
        #region Constructors
        public InstructorQueryHandler(IStringLocalizer<SharedResources> stringLocalizer,
                                      IMapper mapper,
                                      IInstructorService instructorService) : base(stringLocalizer)
        {
            _mapper = mapper;
            _stringLocalizer = stringLocalizer;
            _instructorService = instructorService;
        }

        #endregion
        #region Handle Functions
        public async Task<Response<decimal>> Handle(GetSummationSalaryOfInstructorQuery request, CancellationToken cancellationToken)
        {
            var result = await _instructorService.GetSalarySummationOfInstructor();
            return Success(result);
        }
        #endregion
    }
}
