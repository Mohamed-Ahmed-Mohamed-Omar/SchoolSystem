using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Authorization.Queries.Results;

namespace SchoolSystem.Core.Features.Authorization.Queries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResult>>
    {
        public int Id { get; set; }

    }
}
        