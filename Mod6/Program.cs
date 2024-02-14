namespace Mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Data data = new Data {Name = "Запись", Length = 10, Version = 1, Array = new int[] {15, 30} };
            Obj obj = new Obj {Name = "Стол", IsAlive = false, Weight = 15 };

            var dataCopy = data;
            var objCopy = obj;

            data.Name = "Значение";
            data.Length = 35;
            data.Version = 2;
            data.Array[0] = 0;

            obj.Name = "Кот";
            obj.IsAlive = true;
            obj.Weight = 3;

            objCopy = new Obj { Name = obj.Name, IsAlive = obj.IsAlive, Weight = obj.Weight };

            obj.Name = "Стол";
            obj.IsAlive = false;
            obj.Weight = 15;

            Console.ReadKey();

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

    struct Data
    {
        public string Name;
        public int Length;
        public int Version;
        public int[] Array;

    }

    class Obj
    {
        public string Name;
        public bool IsAlive;
        public int Weight;

    }


}
