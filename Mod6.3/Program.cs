namespace Mod6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            // logic;
        }

        class Company
        {
            public string Type = "Банк";
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name = "Санкт-Петербург";
        }

        class Triangle
        {
            public double a;
            public double b;
            public double c;

            public void Perimeter(double a, double b, double c)
            {
                double result = a + b + c;
            }

            public void Area(double a, double b, double c)
            {
                double semiperimeter = (a + b + c)/2;

                double result = Math.Sqrt(semiperimeter*(semiperimeter - a)*(semiperimeter - b)*(semiperimeter - c));

            }

        }

        class Circle
        {
            public double radius;

            public void Circumference(double radius)
            {
                double result = 2*Math.PI*radius;
            }

            public void Area(double radius)
            {
                double result = 2 * Math.PI * Math.Pow(radius,2);
            }
        }

        class Square
        {
            public double a;

            public void Area(double a)
            {
                double result = a * a;
            }

            public void Perimeter(double a)
            {
                double result = a * 4;
            }

        }
    }

}
