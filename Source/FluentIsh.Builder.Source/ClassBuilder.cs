using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Class;
using FluentIsh.Builder.Source.Interfaces.Class.Delegates;
using FluentIsh.Builder.Source.Interfaces.Shared;
using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Class.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class ClassBuilder:IClassBuilder, ISourceObjectGenerator, IClassAccessibilityPicker
    {
        public ClassBuilder()
        {
            
        }
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new System.NotImplementedException();
        }
        #endregion
        #region IClassAccessibilityPicker
        public IClassStaticAndNamePicker Public()
        {
            throw new System.NotImplementedException();
        }

        public IClassStaticAndNamePicker Internal()
        {
            throw new System.NotImplementedException();
        }

        public IClassStaticAndNamePicker Private()
        {
            throw new System.NotImplementedException();
        }
        #endregion
        #region IClassBuilder



        public IClassBuilder WithField(ClassFieldBuilderDelegate classFieldBuilder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithProperty(ClassPropertyBuilderDelegate classPropertyBuilder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithFunction(ClassFunctionBuilderDelegate classFunctionBuilder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithCustomSection(CustomSectionBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithClass(ClassBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithStruct(StructBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithEnum(EnumBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }

        public IClassBuilder WithDelegate(DelegateBuilderDelegate builder)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}