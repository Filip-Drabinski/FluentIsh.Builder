
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Enum;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Enum.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class EnumBuilder:IEnumBuilder, ISourceObjectGenerator, IEnumAccessibilityPicker
    {
        #region IEnumBuilder
        #endregion
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new System.NotImplementedException();
        }
        #endregion
        #region IEnumAccessibilityPicker
        public IEnumNamePicker Public()
        {
            throw new System.NotImplementedException();
        }
        public IEnumNamePicker Internal()
        {
            throw new System.NotImplementedException();
        }
        public IEnumNamePicker Private()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}