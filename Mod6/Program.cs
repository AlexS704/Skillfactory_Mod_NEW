namespace Mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;

        }

    }

    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;                       
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }



    }




}
