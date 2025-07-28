int[] array = { 1, 3, 5, 6, 6, 6, 7, 9};
int value = 1;
Console.WriteLine(BinarySearch(value, array));




static int BinarySearch(int value, int[] array)
{
    int left = 0;
    int right = array.Length - 1;    

    while (left <= right)
    {
        int middle = left + (right - left)/2;
        int midElement = array[middle];

        if(midElement == value)
        {
            return middle;
        }

        else if (value < midElement)
        {
            right = middle - 1;
        }

        else
        {
            left = middle + 1;
        }
    }

    return -1;
}