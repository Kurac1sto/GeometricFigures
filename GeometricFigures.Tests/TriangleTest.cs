namespace GeometricFigures.Tests;

public class TriangleTest
{
    [Fact]
    public void ZeroSideTest()
        => Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));

    [Fact]
    public void NegativeSideTest()
        => Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
    
    [Fact]
    public void NotTriangleTest()
        => Assert.Throws<ArgumentException>(() => new Triangle(5, 10, 1));

    [Fact]
    public void GetAreaTest()
    {
        var halfP = (5 + 5 + 6) / 2d;
        var result = Math.Sqrt(
            halfP
            * (halfP - 5)
            * (halfP - 5)
            * (halfP - 6)
        );
        
        var triangle = new Triangle(5, 5, 6);
        
        Assert.Equal(result, triangle.GetArea());
    }

    [Fact]
    public void GetAreaForDefaultTriangle()
    {
        var halfP = (1 + 1 + 1) / 2d;
        var result = Math.Sqrt(
            halfP
            * (halfP - 1)
            * (halfP - 1)
            * (halfP - 1)
        );
        
        var triangle = new Triangle();
        
        Assert.Equal(result, triangle.GetArea());
    }

    [Fact]
    public void IsRightTriangle()
        => Assert.True(new Triangle(5, 12, 13)
            .IsRightTriangle());
}