using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Authorization.Queries.Results;

namespace SchoolSystem.Core.Features.Authorization.Queries.Models
{
    public class GetRolesListQuery : IRequest<Response<List<GetRolesListResult>>>
    {
    }
}
