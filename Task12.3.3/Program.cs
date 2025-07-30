
namespace Task12._3._3
{
    
    // Реализуйте метод, который будет возвращать индекс элемента в отсортированном массиве, 
    // на место которого можно будет вставить элемент так, чтобы не нарушить порядок сортировки.  
    // Реализуйте метод, который будет возвращать индекс элемента в отсортированном массиве, 
    // и что числа в нём не повторяются;
    //при вставке элемента по индексу, который будет возвращен, оставшаяся часть массива будет сдвигаться вправо.
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = {1, 2, 3, 4, 5, 10, 12, 14, 19};
            //int element = 11;

            //int index = Array.BinarySearch(array, element);
            //Console.WriteLine(index);

            //if (index < 0) 
            //{ 
            //    index = ~index;
            //}

            //int[] newArray = new int[array.Length + 1];
            //Array.Copy(array, 0, newArray, 0, index);

            //newArray[index] = element;

            //Array.Copy(array, index, newArray, index + 1, array.Length-index);

            //Console.WriteLine(string.Join(", ", newArray));
        }

        static int GetIndex(int[] array, int element)
        {
            int index;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > element)
                    return index;
            }

            return index;
        }


    }
}
