using SchoolSystem.Data.Entities.Procedures;
using SchoolSystem.Infrustructure.Abstracts.Procedures;
using SchoolSystem.Infrustructure.Context;
using StoredProcedureEFCore;

namespace SchoolSystem.Infrustructure.Repositories.Procedures
{
    public class DepartmentStudentCountProcRepository : IDepartmentStudentCountProcRepository
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        #endregion
        #region Constructors
        public DepartmentStudentCountProcRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion
        #region Handle Functions
        public async Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters)
        {
            var rows = new List<DepartmentStudentCountProc>();
            await _context.LoadStoredProc(nameof(DepartmentStudentCountProc))
                   .AddParam(nameof(DepartmentStudentCountProcParameters.DID), parameters.DID)
                   .ExecAsync(async r => rows = await r.ToListAsync<DepartmentStudentCountProc>());
            return rows;
        }
        #endregion

    }
}
