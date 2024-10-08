﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolSystem.Core.Bases;
using SchoolSystem.Core.Features.Students.Commands.Models;
using SchoolSystem.Core.Resources;
using SchoolSystem.Data.Entities;
using SchoolSystem.Services.Abstracts;

namespace SchoolSystem.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler : ResponseHandler,
                                         IRequestHandler<AddStudentCommand, Response<string>>,
                                         IRequestHandler<EditStudentCommand, Response<string>>,
                                         IRequestHandler<DeleteStudentCommand, Response<string>>
    {

        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public StudentCommandHandler(IStudentService studentService, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _studentService = studentService;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and student
            var studentmapper = _mapper.Map<Student>(request);

            //add
            var result = await _studentService.AddAsync(studentmapper);

            //return response
            if (result == "Success") return Created("");

            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);

            //return NotFound
            if (student == null) return NotFound<string>();

            //mapping Between request and student
            var studentmapper = _mapper.Map(request, student);

            //Call service that make Edit
            var result = await _studentService.EditAsync(studentmapper);

            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);

            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var student = await _studentService.GetByIDAsync(request.Id);

            //return NotFound
            if (student == null) return NotFound<string>();

            //Call service that make Delete
            var result = await _studentService.DeleteAsync(student);

            if (result == "Success") return Deleted<string>();

            else return BadRequest<string>();
        }
    }
}
