using AutoMapper;

namespace SchoolSystem.Core.Mapping.Departments
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            GetDepartmentByIdMapping();
            GetDepartmentStudentCountMapping();
            GetDepartmentStudentCountByIdMapping();
        }
    }
}
