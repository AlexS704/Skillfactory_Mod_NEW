using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Final_Tasks2_Mod9
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            List<string> arrayFamily = new List<string>();

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите {i+1} фамилию и нажмите Enter");
                string Surname = Console.ReadLine();
                arrayFamily.Add(Surname);
            }

            Console.WriteLine("Для сортировки списка А-Я введите 1. Для сортировки списка от Я-А введите 2");
            int tag = Convert.ToInt32(Console.ReadLine());

            MethodSort mS = new MethodSort();
            mS.ProcessCompleted += mS_ProcessCompleted;
            mS.SortList(arrayFamily, tag);
        }

        public static void mS_ProcessCompleted(){}
        public delegate void Notify();

        public class MethodSort
        {
            public event Notify ProcessCompleted;
            
            public void SortList(List<string> arrayFamily, int tag)
            {
                if (arrayFamily != null & tag == 1)
                {
                    arrayFamily.Sort();
                    foreach (var family in arrayFamily)
                    {
                        Console.WriteLine(family);
                    }
                }

                if (arrayFamily != null & tag == 2)
                {
                    arrayFamily.Sort((x, y) => y.CompareTo(x));
                    foreach (var family_1 in arrayFamily)
                    {
                        Console.WriteLine(family_1);

                    }
                }
                ProcessCompleted?.Invoke();
               
            }




        }

    }

    
}
