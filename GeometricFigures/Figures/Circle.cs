using GeometricFigures.Abstractions;

namespace GeometricFigures.Figures;

public class Circle : IFigure
{
    #region Public Properties

    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }

    #endregion

    #region Constructors

    /// <summary>
    /// Создание круга по умолчанию
    /// </summary>
    public Circle()
        => Radius = 1d;

    /// <summary>
    /// Создание круга с заданным радиусом
    /// <param name="radius">Радиус круга</param>
    /// <exception cref="ArgumentOutOfRangeException">Если радиус круга меньше единицы</exception>
    /// </summary>
    public Circle(double radius)
    {
        if (radius < .1d)
            throw new ArgumentOutOfRangeException();
            
        Radius = radius;
    }

    #endregion

    #region Public Methods

    public double GetArea()
        => Math.PI * Math.Pow(Radius, 2);

    #endregion
    
}