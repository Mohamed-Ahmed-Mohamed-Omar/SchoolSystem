using MediatR;
using SchoolSystem.Core.Bases;

namespace SchoolSystem.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
