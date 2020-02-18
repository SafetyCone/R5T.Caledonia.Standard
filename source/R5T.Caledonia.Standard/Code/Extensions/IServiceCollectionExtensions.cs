using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Caledonia.Default;


namespace R5T.Caledonia.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ICommandLineInvocationOperator"/> service.
        /// </summary>
        public static IServiceCollection AddCommandLineInvocationOperator(this IServiceCollection services)
        {
            services.AddDefaultCommandLineInvocationOperator();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ICommandLineInvocationOperator"/> service.
        /// </summary>
        public static ServiceAction<ICommandLineInvocationOperator> AddCommandLineInvocationOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICommandLineInvocationOperator>(() => services.AddCommandLineInvocationOperator());
            return serviceAction;
        }
    }
}
