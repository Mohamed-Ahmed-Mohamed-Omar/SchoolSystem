using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Results;

namespace SchoolSystem.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
