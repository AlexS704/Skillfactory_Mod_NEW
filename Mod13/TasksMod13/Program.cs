namespace TasksMod13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetArray(new[] {1, 2, 3, 4, 5}));

            //Console.WriteLine(GetArray(new[] { 6, 5, 3, 4, 5 }));

            //13.1.6
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);            

            if (File.Exists("cdev_Text.txt"))
            {
                Console.WriteLine("Файл сущствует");
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }

        //13.1.4
        static bool GetArray(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }                            
            }
            return true;
        }
    }
}
