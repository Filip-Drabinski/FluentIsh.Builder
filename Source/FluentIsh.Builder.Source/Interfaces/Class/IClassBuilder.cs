using FluentIsh.Builder.Source.Interfaces.Class.Delegates;
using FluentIsh.Builder.Source.Interfaces.Shared;
using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;

namespace FluentIsh.Builder.Source.Interfaces.Class
{
    public interface IClassBuilder
    {
        IClassBuilder WithField(ClassFieldBuilderDelegate classFieldBuilder);
        IClassBuilder WithProperty(ClassPropertyBuilderDelegate classPropertyBuilder);
        IClassBuilder WithFunction(ClassFunctionBuilderDelegate classFunctionBuilder);
        IClassBuilder WithClass(ClassBuilderDelegate builder);
        IClassBuilder WithStruct(StructBuilderDelegate builder);
        IClassBuilder WithEnum(EnumBuilderDelegate builder);
        IClassBuilder WithDelegate(DelegateBuilderDelegate builder);
        IClassBuilder WithClass(CustomSectionBuilderDelegate builder);
    }

}