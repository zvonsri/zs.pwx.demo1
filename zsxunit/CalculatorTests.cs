
using zslib;

namespace zsxunit;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        //Arrange

        //Act
        int result = Calculator.Add(5, 3);
        //Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void SubtractTest()
    {
        //Arrange

        //Act
        int result = Calculator.Subtract(5, 3);
        //Assert
        Assert.Equal(2, result);
    }


    [Fact]
    public void MultiplyTest()
    {
        //Arrange

        //Act
        int result = Calculator.Multiply(5, 3);
        //Assert
        Assert.Equal(15, result);
    }

}