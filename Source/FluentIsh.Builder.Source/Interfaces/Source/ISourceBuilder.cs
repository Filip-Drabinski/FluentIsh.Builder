namespace FluentIsh.Builder.Source.Interfaces.Source
{
    public interface ISourceBuilder
    {
        ISourceBuilder Directive(string dependencyNamespace);
        ISourceContentBuilder Namespace(string namespaceName);
    }
}