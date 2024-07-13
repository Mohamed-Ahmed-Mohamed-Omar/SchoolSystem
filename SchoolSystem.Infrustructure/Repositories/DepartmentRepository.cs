using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {

        private DbSet<Department> departments;

        public DepartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            departments = dbContext.Set<Department>();
        }

    }
}
