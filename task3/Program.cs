void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(-100,100);
        index++;
    }

}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double[] array = new double[5];

FillArray(array);
PrintArray(array);

Console.WriteLine();

double max = array.Max();
Console.WriteLine("Максимальный эллемент массива: " + max);

double min = array.Min();
Console.WriteLine("Минимальный эллемент массива: " + min);

Console.WriteLine("Разницу между максимальным и минимальным элементов массивa: " + (array.Max() - array.Min()));
