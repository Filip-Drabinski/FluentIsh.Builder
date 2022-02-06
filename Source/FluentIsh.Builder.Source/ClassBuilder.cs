using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Class;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Class.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class ClassBuilder: ISourceObjectGenerator, IClassAccessibilityPicker
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
    }
}