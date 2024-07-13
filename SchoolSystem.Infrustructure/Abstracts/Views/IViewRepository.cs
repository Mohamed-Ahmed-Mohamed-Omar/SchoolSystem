using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Abstracts.Views
{
    public interface IViewRepository<T> : IGenericRepositoryAsync<T> where T : class
    {
    }
}
