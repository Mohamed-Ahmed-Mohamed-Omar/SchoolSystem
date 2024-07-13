using MediatR;
using SchoolSystem.Core.Bases;

namespace SchoolSystem.Core.Features.Authentication.Queries.Models
{
    public class AuthorizeUserQuery : IRequest<Response<string>>
    {
        public string AccessToken { get; set; }
    }
}
