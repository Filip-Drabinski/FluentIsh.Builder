namespace FluentIsh.Builder.Source.Interfaces.Source
{
    public interface ISourceDirectiveBuilder
    {
        ISourceDirectiveBuilder Directive(string dependencyNamespace);
        ISourceContentBuilder Namespace(string namespaceName);
    }
}