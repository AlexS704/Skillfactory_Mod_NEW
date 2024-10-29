
using Final_Tasks_Mod9;

namespace Final_Tsks2_v1_Mod9
{
    internal class Program
    {
        public class WorldSorter
        {
            private List<string> _list = new List<string>();

            //Делегаты для событий
            public delegate void SortHandler();

            //События для сортировок
            public event SortHandler OnSortAscending;
            public event SortHandler OnSortDescending;

            public WorldSorter(List<string> list)
            {
                _list = list;
            }

            //Метод для запуска события сортировки в прямом порядке порядке
            public void SortAscending()
            {
                OnSortAscending?.Invoke();
            }

            public void SortDescending()
            {
                OnSortDescending?.Invoke();
            }

            //Методы-обработчики событий
            public void AscendingSort()
            {
                _list.Sort();
            }

            public void DescendingSort()
            {
                _list.Sort((x, y) => y.CompareTo(x));
            }

            //Вспомогательный метод для вывода списка
            public void PrintList()
            {
                Console.WriteLine("Отсортированный список:");
                foreach (var item in _list)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            List<string> listFamily = new List<string>();
            try
            {
                var exception = new MyCustomException("Ощибка:....");
                int i = 0;
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Введите {i + 1} фамилию и нажмите Enter");
                    string Surname = Console.ReadLine();
                    listFamily.Add(Surname);
                }                
            }                
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var sorter = new WorldSorter(listFamily);

            //Подписка на события
            sorter.OnSortAscending += sorter.AscendingSort;
            sorter.OnSortDescending += sorter.DescendingSort;

            bool exit = false;

            while (!exit)
            {
                try
                {
                    Console.WriteLine("Для сортировки списка А-Я введите 1. Для сортировки списка от Я-А введите 2. Для выхода из программы введит 0");
                    int tag = Convert.ToInt32(Console.ReadLine());

                    switch (tag)
                    {
                        case 1: sorter.SortAscending();
                            sorter.PrintList(); break;
                        case 2: sorter.SortDescending();
                            sorter.PrintList(); break;
                        case 0: exit = true; return;
                        default:
                            Console.WriteLine("Неверный ввод.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ошибка формата: {ex.Message}");
                }
                finally
                {
                   Console.WriteLine("Продолжаем работу...");
                }

            }
                    
        }
    }
        
}
