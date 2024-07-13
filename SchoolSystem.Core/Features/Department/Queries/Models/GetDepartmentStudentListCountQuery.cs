using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Department.Queries.Results;

namespace SchoolSystem.Core.Features.Department.Queries.Models
{
    public class GetDepartmentStudentListCountQuery : IRequest<Response<List<GetDepartmentStudentListCountResults>>>
    {
    }
}
