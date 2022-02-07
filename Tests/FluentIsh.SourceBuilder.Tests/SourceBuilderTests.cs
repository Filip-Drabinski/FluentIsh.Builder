using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
namespace FluentIsh.Builder.Source.Tests
{
    public class SourceBuilderTests
    {
        #region Render.Namespace
        [Fact]
        public void Render_ShouldRender_WithOnlyNamespace()
        {
            //Arrange
            var expected =
@"namespace Testing
{
}
";
            var sut = SourceBuilder.GetBuilder().Namespace("Testing").End();
            //Act
            var actual = sut.Render();
            //Assert
            actual.Should().Be(expected);
        }
        #endregion
        #region Render.Directive
        [Fact]
        public void Render_ShouldRender_WithSingleDirective()
        {
            //Arrange
            var expected =
@"using System;

namespace Testing
{
}
";
            var sut = SourceBuilder.GetBuilder().Directive("System").Namespace("Testing").End();
            //Act
            var actual = sut.Render();
            //Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void Render_ShouldRender_WithMultipleDirective()
        {
            //Arrange
            var expected =
@"using System;
using System.Diagnostics;

namespace Testing
{
}
";
            var sut = SourceBuilder.GetBuilder().Directive("System").Directive("System.Diagnostics").Namespace("Testing").End();
            //Act
            var actual = sut.Render();
            //Assert
            actual.Should().Be(expected);
        }
        #endregion
        #region Namespace.Ok
        #region Theory
        [Theory]
        [InlineData("Test")]
        [InlineData("Test.Test2")]
        #endregion
        public void Namespace_ShouldWork_WhenValidValueIsProvided(string namespaceName)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Namespace(namespaceName); });
            //Assert
            task.Should().NotThrow();
        }
        #endregion
        #region Namespace.Fail
        [Fact]
        public void Namespace_ShouldThrowArgumentNullException_WhenNamespaceIsNull()
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Namespace(null); });
            //Assert
            task.Should().Throw<ArgumentNullException>().WithMessage("*?amespace*?ull*");
        }
        #region Theory
        [Theory]
        [InlineData(" ")]
        [InlineData("\t")]
        [InlineData("\n")]
        [InlineData("\r\n")]
        [InlineData("\n\r")]
        #endregion
        public void Namespace_ShouldThrowArgumentException_WhenNamespaceIsWhitespace(string namespaceName)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Namespace(namespaceName); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?amespace*?hitespace*");
        }
        [Fact]
        public void Namespace_ShouldThrowArgumentException_WhenNamespaceIsEmpty()
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Namespace(String.Empty); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?amespace*?mpty*");
        }


        [Theory]
        [MemberData(nameof(GetIllegalNamespaceAndUsingStartingCharacters))]
        public void Namespace_ShouldThrowArgumentException_WhenNamespaceSegmentStartsWithIllegalCharacter(string illegalNamespaceCharacter)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Namespace($"{illegalNamespaceCharacter}Test"); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?amespace*?tart*?llegal*");
        }
        #endregion
        #region Directive.Ok
        #region Theory
        [Theory]
        [InlineData("System")]
        [InlineData("System.Diagnostics")]
        #endregion
        public void Directive_ShouldWork_WhenValidValueIsProvided(string directiveNamespace)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Directive(directiveNamespace); });
            //Assert
            task.Should().NotThrow();
        }
        #endregion
        #region Directive.Fail
        [Fact]
        public void Directive_ShouldThrowArgumentNullException_WhenDirectiveIsNull()
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Directive(null); });
            //Assert
            task.Should().Throw<ArgumentNullException>().WithMessage("*?irective*?mpty*");
        }
        [Theory]
        #region InlineData
        [InlineData(" ")]
        [InlineData("\t")]
        [InlineData("\n")]
        [InlineData("\r\n")]
        [InlineData("\n\r")]
        #endregion
        public void Directive_ShouldThrowArgumentException_WhenDirectiveIsWhitespace(string directiveNamespace)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Directive(directiveNamespace); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?irective*?mpty*");
        }
        [Fact]
        public void Directive_ShouldThrowArgumentException_WhenDirectiveIsEmpty()
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Directive(String.Empty); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?irective*?mpty*");
        }

        [Theory]
        [MemberData(nameof(GetIllegalNamespaceAndUsingStartingCharacters))]
        public void Directive_ShouldThrowArgumentException_WhenNamespaceSegmentStartsWithIllegalCharacter(string illegalDirectiveCharacter)
        {
            //Arrange
            var sut = SourceBuilder.GetBuilder();
            //Act
            var task = new Action(() => { sut.Directive($"{illegalDirectiveCharacter}Test"); });
            //Assert
            task.Should().Throw<ArgumentException>().WithMessage("*?irective*?tart*?llegal*");
        }
        #endregion
        #region TestData
        public static IEnumerable<object[]> GetIllegalNamespaceAndUsingStartingCharacters()
        {
            yield return new object[] { "`" };
            yield return new object[] { "~" };
            yield return new object[] { "!" };
            yield return new object[] { "@" };
            yield return new object[] { "#" };
            yield return new object[] { "$" };
            yield return new object[] { "%" };
            yield return new object[] { "^" };
            yield return new object[] { "&" };
            yield return new object[] { "*" };
            yield return new object[] { "(" };
            yield return new object[] { ")" };
            yield return new object[] { "-" };
            yield return new object[] { "-" };
            yield return new object[] { "=" };
            yield return new object[] { "+" };
            yield return new object[] { "[" };
            yield return new object[] { "{" };
            yield return new object[] { "]" };
            yield return new object[] { "}" };
            yield return new object[] { "\\" };
            yield return new object[] { "|" };
            yield return new object[] { ";" };
            yield return new object[] { ":" };
            yield return new object[] { "'" };
            yield return new object[] { "\""};
            yield return new object[] { "," };
            yield return new object[] { "<" };
            yield return new object[] { "." };
            yield return new object[] { ">" };
            yield return new object[] { "/" };
            yield return new object[] { "?" };
            yield return new object[] { "1" };
            yield return new object[] { "2" };
            yield return new object[] { "3" };
            yield return new object[] { "4" };
            yield return new object[] { "5" };
            yield return new object[] { "6" };
            yield return new object[] { "7" };
            yield return new object[] { "8" };
            yield return new object[] { "9" };
            yield return new object[] { "0" };
        }
        #endregion
    }
}