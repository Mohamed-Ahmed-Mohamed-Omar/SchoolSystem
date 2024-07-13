using SchoolSystem.Core.Features.ApplicationUser.Queries.Results;
using SchoolSystem.Data.Entities.Identity;

namespace SchoolSystem.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserPaginationMapping()
        {
            CreateMap<User, GetUserPaginationReponse>();

        }

    }
}
