using System.Collections;

namespace Final_Tasks2_Mod9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList arrayList = new ArrayList();

            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите фамилию и нажмите Enter");
                string Surname = Console.ReadLine();
                arrayList.Add(Surname);
            }

            Console.WriteLine("Для сортировки списка А-Я введите 1. \n Для сортировки списка от Я-А введите 2");
            int tag = Convert.ToInt32(Console.ReadLine());
            
            SortList(arrayList, tag);
           
            public void SortList(ArrayList arrayList, int tag )
            {
                if (arrayList != null & tag == 1)
                {
                    arrayList.Sort()
                }
            }
        }
    }
}
