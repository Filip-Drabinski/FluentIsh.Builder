using System.Runtime.CompilerServices;
using FluentIsh.Builder.Source.Interfaces;
using FluentIsh.Builder.Source.Interfaces.Source;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Tests")]
namespace FluentIsh.Builder.Source
{
    public partial class SourceBuilder 
    {

        public static ISourceDirectiveBuilder GetBuilder()
        {
            return new SourceBuilder();
        }

        internal SourceBuilder()
        {

        }
    }
}