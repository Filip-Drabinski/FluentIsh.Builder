using FluentIsh.Builder.Source.Interfaces.Struct.Delegates;

namespace FluentIsh.Builder.Source.Interfaces.Struct
{
    public interface IStructBuilder
    {

        IStructBuilder WithField(StructFieldBuilderDelegate structFieldBuilder);
        IStructBuilder WithProperty(StructPropertyBuilderDelegate structPropertyBuilder);
        IStructBuilder WithFunction(StructFunctionBuilderDelegate structFunctionBuilder);
    }
}