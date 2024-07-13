using SchoolSystem.Data.Entities;
using SchoolSystem.Data.Entities.Procedures;
using SchoolSystem.Data.Entities.Views;

namespace SchoolSystem.Services.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int departmentId);
        public Task<List<ViewDepartment>> GetViewDepartmentDataAsync();
        public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);
    }
}
