using MediatR;
using SchoolSystem.Core.Bases;

namespace SchoolSystem.Core.Features.Students.Commands.Models
{
    public class EditStudentCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public int DepartmementId { get; set; }
    }
}
