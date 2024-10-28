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
            private void PrintList()
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

            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите {i + 1} фамилию и нажмите Enter");
                string Surname = Console.ReadLine();
                listFamily.Add(Surname);
            }

            var sorter = new WorldSorter(listFamily);

            //Подписка на события
            sorter.OnSortAscending += sorter.AscendingSort;
            sorter.OnSortDescending += sorter.DescendingSort;

            Console.WriteLine("Для сортировки списка А-Я введите 1. Для сортировки списка от Я-А введите 2");

            int tag = Convert.ToInt32(Console.ReadLine());

            switch (tag)
            {
                case 1: sorter.SortAscending(); break;
                case 2: sorter.SortDescending(); break;
                case 0: return;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
    }
        
}
