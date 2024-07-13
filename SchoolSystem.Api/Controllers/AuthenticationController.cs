using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Api.Base;
using SchoolSystem.Core.Features.Authentication.Commands.Models;
using SchoolSystem.Core.Features.Authentication.Queries.Models;
using SchoolSystem.Data.AppMetaData;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]

    public class AuthenticationController : AppControllerBase
    {

        [HttpPost(Router.Authentication.SignIn)]
        public async Task<IActionResult> Create([FromForm] SignInCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }

        [HttpPost(Router.Authentication.RefreshToken)]
        public async Task<IActionResult> RefreshToken([FromForm] RefreshTokenCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ValidateToken)]
        public async Task<IActionResult> ValidateToken([FromQuery] AuthorizeUserQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ConfirmEmail)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpPost(Router.Authentication.SendResetPasswordCode)]
        public async Task<IActionResult> SendResetPassword([FromQuery] SendResetPasswordCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [HttpGet(Router.Authentication.ConfirmResetPasswordCode)]
        public async Task<IActionResult> ConfirmResetPassword([FromQuery] ConfirmResetPasswordQuery query)
        {
            var response = await _mediator.Send(query);
            return NewResult(response);
        }
        [HttpPost(Router.Authentication.ResetPassword)]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
    }
}
