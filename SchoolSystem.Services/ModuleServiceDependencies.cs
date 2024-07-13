using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Services.Abstracts;
using SchoolSystem.Services.AuthServices.Implementations;
using SchoolSystem.Services.AuthServices.Interfaces;
using SchoolSystem.Services.Implementations;

namespace SchoolSystem.Services
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AdddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IInstructorService, InstructorService>();
            services.AddTransient<IFileService, FileService>();

            return services;
        }
    }
}
