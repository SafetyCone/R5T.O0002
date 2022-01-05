using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0078;
using R5T.D0079;
using R5T.D0083;
using R5T.D0101;
using R5T.T0020;


namespace R5T.O0002
{
    [OperationMarker]
    public class AddProjectReferencesToProject : IOperation
    {
        private IProjectRepository ProjectRepository { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private IVisualStudioProjectFileOperator VisualStudioProjectFileOperator { get; }
        private IVisualStudioProjectFileReferencesProvider VisualStudioProjectFileReferencesProvider { get; }
        private IVisualStudioSolutionFileOperator VisualStudioSolutionFileOperator { get; }


        public AddProjectReferencesToProject(
            IProjectRepository projectRepository,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            IVisualStudioProjectFileOperator visualStudioProjectFileOperator,
            IVisualStudioProjectFileReferencesProvider visualStudioProjectFileReferencesProvider,
            IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator)
        {
            this.ProjectRepository = projectRepository;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.VisualStudioProjectFileOperator = visualStudioProjectFileOperator;
            this.VisualStudioProjectFileReferencesProvider = visualStudioProjectFileReferencesProvider;
            this.VisualStudioSolutionFileOperator = visualStudioSolutionFileOperator;
        }

        public async Task Run(
            string projectToModifyFilePath,
            IList<string> projectReferencesToAddIdentityStrings)
        {
            await Instances.ProjectOperator.AddProjectReferencesToProject(
                projectToModifyFilePath,
                projectReferencesToAddIdentityStrings,
                this.ProjectRepository,
                this.StringlyTypedPathOperator,
                this.VisualStudioProjectFileOperator,
                this.VisualStudioProjectFileReferencesProvider,
                this.VisualStudioSolutionFileOperator);
        }
    }
}
