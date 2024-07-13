using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Students.Queries.Models;
using SchoolSystem.Core.Features.Students.Queries.Results;
using SchoolSystem.Core.Resources;
using SchoolSystem.Core.Wrappers;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                       IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
                                       IRequestHandler<GetStudentByIDQuery, Response<GetSingleStudentResponse>>,
                                       IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>
    {

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public StudentQueryHandler(IStudentService studentService, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _studentService = studentService;
            _mapper = mapper;
            _localizer = localizer;
        }


        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentService.GetStudentsListAsync();

            var studentListMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);

            var result = Success(studentListMapper);

            result.Meta = new { Count = studentListMapper.Count() };

            return result;
        }

        public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);

            if (student == null) return NotFound<GetSingleStudentResponse>(_localizer[SharedResourcesKeys.NotFound]);

            var result = _mapper.Map<GetSingleStudentResponse>(student);

            return Success(result);
        }

        public async Task<PaginatedResult<GetStudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        {
            var FilterQuery = _studentService.FilterStudentPaginatedQuerable(request.OrderBy, request.Search);

            var PaginatedList = await _mapper.ProjectTo<GetStudentPaginatedListResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);

            PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };

            return PaginatedList;
        }
    }
}
