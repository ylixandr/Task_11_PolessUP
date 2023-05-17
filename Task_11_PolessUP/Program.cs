    static void SortAscending(int[] array)
    {
        

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
int[] array = new int[] { 2, 4, 6, 1, 88, 19 };
SortAscending(array);
for (int i = 0; i<array.Length;i++)
{
    Console.WriteLine(array[i]);
}

