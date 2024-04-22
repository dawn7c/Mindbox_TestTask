using Figures.Domain.Models;

namespace Figures.Application.Validation
{
    public class TriangleValidator
    {
        
        public ValidationResult CheckForPositiveSides(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                return new ValidationResult("Длины сторон треугольника должны быть положительными числами.", false);
            }
            return new ValidationResult("Валидация пройдена успешно", true);
        }

        public ValidationResult CheckForRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
            {
                return new ValidationResult("Треугольник является прямоугольным", true);
            }
            else
            {
                return new ValidationResult("Треугольник не является прямоугольным", false);
            }
        }
    }
}
