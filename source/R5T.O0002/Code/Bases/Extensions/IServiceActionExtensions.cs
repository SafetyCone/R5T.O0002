using System;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.D0101;
using R5T.T0062;
using R5T.T0063;


namespace R5T.O0002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AddProjectReferencesToProject"/> operation as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<AddProjectReferencesToProject> AddAddProjectReferencesToProjectAction(this IServiceAction _,
            IServiceAction<IProjectRepository> projectRepositoryAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioProjectFileOperator> visualStudioProjectFileOperatorAction,
            IServiceAction<IVisualStudioProjectFileReferencesProvider> visualStudioProjectFileReferencesProviderAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = _.New<AddProjectReferencesToProject>(services => services.AddAddProjectReferencesToProject(
                projectRepositoryAction,
                stringlyTypedPathOperatorAction,
                visualStudioProjectFileOperatorAction,
                visualStudioProjectFileReferencesProviderAction,
                visualStudioSolutionFileOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="GetRecursiveDependenciesCount"/> operation as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<GetRecursiveDependenciesCount> AddGetRecursiveDependenciesCountAction(this IServiceAction _,
            IServiceAction<IVisualStudioProjectFileReferencesProvider> visualStudioProjectFileReferencesProviderAction)
        {
            var serviceAction = _.New<GetRecursiveDependenciesCount>(services => services.AddGetRecursiveDependenciesCount(
                visualStudioProjectFileReferencesProviderAction));

            return serviceAction;
        }
    }
}
