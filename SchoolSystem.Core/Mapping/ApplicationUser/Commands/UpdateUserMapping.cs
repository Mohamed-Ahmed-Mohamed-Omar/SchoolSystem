using SchoolSystem.Core.Features.ApplicationUser.Commands.Models;
using SchoolSystem.Data.Entities.Identity;

namespace SchoolSystem.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void UpdateUserMapping()
        {
            CreateMap<EditUserCommand, User>();
        }
    }
}
