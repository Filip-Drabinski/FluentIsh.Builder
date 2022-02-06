
using System;
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Delegate;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Delegate.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class DelegateBuilder:IDelegateBuilder, ISourceObjectGenerator, IDelegateAccessibilityPicker
    {
        #region IDelegateBuilder
        #endregion
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region IDelegateAccessibilityPicker
        public IDelegateNamePicker Public()
        {
            throw new NotImplementedException();
        }
        public IDelegateNamePicker Internal()
        {
            throw new NotImplementedException();
        }
        public IDelegateNamePicker Private()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}