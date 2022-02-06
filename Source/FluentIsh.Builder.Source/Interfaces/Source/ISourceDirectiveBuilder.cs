namespace FluentIsh.Builder.Source.Interfaces.Source
{
    public interface ISourceDirectiveBuilder
    {
        ISourceDirectiveBuilder Directive(string directiveNamespace);
        ISourceContentBuilder Namespace(string namespaceName);
    }
}