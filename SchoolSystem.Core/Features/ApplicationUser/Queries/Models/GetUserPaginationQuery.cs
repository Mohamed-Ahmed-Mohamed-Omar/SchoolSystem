using MediatR;
using SchoolSystem.Core.Features.ApplicationUser.Queries.Results;
using SchoolSystem.Core.Wrappers;

namespace SchoolSystem.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
