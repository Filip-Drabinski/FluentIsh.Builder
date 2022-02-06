using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;
using FluentIsh.Builder.Source.Interfaces.Source;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Tests")]
namespace FluentIsh.Builder.Source
{
    public class SourceBuilder: ISourceDirectiveBuilder, ISourceRenderer, ISourceContentBuilder
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

        #region ISourceRenderer
        public string Render()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region ISourceContentBuilder
        public ISourceContentBuilder WithClass(ClassBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }
        public ISourceContentBuilder WithStruct(StructBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }
        public ISourceContentBuilder WithEnum(EnumBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }
        public ISourceContentBuilder WithDelegate(DelegateBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }
        public ISourceContentBuilder WithClass(CustomSectionBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }
        public ISourceRenderer End()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}