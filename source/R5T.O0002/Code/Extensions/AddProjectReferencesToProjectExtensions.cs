using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.O0002;


namespace System
{
    public static class AddProjectReferencesToProjectExtensions
    {
        public static async Task Run(this AddProjectReferencesToProject addProjectReferencesToProject,
            string projectToModifyFilePath,
            string projectReferenceToAddIdentityString)
        {
            await addProjectReferencesToProject.Run(
                projectToModifyFilePath,
                ListHelper.From(projectReferenceToAddIdentityString));
        }

        public static async Task Run(this AddProjectReferencesToProject addProjectReferencesToProject,
            string projectToModifyFilePath,
            Guid projectReferenceToAddIdentity)
        {
            await addProjectReferencesToProject.Run(
                projectToModifyFilePath,
                Instances.GuidOperator.ToStringStandard(projectReferenceToAddIdentity));
        }

        public static async Task Run(this AddProjectReferencesToProject addProjectReferencesToProject,
            string projectToModifyFilePath,
            IEnumerable<Guid> projectReferencesToAddIdentities)
        {
            var guids = projectReferencesToAddIdentities
                .Select(Instances.GuidOperator.ToStringStandard)
                .Now();

            await addProjectReferencesToProject.Run(
                projectToModifyFilePath,
                guids);
        }
    }
}
