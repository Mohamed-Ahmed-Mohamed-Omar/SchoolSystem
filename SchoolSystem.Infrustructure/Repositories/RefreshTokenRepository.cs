using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities.Identity;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        private DbSet<UserRefreshToken> userRefreshToken;

        public RefreshTokenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            userRefreshToken = dbContext.Set<UserRefreshToken>();
        }
    }
}
