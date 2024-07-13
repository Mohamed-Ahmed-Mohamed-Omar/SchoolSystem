using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Students.Queries.Results;

namespace SchoolSystem.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
