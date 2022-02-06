using FluentIsh.Builder.Source.Interfaces.Source;

namespace FluentIsh.Builder.Source
{
    public partial class SourceBuilder: ISourceDirectiveBuilder
    {
        public ISourceDirectiveBuilder Directive(string dependencyNamespace)
        {
            throw new System.NotImplementedException();
        }

        public ISourceContentBuilder Namespace(string namespaceName)
        {
            throw new System.NotImplementedException();
        }
    }
    public partial class SourceBuilder
    {
    }
}