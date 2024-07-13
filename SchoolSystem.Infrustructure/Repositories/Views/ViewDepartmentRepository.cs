using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities.Views;
using SchoolSystem.Infrustructure.Abstracts.Views;
using SchoolSystem.Infrustructure.Context;
using SchoolSystem.Infrustructure.InfrastructureBases;

namespace SchoolSystem.Infrustructure.Repositories.Views
{
    public class ViewDepartmentRepository : GenericRepositoryAsync<ViewDepartment>, IViewRepository<ViewDepartment>
    {
        #region Fields
        private DbSet<ViewDepartment> viewDepartment;
        #endregion

        #region Constructors
        public ViewDepartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            viewDepartment = dbContext.Set<ViewDepartment>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
