
using System;
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Shared;
using FluentIsh.Builder.Source.Interfaces.Struct;
using FluentIsh.Builder.Source.Interfaces.Struct.Delegates;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Struct.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class StructBuilder:IStructBuilder, ISourceObjectGenerator, IStructAccessibilityPicker
    {
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region IStructBuilder
        public IStructBuilder WithField(StructFieldBuilderDelegate structFieldBuilder)
        {
            throw new NotImplementedException();
        }
        public IStructBuilder WithProperty(StructPropertyBuilderDelegate structPropertyBuilder)
        {
            throw new NotImplementedException();
        }
        public IStructBuilder WithFunction(StructFunctionBuilderDelegate structFunctionBuilder)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region IStructAccessibilityPicker
        public IStructNamePicker Public()
        {
            throw new NotImplementedException();
        }
        public IStructNamePicker Internal()
        {
            throw new NotImplementedException();
        }
        public IStructNamePicker Private()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}