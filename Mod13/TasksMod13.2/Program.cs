using System.Collections;

namespace TasksMod13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var list = new ArrayList() { 2, "Lol" };

            //list.Add(2.3);
            //list.Add(55);
            //list.AddRange(new string[] { "Hello", "world" });

            //foreach (var item in list)
            //    Console.WriteLine(item);

            //Console.WriteLine();

            //list.Add("again!");

            //// отрежем часть длиной в 3 элемента, начиная с четвертого
            //var slice = list.GetRange(4, 3);

            //foreach (var item in slice)
            //    Console.WriteLine(item);

            //пример получения неизвестного элемента по индексу
            var arlist = new ArrayList();
            //{
            //    1,
            //    "Андрей",
            //    300,
            //    4.5f
            //};

            //int firstElement = (int) arlist[0];
            //Console.WriteLine(firstElement);

            //string secondElement = (string) arlist[1];
            //Console.WriteLine(secondElement);

            //var firstElementVar = arlist[0];
            //var secondElementVar = arlist[1];

            //arlist[0] = "Диана";
            //arlist[1] = 100;

            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun",
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
               1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i < months.Length)
            //    {
            //        arlist.Add(months[i]);
            //    }

            //    if (i < numbers.Length)
            //    {
            //        arlist.Add((int) numbers[i]);
            //    }
            //}

            //foreach (var ar in arlist)
            //{
            //    Console.WriteLine(ar);
            //}

            foreach (var number in numbers)
            {
                arlist.Add(months[number - 1]);

                arlist.Add(number);
            }

            foreach (var value in arlist)
            {
                Console.WriteLine(value);
            }
        }
        static void GetArray(ArrayList input)
        {
            var resultArray = new ArrayList();

            foreach (var item in input)
            {


            }    
        }
    }

    
}
