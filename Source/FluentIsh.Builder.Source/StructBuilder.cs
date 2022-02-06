
using System;
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Struct.Tests")]
namespace FluentIsh.Builder.Source
{
    internal partial class StructBuilder: ISourceObjectGenerator
    {
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}