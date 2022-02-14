using System;

using R5T.T0055;
using R5T.T0113;


namespace R5T.O0002
{
    public static class Instances
    {
        public static IGuidOperator GuidOperator { get; } = T0055.GuidOperator.Instance;
        public static IProjectOperator ProjectOperator { get; } = T0113.ProjectOperator.Instance;
    }
}
