void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(100,999);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            {
                count++;
            }
    }
Console.WriteLine("Чётных чисел в массиве: " + count);