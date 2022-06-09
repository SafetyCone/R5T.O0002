using System;
using System.Threading.Tasks;

using R5T.D0083;
using R5T.T0020;


namespace R5T.O0002
{
    [OperationMarker]
    public class GetRecursiveDependenciesCount : IOperation
    {
        private IVisualStudioProjectFileReferencesProvider VisualStudioProjectFileReferencesProvider { get; }


        public GetRecursiveDependenciesCount(
            IVisualStudioProjectFileReferencesProvider visualStudioProjectFileReferencesProvider)
        {
            this.VisualStudioProjectFileReferencesProvider = visualStudioProjectFileReferencesProvider;
        }

        public async Task<int> Run(
            string projectFilePath)
        {
            var recursiveProjectReferences = await this.VisualStudioProjectFileReferencesProvider.GetAllRecursiveProjectReferenceDependencies_Exclusive(
                projectFilePath); // Use exclusive to only report dependency count, not dependency count + 1.

            var output = recursiveProjectReferences.Length;
            return output;
        }
    }
}
