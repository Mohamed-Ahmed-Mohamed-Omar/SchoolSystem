using SchoolSystem.Data.Commons;

namespace SchoolSystem.Data.Entities.Procedures
{
    public class DepartmentStudentCountProc : GeneralLocalizableEntity
    {
        public int DID { get; set; }
        public string? DNameAr { get; set; }
        public string? DNameEn { get; set; }
        public int StudentCount { get; set; }
    }
    public class DepartmentStudentCountProcParameters
    {
        public int DID { get; set; } = 0;
    }
}
