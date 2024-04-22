using Figures.DataAccess.Repositories;

namespace Figures.Tests.DataAccess.Tests
{
    public class CircleRepositoryTest
    {
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5.3;
            CircleRepository circleRepository = new CircleRepository(radius);
            double area = circleRepository.CalculateArea();
            double expectedArea = Math.PI * radius * radius;
            Assert.Equal(expectedArea, area);
        }
    }
}
