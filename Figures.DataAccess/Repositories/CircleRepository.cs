using Figures.Application.Validation;
using Figures.Domain.Abstractions;


namespace Figures.DataAccess.Repositories
{
    public class CircleRepository : IShape
    {
        private readonly CircleValidator _validator;
        private readonly double _radius;
        public CircleRepository(double radius)
        {
            _validator = new CircleValidator();
            _radius = radius;
        }
        public double CalculateArea()
        {
            ValidationResult validation = _validator.CheckForPositiveRadius(_radius);
            if (!validation.IsValid)
                throw new ArgumentException(validation.Message);
            return Math.PI * _radius * _radius;
        }
    }
}
