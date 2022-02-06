using FluentIsh.Builder.Source.Interfaces.Source;

namespace FluentIsh.Builder.Source.Interfaces
{
    public interface ISourceBuilder
    {
        ISourceBuilder Directive(string dependencyNamespace);
        ISourceContentBuilder Namespace(string namespaceName);
    }
}