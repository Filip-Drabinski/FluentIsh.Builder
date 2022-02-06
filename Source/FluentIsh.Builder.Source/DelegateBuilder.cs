
using System;
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Delegate.Tests")]
namespace FluentIsh.Builder.Source
{
    internal class DelegateBuilder: ISourceObjectGenerator
    {
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}