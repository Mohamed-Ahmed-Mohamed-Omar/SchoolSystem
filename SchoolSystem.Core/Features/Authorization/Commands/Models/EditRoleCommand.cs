using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Requests;

namespace SchoolSystem.Core.Features.Authorization.Commands.Models
{
    public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
    {
    }
}
