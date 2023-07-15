
using zslib;
using zsxunit.tests.data;

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

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, -1, int.MaxValue)]
    public void AddTheoryTest(int firstNum, int secondNum, int expected)
    {
        //Arrange
        //Act
        int actual = Calculator.Add(firstNum, secondNum);
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [ClassData(typeof(CalculatorTestClassData))]
    public void AddTheoryClassDataTest(int firstNum, int secondNum, int expected)
    {
        int actual = Calculator.Add(firstNum, secondNum);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(MemberData))]
    public void AddTheoryMemberData(int firstNum, int secondNum, int expected)
    {
        int actual = Calculator.Add(firstNum, secondNum);
        Assert.Equal(expected, actual);
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

    public static IEnumerable<object[]> MemberData()
    {
        List<object[]> list = new()
        {
            new object[] {1,2,3},
            new object[] {-4, -6, -10},
            new object[] { -2, 2, 0},
            new object[] { int.MinValue, -1, int.MaxValue}
        };
        return list;
    }

}