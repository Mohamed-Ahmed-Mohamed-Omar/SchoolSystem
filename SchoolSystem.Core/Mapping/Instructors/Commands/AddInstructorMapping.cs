﻿using SchoolSystem.Core.Features.Instructors.Commands.Models;
using SchoolSystem.Data.Entities;

namespace SchoolSystem.Core.Mapping.Instructors
{
    public partial class InstructorProfile
    {
        public void AddInstructorMapping()
        {
            CreateMap<AddInstructorCommand, Instructor>()
                 .ForMember(dest => dest.Image, opt => opt.Ignore())
                 .ForMember(dest => dest.ENameAr, opt => opt.MapFrom(src => src.NameAr))
                 .ForMember(dest => dest.ENameEn, opt => opt.MapFrom(src => src.NameEn));
        }
    }
}
