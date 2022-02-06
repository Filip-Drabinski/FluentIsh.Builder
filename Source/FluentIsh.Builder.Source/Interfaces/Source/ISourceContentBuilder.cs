using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;

namespace FluentIsh.Builder.Source.Interfaces.Source
{
    public interface ISourceContentBuilder
    {
        ISourceContentBuilder WithClass(ClassBuilderDelegate builder);
        ISourceContentBuilder WithStruct(StructBuilderDelegate builder);
        ISourceContentBuilder WithEnum(EnumBuilderDelegate builder);
        ISourceContentBuilder WithDelegate(DelegateBuilderDelegate builder);
        ISourceContentBuilder WithClass(CustomSectionBuilderDelegate builder);
        ISourceRenderer End();
    }
}