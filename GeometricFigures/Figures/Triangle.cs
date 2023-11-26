using GeometricFigures.Abstractions;

namespace GeometricFigures.Figures;

public class Triangle : IFigure
{
    #region Public Properties

    /// <summary>
    /// Первая сторона треугольника
    /// </summary>
    public double SideA { get; }
    
    /// <summary>
    /// Вторая сторона треугольника
    /// </summary>
    public double SideB { get; }
    
    /// <summary>
    /// Третья сторона треугольника
    /// </summary>
    public double SideC { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Создание треугольника по умолчанию
    /// </summary>
    public Triangle()
        => SideA = SideB = SideC = 1d;
    
    /// <summary>
    /// Создание треугольника с указанием сторон
    /// <param name="sideA">Первая сторона треугольника</param>
    /// <param name="sideB">Вторая сторона треугольника</param>
    /// <param name="sideC">Третья сторона треугольника</param>
    /// <exception cref="ArgumentOutOfRangeException">Если хотя бы одна сторона треугольника меньше единицы</exception>
    /// <exception cref="ArgumentException">Указанные стороны не образуют треугольника</exception>
    /// </summary>
    public Triangle(double sideA, double sideB,double sideC)
    {
        if (sideA < 1 
            || sideB < 1 
            || sideC < 1)
            throw new ArgumentOutOfRangeException();
        
        if (sideA + sideB < sideC 
            || sideB + sideC < sideA 
            || sideA + sideC < sideB)
            throw new ArgumentException("Указанные стороны не образуют треугольника");
            
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    #endregion

    #region Public Methods

    public double GetArea()
    {
        var halfP = (SideA + SideB + SideC) / 2;
        
        return Math.Sqrt(
            halfP
            * (halfP - SideA)
            * (halfP - SideB)
            * (halfP - SideC)
        );
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным
    /// </summary>
    public bool IsRightTriangle()
        => (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) 
            || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) 
            || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
    

    #endregion
    
}