﻿using MediatR;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.ApplicationUser.Queries.Results;

namespace SchoolSystem.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
