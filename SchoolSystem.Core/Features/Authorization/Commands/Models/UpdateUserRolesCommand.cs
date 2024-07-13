using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Requests;

namespace SchoolSystem.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
