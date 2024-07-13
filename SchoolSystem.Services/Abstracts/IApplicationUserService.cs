using SchoolSystem.Data.Entities.Identity;

namespace SchoolSystem.Services.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
