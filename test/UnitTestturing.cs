using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

public class RecognizeLanguageTests
{
    [Fact]
    public void RecognizeLanguage_ValidPattern_ReturnsTrue()
    {
        
        string input = "00110011"; 

        bool result = Program.TuringMachineRecognize(input);

        Assert.True(result);
    }

    [Fact]
    public void RecognizeLanguage_EmptyString_ReturnsTrue()
    {
      
        string input = ""; 
        
        bool result = Program.TuringMachineRecognize(input);

        Assert.True(result);
    }

    [Fact]
    public void RecognizeLanguage_LengthNotMultipleOfFour_ReturnsFalse()
    {
        
        string input = "001";

        bool result = Program.TuringMachineRecognize(input);

        Assert.False(result);
    }

    [Fact]
    public void RecognizeLanguage_WrongFirstSegment_ReturnsFalse()
    {
        
        string input = "10110011";

        bool result = Program.TuringMachineRecognize(input);

        Assert.False(result);
    }

    [Fact]
    public void RecognizeLanguage_WrongSecondSegment_ReturnsFalse()
    {
        
        string input = "00001111";

        bool result = Program.TuringMachineRecognize(input);

        Assert.False(result);
    }

    [Fact]
    public void RecognizeLanguage_WrongThirdSegment_ReturnsFalse()
    {
        
        string input = "00111111"; 

        bool result = Program.TuringMachineRecognize(input);

        Assert.False(result);
    }

    [Fact]
    public void RecognizeLanguage_WrongFourthSegment_ReturnsFalse()
    {
        
        string input = "00110010"; 

        bool result = Program.TuringMachineRecognize(input);

        Assert.False(result);
    }

    [Fact]
    public void RecognizeLanguage_SmallestNonEmptyValidPattern_ReturnsTrue()
    {
        
        string input = "0101";

        bool result = Program.TuringMachineRecognize(input);

        Assert.True(result);
    }
}