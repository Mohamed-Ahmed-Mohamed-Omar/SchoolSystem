using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories
{
    public class InstructorsRepository : GenericRepositoryAsync<Instructor>, IInstructorsRepository
    {

        private DbSet<Instructor> instructors;

        public InstructorsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            instructors = dbContext.Set<Instructor>();
        }
    }
}
