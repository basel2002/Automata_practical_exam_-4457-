using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

public class IsOddLengthPalindromeTests
{
    [Fact]
    public void IsOddLengthPalindrome_ValidOddLengthPalindrome_ReturnsTrue()
    {
        
        string input = "radar";
        
        bool result = Program.IsOddLengthPalindrome(input);

        Assert.True(result);
    }

    [Fact]
    public void IsOddLengthPalindrome_EvenLengthString_ReturnsFalse()
    {
        
        string input = "abba";
        
        bool result = Program.IsOddLengthPalindrome(input);

        Assert.False(result);
    }

    [Fact]
    public void IsOddLengthPalindrome_NonPalindromeOddLength_ReturnsFalse()
    {
         
        string input = "abaab";

        bool result = Program.IsOddLengthPalindrome(input);

        Assert.False(result);
    }

    [Fact]
    public void IsOddLengthPalindrome_SingleCharacter_ReturnsTrue()
    {
      
        string input = "a";

        bool result = Program.IsOddLengthPalindrome(input);

        Assert.True(result);
    }

    [Fact]
    public void IsOddLengthPalindrome_EmptyString_ReturnsFalse()
    {
        
        string input = "";

        bool result = Program.IsOddLengthPalindrome(input);

        Assert.False(result);
    }

    [Fact]
    public void IsOddLengthPalindrome_ThreeCharacterNonPalindrome_ReturnsFalse()
    {
        string input = "abc";

        bool result = Program.IsOddLengthPalindrome(input);

        Assert.False(result);
    }
}