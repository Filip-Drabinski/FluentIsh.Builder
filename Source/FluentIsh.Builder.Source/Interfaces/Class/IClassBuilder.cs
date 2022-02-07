using FluentIsh.Builder.Source.Interfaces.Class.Delegates;
using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;

namespace FluentIsh.Builder.Source.Interfaces.Class
{
    public interface IClassBuilder
    {
        IClassBuilder WithCustomSection(CustomSectionBuilderDelegate builder);
        IClassBuilder WithClass(ClassBuilderDelegate builder);
        IClassBuilder WithField(ClassFieldBuilderDelegate classFieldBuilder);
        IClassBuilder WithProperty(ClassPropertyBuilderDelegate classPropertyBuilder);
        IClassBuilder WithFunction(ClassFunctionBuilderDelegate classFunctionBuilder);
        //IClassBuilder WithStruct(StructBuilderDelegate builder);
        //IClassBuilder WithEnum(EnumBuilderDelegate builder);
        //IClassBuilder WithDelegate(DelegateBuilderDelegate builder);
    }

}