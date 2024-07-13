using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Entities;
using SchoolSystem.Data.Entities.Procedures;
using SchoolSystem.Data.Entities.Views;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Abstracts.Procedures;
using SchoolSystem.Infrustructure.Abstracts.Views;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Services.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        #region Fields
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IViewRepository<ViewDepartment> _viewDepartmentRepository;
        private readonly IDepartmentStudentCountProcRepository _departmentStudentCountProcRepository;
        #endregion

        #region Constructors
        public DepartmentService(IDepartmentRepository departmentRepository,
                                 IViewRepository<ViewDepartment> viewDepartmentRepository,
                                 IDepartmentStudentCountProcRepository departmentStudentCountProcRepository)
        {
            _departmentRepository = departmentRepository;
            _viewDepartmentRepository = viewDepartmentRepository;
            _departmentStudentCountProcRepository = departmentStudentCountProcRepository;
        }


        #endregion

        #region Handle Functions
        public async Task<Department> GetDepartmentById(int id)
        {
            var student = await _departmentRepository.GetTableNoTracking().Where(x => x.DID.Equals(id))
                                                        .Include(x => x.DepartmentSubjects).ThenInclude(x => x.Subject)
                                                        .Include(x => x.Instructors)
                                                        .Include(x => x.Instructor).FirstOrDefaultAsync();
            return student;
        }

        public async Task<bool> IsDepartmentIdExist(int departmentId)
        {
            return await _departmentRepository.GetTableNoTracking().AnyAsync(x => x.DID.Equals(departmentId));
        }
        public async Task<List<ViewDepartment>> GetViewDepartmentDataAsync()
        {
            var viewDepartment = await _viewDepartmentRepository.GetTableNoTracking().ToListAsync();
            return viewDepartment;
        }

        public async Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters)
        {
            return await _departmentStudentCountProcRepository.GetDepartmentStudentCountProcs(parameters);
        }
        #endregion
    }
}
