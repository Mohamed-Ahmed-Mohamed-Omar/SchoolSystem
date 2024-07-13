using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository 
    {
        private readonly DbSet<Student> _student;

        public StudentRepository(ApplicationDbContext context) : base(context)
        {
           _student = context.Set<Student>();
        }

        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _student.Include(x => x.Department).ToListAsync();
        }
    }
}
