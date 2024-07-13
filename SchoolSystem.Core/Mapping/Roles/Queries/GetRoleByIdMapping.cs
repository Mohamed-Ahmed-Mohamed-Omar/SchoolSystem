using Microsoft.AspNetCore.Identity;
using SchoolSystem.Core.Features.Authorization.Queries.Results;

namespace SchoolSystem.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRoleByIdMapping()
        {
            CreateMap<IdentityRole<int>, GetRoleByIdResult>();
        }
    }
}
