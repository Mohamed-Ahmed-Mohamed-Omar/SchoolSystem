using MediatR;
using SchoolSystem.Core.Bases;

namespace SchoolSystem.Core.Features.Instructors.Queries.Models
{
    public class GetSummationSalaryOfInstructorQuery : IRequest<Response<decimal>>
    {
    }
}
