using SchoolSystem.Data.Entities.Identity;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
