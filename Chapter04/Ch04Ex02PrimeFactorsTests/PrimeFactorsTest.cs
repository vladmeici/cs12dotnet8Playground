using Ch04Ex02PrimeFactorsLib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ch04Ex02PrimeFactorsTests;

public class PrimeFactorsTest
{
    [Fact]
    public void PrimeFactorsOf7()
    {
        // Arrange
        int number = 7;
        string expected = "Prime factor of 7 is 7";

        // Act
        string actual = Primes.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf30()
    {
        // Arrange
        int number = 30;
        string expected = "Prime factors of 30 are 5 x 3 x 2";

        // Act
        string actual = Primes.PrimeFactors(number);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf40()
    {
        // arrange
        int number = 40;
        string expected = "Prime factors of 40 are 5 x 2 x 2 x 2";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf99()
    {
        // arrange
        int number = 99;
        string expected = "Prime factors of 99 are 11 x 3 x 3";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf519()
    {
        // arrange
        int number = 519;
        string expected = "Prime factors of 519 are 173 x 3";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf997()
    {
        // arrange
        int number = 997;
        string expected = "Prime factor of 997 is 997";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf1000()
    {
        // arrange
        int number = 1000;
        string expected = "Prime factors of 1000 are 5 x 5 x 5 x 2 x 2 x 2";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PrimeFactorsOf1001()
    {
        // arrange
        int number = 1001;
        string expected = "Prime factors of 1001 are 13 x 11 x 7";

        // act
        string actual = Primes.PrimeFactors(number);

        // assert
        Assert.Equal(expected, actual);
    }
}