using Figures.DataAccess.Repositories;

namespace Figures.Tests.DataAccess.Tests
{
    public class TriangleRepositoryTest
    {
        [Fact]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            TriangleRepository triangleRepository = new TriangleRepository(side1, side2, side3);
            double area = triangleRepository.CalculateArea();
            Assert.Equal(6, area);
        }
    }
}
