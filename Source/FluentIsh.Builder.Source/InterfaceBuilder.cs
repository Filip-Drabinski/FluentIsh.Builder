
using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces.Shared;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Interface.Tests")]
namespace FluentIsh.Builder.Source
{
    internal partial class InterfaceBuilder: ISourceObjectGenerator
    {
        #region ISourceObjectGenerator
        public string Render(int nestingCount)
        {
            throw new System.NotImplementedException();
        }



        #endregion
    }
}