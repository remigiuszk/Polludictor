using MediatR;
using Polludictor.Applicaton.Commands;
using Polludictor.Applicaton.Commands.DataRows;

namespace Polludictor.API.DependencyIncjection
{
    public static partial class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddMediatR(x => x.AsScoped(), typeof(IdentifiedCommand<,>), typeof(AddDataRowCommandHandler));

            return services;
        }
    }
}
