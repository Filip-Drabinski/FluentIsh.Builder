using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;

namespace FluentIsh.Builder.Source.Interfaces.Source
{
    public interface ISourceContentBuilder
    {
        ISourceContentBuilder WithCustomSection(CustomSectionBuilderDelegate builder);
        ISourceContentBuilder WithClass(ClassBuilderDelegate builder);
        //ISourceContentBuilder WithStruct(StructBuilderDelegate builder);
        //ISourceContentBuilder WithEnum(EnumBuilderDelegate builder);
        //ISourceContentBuilder WithDelegate(DelegateBuilderDelegate builder);
        ISourceRenderer End();
    }
}