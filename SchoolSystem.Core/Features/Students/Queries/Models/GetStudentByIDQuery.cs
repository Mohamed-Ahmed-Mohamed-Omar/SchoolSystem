using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Students.Queries.Results;

namespace SchoolSystem.Core.Features.Students.Queries.Models
{
    public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }
    }
}
