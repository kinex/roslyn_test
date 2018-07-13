using Microsoft.CodeAnalysis.MSBuild;
using System.Collections.Immutable;

namespace RoslynLib
{
    public class SolutionInfoProvider
    {
        private MSBuildWorkspace _MSBuildWorkspace;

        public SolutionInfoProvider()
        {
            _MSBuildWorkspace = MSBuildWorkspace.Create(ImmutableDictionary<string, string>.Empty);
        }
    }
}
