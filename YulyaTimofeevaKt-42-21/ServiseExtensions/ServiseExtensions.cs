using YulyaTimofeevaKt_42_21.Interfaces.StudentsInterfaces;

namespace YulyaTimofeevaKt_42_21.ServiseExtensions
{
    public static class ServiseExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
