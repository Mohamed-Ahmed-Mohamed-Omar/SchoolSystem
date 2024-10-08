﻿using SchoolSystem.Core.Features.Students.Commands.Models;
using SchoolSystem.Data.Entities;

namespace SchoolSystem.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
               .ForMember(dest => dest.DID, opt => opt.MapFrom(src => src.DepartmementId))
               .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.NameEn))
               .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameAr))
               .ForMember(dest => dest.StudID, opt => opt.MapFrom(src => src.Id));
        }
    }
}
