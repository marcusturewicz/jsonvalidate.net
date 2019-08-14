using System;
using Xunit;
using JsonValidate.Helpers;

namespace JsonValidate.Test
{
    public class ErrorParserTests
    {
        [Fact]
        public void SingleCharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 1 | BytePositionInLine: 1.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(1, line);
            Assert.Equal(1, pos);
        }

        [Fact]
        public void DoubleCharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 11 | BytePositionInLine: 11.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(11, line);
            Assert.Equal(11, pos);
        }  

        [Fact]
        public void TripleCharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 111 | BytePositionInLine: 111.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(111, line);
            Assert.Equal(111, pos);
        }    

        [Fact]
        public void QuadCharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 1111 | BytePositionInLine: 1111.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(1111, line);
            Assert.Equal(1111, pos);
        }  

        [Fact]
        public void MixedCharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 1 | BytePositionInLine: 1111.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(1, line);
            Assert.Equal(1111, pos);
        }  

        [Fact]
        public void Mixed2CharactersParsesCorrectly()
        {
            // Arrange
            var message = "'l' is an invalid start of a property name. Expected a '\"'. Path: $ | LineNumber: 1111 | BytePositionInLine: 1.";

            // Act
            var (line, pos) = ErrorHelper.ParseError(message);

            // Assert
            Assert.Equal(1111, line);
            Assert.Equal(1, pos);
        }                
    }
}
