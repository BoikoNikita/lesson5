void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(0,10);
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

int[] array = new int[6];

FillArray(array);
PrintArray(array);

Console.WriteLine();

var even = array.Where((element, index) => index % 2 != 0);
Console.WriteLine("Сумма чисел на четных местах: {0}", even.Sum());