using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FluentIsh.Builder.Source.Interfaces.Class;
using FluentIsh.Builder.Source.Interfaces.Shared.Delegates;
using FluentIsh.Builder.Source.Interfaces.Source;

[assembly: InternalsVisibleTo("FluentIsh.Builder.Source.Tests")]
namespace FluentIsh.Builder.Source
{
    public class SourceBuilder: ISourceDirectiveBuilder, ISourceRenderer, ISourceContentBuilder
    {
        private List<string> _directives;
        private string _namespace;
        private List<ClassBuilder> _classes;
        private List<DelegateBuilder> _delegates;
        private List<EnumBuilder> _enums;
        private List<InterfaceBuilder> _intefaces;
        private List<StructBuilder> _structs;
        private List<string> _customSections;
        #region Factory
        public static ISourceDirectiveBuilder GetBuilder()
        {
            return new SourceBuilder();
        }
        internal SourceBuilder()
        {
            _directives = new List<string>();
            _classes = new List<ClassBuilder>();
            _delegates = new List<DelegateBuilder>();
            _enums = new List<EnumBuilder>();
            _intefaces = new List<InterfaceBuilder>();
            _structs = new List<StructBuilder>();
            _customSections = new List<string>();
        }
        #endregion
        #region ISourceDirectiveBuilder
        public ISourceDirectiveBuilder Directive(string directiveNamespace)
        {
            _directives.Add(directiveNamespace);
            return this;
        }
        public ISourceContentBuilder Namespace(string namespaceName)
        {
            _namespace = namespaceName;
            return this;
        }
        #endregion
        #region ISourceContentBuilder
        public ISourceContentBuilder WithCustomSection(CustomSectionBuilderDelegate builder)
        {
            var cs = builder();
            _customSections.Add(cs);
            return this;
        }
        public ISourceContentBuilder WithClass(ClassBuilderDelegate builder)
        {
            var cb = builder(new ClassBuilder()) as ClassBuilder;
            _classes.Add(cb);
            return this;
        }
        public ISourceContentBuilder WithStruct(StructBuilderDelegate builder)
        {
            var sb = builder(new StructBuilder()) as StructBuilder;
            _structs.Add(sb);
            return this;
        }
        public ISourceContentBuilder WithEnum(EnumBuilderDelegate builder)
        {
            var eb = builder(new EnumBuilder()) as EnumBuilder;
            _enums.Add(eb);
            return this;
        }
        public ISourceContentBuilder WithDelegate(DelegateBuilderDelegate builder)
        {
            var db = builder(new DelegateBuilder()) as DelegateBuilder;
            _delegates.Add(db);
            return this;
        }
        public ISourceRenderer End()
        {
            return this;
        }
        #endregion
        #region ISourceRenderer
        public string Render()
        {
            StringBuilder sb = new StringBuilder();
            _directives.ForEach(dire=> sb.AppendLine($"using {dire};"));
            if(_directives.Any()) sb.AppendLine();
            sb.AppendLine($"namespace {_namespace}");
            sb.AppendLine("{");
            _delegates.ForEach(delegateBuilder=>sb.Append(delegateBuilder.Render(1)));
            _classes.ForEach(classBuilder=>sb.Append(classBuilder.Render(1)));
            _structs.ForEach(structBuilder=>sb.Append(structBuilder.Render(1)));
            _intefaces.ForEach(interfaceBuilder=>sb.Append(interfaceBuilder.Render(1)));
            _enums.ForEach(enumBuilder=>sb.Append(enumBuilder.Render(1)));
            _customSections.ForEach(customSection=>sb.Append(customSection));
            sb.AppendLine("}");
            return sb.ToString();
        }
        #endregion
    }
}