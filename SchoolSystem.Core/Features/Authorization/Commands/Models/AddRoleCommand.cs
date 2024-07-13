using MediatR;
using SchoolSystem.Core.Bases;

namespace SchoolSystem.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
