using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Results;

namespace SchoolSystem.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
