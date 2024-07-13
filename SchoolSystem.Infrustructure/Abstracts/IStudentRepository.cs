using SchoolSystem.Data.Entities;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Abstracts
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
