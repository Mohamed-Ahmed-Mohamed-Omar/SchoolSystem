using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Department.Queries.Results;

namespace SchoolSystem.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIDQuery : IRequest<Response<GetDepartmentByIDResponse>>
    {
        public int Id { get; set; }

        public int StudentPageNumber { get; set; }

        public int StudentPageSize { get; set; }

        public GetDepartmentByIDQuery(int id, int studentPageNumber, int studentPageSize)
        {
            Id = id;
            StudentPageNumber = studentPageNumber;
            StudentPageSize = studentPageSize;
        }
    }
}
