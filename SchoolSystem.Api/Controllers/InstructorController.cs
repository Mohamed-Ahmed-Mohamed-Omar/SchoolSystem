using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Api.Base;
using SchoolSystem.Core.Features.Instructors.Commands.Models;
using SchoolSystem.Core.Features.Instructors.Queries.Models;
using SchoolSystem.Data.AppMetaData;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class InstructorController : AppControllerBase
    {
        [HttpGet(Router.InstructorRouting.GetSalarySummationOfInstructor)]
        public async Task<IActionResult> GetSalarySummation()
        {
            return NewResult(await _mediator.Send(new GetSummationSalaryOfInstructorQuery()));
        }
        [HttpPost(Router.InstructorRouting.AddInstructor)]
        public async Task<IActionResult> AddInstructor([FromForm] AddInstructorCommand command)
        {
            return NewResult(await _mediator.Send(command));
        }
    }
}
