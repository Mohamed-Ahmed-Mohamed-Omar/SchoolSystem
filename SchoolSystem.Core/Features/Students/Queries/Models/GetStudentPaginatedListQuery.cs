using MediatR;
using SchoolSystem.Core.Features.Students.Queries.Results;
using SchoolSystem.Core.Wrappers;
using SchoolSystem.Data.Enums;

namespace SchoolSystem.Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public StudentOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
