﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.D0101;
using R5T.T0063;


namespace R5T.O0002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AddProjectReferencesToProject"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAddProjectReferencesToProject(this IServiceCollection services,
            IServiceAction<IProjectRepository> projectRepositoryAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction,
            IServiceAction<IVisualStudioProjectFileReferencesProvider> visualStudioProjectFileReferencesProviderAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            services
                .Run(projectRepositoryAction)
                .Run(stringlyTypedPathOperatorAction)
                .Run(visualStudioProjectFileOperatorAction)
                .Run(visualStudioProjectFileReferencesProviderAction)
                .Run(visualStudioSolutionFileOperatorAction)
                .AddSingleton<AddProjectReferencesToProject>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GetRecursiveDependenciesCount"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGetRecursiveDependenciesCount(this IServiceCollection services,
            IServiceAction<IVisualStudioProjectFileReferencesProvider> visualStudioProjectFileReferencesProviderAction)
        {
            services
                .Run(visualStudioProjectFileReferencesProviderAction)
                .AddSingleton<GetRecursiveDependenciesCount>();

            return services;
        }
    }
}
