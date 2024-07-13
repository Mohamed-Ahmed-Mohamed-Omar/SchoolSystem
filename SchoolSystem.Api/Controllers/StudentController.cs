using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Api.Base;
using SchoolSystem.Core.Features.Students.Commands.Models;
using SchoolSystem.Core.Features.Students.Queries.Models;
using SchoolSystem.Data.AppMetaData;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin,User")]
    public class StudentController : AppControllerBase
    {
        [HttpGet(Router.StudentRouting.List)]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetStudentList()
        {
            var response = await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
        [AllowAnonymous]
        [HttpGet(Router.StudentRouting.Paginated)]
        public async Task<IActionResult> Paginated([FromQuery] GetStudentPaginatedListQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }
        [HttpGet(Router.StudentRouting.GetByID)]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            return NewResult(await _mediator.Send(new GetStudentByIDQuery(id)));
        }
        [Authorize(Policy = "CreateStudent")]
        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddStudentCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "EditStudent")]
        [HttpPut(Router.StudentRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditStudentCommand command)
        {
            var response = await _mediator.Send(command);
            return NewResult(response);
        }
        [Authorize(Policy = "DeleteStudent")]
        [HttpDelete(Router.StudentRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await _mediator.Send(new DeleteStudentCommand(id)));
        }
    }
}
