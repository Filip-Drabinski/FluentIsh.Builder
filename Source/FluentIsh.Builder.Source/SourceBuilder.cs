using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Source;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Tests")]
namespace FluentIsh.Builder.Source
{
    public partial class SourceBuilder: ISourceDirectiveBuilder
    {
        public static ISourceDirectiveBuilder GetBuilder()
        {
            return new SourceBuilder();
        }
        internal SourceBuilder()
        {

        }
        #region ISourceDirectiveBuilder
        public ISourceDirectiveBuilder Directive(string dependencyNamespace)
        {
            throw new System.NotImplementedException();
        }

        public ISourceContentBuilder Namespace(string namespaceName)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}