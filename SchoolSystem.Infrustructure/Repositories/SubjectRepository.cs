using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subjects>, ISubjectRepository
    {

        private DbSet<Subjects> subjects;

        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            subjects = dbContext.Set<Subjects>();
        }

    }
}
