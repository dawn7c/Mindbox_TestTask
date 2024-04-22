namespace Figures.Domain.Models
{
    public class Triangle
    {
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double Hypotenuse { get; set; }

        public Triangle(double sideA, double sideB, double hypotenuse)
        {
            SideA = sideA;
            SideB = sideB;
            Hypotenuse = hypotenuse;
        }
    }
}
