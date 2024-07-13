using AutoMapper;

namespace SchoolSystem.Core.Mapping.Instructors
{
    public partial class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            AddInstructorMapping();
        }
    }
}
