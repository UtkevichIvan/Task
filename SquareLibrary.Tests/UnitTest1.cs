using SquareLibrary;

namespace SquareLibrary.Tests;

public class LibraryTests
{
    [Fact]
    public void Square_RectangleTriangle()
    {
        var a = 5.0;
        var b = 4.0;
        var c = 3.0;

        var result = Square.GetSquare(Figure.Triangle, a, b, c);

        Assert.Equal(result, 6);
    }

    [Fact]
    public void Square_Triangle()
    {
        var a = 5.0;
        var b = 5.0;
        var c = 6.0;

        var result = Square.GetSquare(Figure.Triangle, a, b, c);

        Assert.Equal(result, 12);
    }

    [Fact]
    public void Square_InvalidSides()
    {
        var a = 1.0;
        var b = 1.0;
        var c = 3.0;

        Assert.Throws<ArgumentOutOfRangeException>(() => Square.GetSquare(Figure.Triangle, a, b, c));
    }

    [Fact]
    public void Square_NonPositiveSides()
    {
        var a = -1.0;
        var b = 0.0;
        var c = 3.0;

        Assert.Throws<ArgumentOutOfRangeException>(() => Square.GetSquare(Figure.Triangle, a, b, c));
    }

    [Fact]
    public void Square_Circle()
    {
        var radius = 5;

        var result = Square.GetSquare(Figure.Circle, radius);

        Assert.Equal(result / Math.PI, 25);
    }

    [Fact]
    public void Square_NonPositiveRadius()
    {
        var radius = -5;

        Assert.Throws<ArgumentOutOfRangeException>(() => Square.GetSquare(Figure.Circle, radius));
    }
}