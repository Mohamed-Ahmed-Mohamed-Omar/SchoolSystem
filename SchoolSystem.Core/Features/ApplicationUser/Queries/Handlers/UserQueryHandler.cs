using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.ApplicationUser.Queries.Models;
using SchoolSystem.Core.Features.ApplicationUser.Queries.Results;
using SchoolSystem.Core.Resources;
using SchoolSystem.Core.Wrappers;
using SchoolSystem.Data.Entities.Identity;

namespace SchoolSystem.Core.Features.ApplicationUser.Queries.Handlers
{
    public class UserQueryHandler : ResponseHandler,
                                    IRequestHandler<GetUserPaginationQuery, PaginatedResult<GetUserPaginationReponse>>,
                                    IRequestHandler<GetUserByIdQuery, Response<GetUserByIdResponse>>
    {

        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _sharedResources;
        private readonly UserManager<User> _userManager;

        public UserQueryHandler(IStringLocalizer<SharedResources> stringLocalizer,
                                  IMapper mapper,
                                  UserManager<User> userManager) : base(stringLocalizer)
        {
            _mapper = mapper;
            _sharedResources = stringLocalizer;
            _userManager = userManager;
        }

        public async Task<PaginatedResult<GetUserPaginationReponse>> Handle(GetUserPaginationQuery request, CancellationToken cancellationToken)
        {
            var users = _userManager.Users.AsQueryable();

            var paginatedList = await _mapper.ProjectTo<GetUserPaginationReponse>(users)
                                            .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }

        public async Task<Response<GetUserByIdResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());

            if (user == null) return NotFound<GetUserByIdResponse>(_sharedResources[SharedResourcesKeys.NotFound]);

            var result = _mapper.Map<GetUserByIdResponse>(user);

            return Success(result);
        }

    }
}
