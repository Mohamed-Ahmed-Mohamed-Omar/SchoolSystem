﻿using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Results;

namespace SchoolSystem.Core.Features.Authorization.Queries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
