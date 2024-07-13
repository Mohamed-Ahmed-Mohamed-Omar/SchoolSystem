﻿using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Data.Results;

namespace SchoolSystem.Core.Features.Authorization.Queries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
