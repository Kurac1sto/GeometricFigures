namespace GeometricFigures.Tests;

public class CircleTest
{
    [Fact]
    public void ZeroRadiusTest()
        => Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));

    [Fact]
    public void NegativeRadiusTest()
        => Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));

    [Fact]
    public void GetSquareTest()
    {
        var result = Math.PI * Math.Pow(6, 2);
        var circle = new Circle(6);
        
        Assert.Equal(result, circle.GetArea());
    }

    [Fact]
    public void GetSquareForDefaultCircle()
    {
        var result = Math.PI * Math.Pow(1, 2);
        var circle = new Circle();
        
        Assert.Equal(result, circle.GetArea());
    }
}