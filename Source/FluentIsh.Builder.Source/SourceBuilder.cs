using FluentIsh.Builder.Source.Interfaces;
using FluentIsh.Builder.Source.Interfaces.Source;

namespace FluentIsh.Builder.Source
{
    public class SourceBuilder : ISourceBuilder
    {

        public static ISourceBuilder GetBuilder()
        {
            return new SourceBuilder();
        }

        private SourceBuilder()
        {

        }

        public ISourceBuilder Directive(string dependencyNamespace)
        {
            throw new System.NotImplementedException();
        }

        public ISourceContentBuilder Namespace(string namespaceName)
        {
            throw new System.NotImplementedException();
        }
    }
}