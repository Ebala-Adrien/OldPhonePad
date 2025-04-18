using Xunit;

namespace OldPhonePad.Tests
{
    public class OldPhonePadTests
    {
        // Tests provided in the assignment
        [Theory]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("222222222", "C")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        public void Decode_WithValidInput_ReturnsExpectedOutput(string input, string expected)
        {
            // Act
            var result = OldPhonePad.Decode(input);

            // Assert
            Assert.Equal(expected, result);
        }

        // Additional test cases for cycling through letters. For example, pressing 2 four times will return A.
        [Theory]
        [InlineData("2", "A")]
        [InlineData("22", "B")]
        [InlineData("222", "C")]
        [InlineData("2222", "A")]
        public void Decode_WithCyclingLetters_ReturnsExpectedOutput(string input, string expected)
        {
            // Act
            var result = OldPhonePad.Decode(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
} 