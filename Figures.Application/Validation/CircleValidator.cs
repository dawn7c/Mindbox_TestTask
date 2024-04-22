namespace Figures.Application.Validation
{
    public class CircleValidator
    {
        public ValidationResult CheckForPositiveRadius(double radius)
        {
            if (radius <= 0)
            {
                return new ValidationResult("Радиус должен быть положительным числом.", false);
            }
            return new ValidationResult("Валидация пройдена успешно", true);
        }
    }
}
