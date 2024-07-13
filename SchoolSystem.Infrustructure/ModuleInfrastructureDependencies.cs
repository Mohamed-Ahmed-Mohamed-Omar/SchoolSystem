using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Data.Entities.Views;
using SchoolSystem.Infrustructure.Abstracts;
using SchoolSystem.Infrustructure.Abstracts.Functions;
using SchoolSystem.Infrustructure.Abstracts.Procedures;
using SchoolSystem.Infrustructure.Abstracts.Views;
using SchoolSystem.Infrustructure.InfrastructureBases;
using SchoolSystem.Infrustructure.Repositories;
using SchoolSystem.Infrustructure.Repositories.Functions;
using SchoolSystem.Infrustructure.Repositories.Procedures;
using SchoolSystem.Infrustructure.Repositories.Views;

namespace SchoolSystem.Infrustructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorsRepository, InstructorsRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            //views
            services.AddTransient<IViewRepository<ViewDepartment>, ViewDepartmentRepository>();

            //Procedure
            services.AddTransient<IDepartmentStudentCountProcRepository, DepartmentStudentCountProcRepository>();

            //functions
            services.AddTransient<IInstructorFunctionsRepository, InstructorFunctionsRepository>();

            return services;
        }
    }
}
