using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Whodo.Profile.Doman.Commands.v1.CreateProfile;
using Whodo.Profile.Doman.Interfaces.v1.Repository.Profile;
using Whodo.Profile.Doman.Queries.v1.GetProfile;
using Whodo.Profile.Infrastructure.Data.v1.Sql.Repositories.Profile;

namespace Whodo.Profile.Api.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        public static void Inject(this IServiceCollection services)
        {
            InjectMapper(services);
            InjectRepositories(services);
            InjectMediator(services);
        }

        public static void InjectMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(GetProfileQueryProfile));
            services.AddAutoMapper(typeof(CreateProfileQueryProfile));
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IProfileRepository, ProfileRepository>();
        }

        public static void InjectMediator(IServiceCollection services)
        {
            services.AddMediatR(typeof(GetProfileQuery).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateProfileQuery).GetTypeInfo().Assembly);
        }
    }
}
