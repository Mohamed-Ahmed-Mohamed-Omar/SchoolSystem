using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Api.Base;
using SchoolSystem.Core.Features.Department.Queries.Models;
using SchoolSystem.Data.AppMetaData;

namespace SchoolSystem.Api.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class DepartmentController : AppControllerBase
    {
        [HttpGet(Router.DepartmentRouting.GetByID)]
        public async Task<IActionResult> GetDepartmentByID([FromQuery] GetDepartmentByIDQuery query)
        {
            return NewResult(await _mediator.Send(query));
        }
        [HttpGet(Router.DepartmentRouting.GetDepartmentStudentsCount)]
        public async Task<IActionResult> GetDepartmentStudentsCount()
        {
            return NewResult(await _mediator.Send(new GetDepartmentStudentListCountQuery()));
        }

        [HttpGet(Router.DepartmentRouting.GetDepartmentStudentsCountById)]
        public async Task<IActionResult> GetDepartmentStudentsCountById([FromRoute] int id)
        {
            return NewResult(await _mediator.Send(new GetDepartmentStudentCountByIDQuery() { DID = id }));
        }
    }
}
