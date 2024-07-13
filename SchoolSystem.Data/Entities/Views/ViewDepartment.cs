using Microsoft.EntityFrameworkCore;
using SchoolSystem.Data.Commons;

namespace SchoolSystem.Data.Entities.Views
{
    [Keyless]
    public class ViewDepartment : GeneralLocalizableEntity
    {
        public int DID { get; set; }
        public string? DNameAr { get; set; }
        public string? DNameEn { get; set; }
        public int StudentCount { get; set; }
    }
}
