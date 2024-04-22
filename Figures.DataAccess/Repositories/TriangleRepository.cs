using Figures.Application.Validation;
using Figures.Domain.Abstractions;

namespace Figures.DataAccess.Repositories
{
    public class TriangleRepository : IShape
    {
        private readonly TriangleValidator _validator;
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public TriangleRepository(double side1, double side2, double side3)
        {
            _validator = new TriangleValidator();
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public double CalculateArea()
        {
            ValidationResult validation = _validator.CheckForPositiveSides(_side1, _side2, _side3);
            if (!validation.IsValid)
            {
                throw new ArgumentException(validation.Message);
            }

            double area;
            validation = _validator.CheckForRightTriangle(_side1, _side2, _side3);
            if (validation.IsValid)
            {
                area = CalculateRightTriangleArea(_side1, _side2, _side3);
            }
            else
            {
                area = CalculateNonRightTriangleArea(_side1, _side2, _side3);
            }

            return area;
        }

        private double CalculateRightTriangleArea(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return (sides[0] * sides[1]) / 2;
        }

        private double CalculateNonRightTriangleArea(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

    }
}
