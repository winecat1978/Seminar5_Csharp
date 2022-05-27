// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int [] ArrayCreation(int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100,101);
    }
    return arr;
}

int [] Transformer(int [] array)
{
    int line = array.Length;
    for (int i = 0; i < line; i++)
    {
        if(array[i] != 0)
        {
            array[i] = - array[i];
        }
    }
    return array;
}


Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", array));
int [] final_array = Transformer(array);
Console.WriteLine(string.Join(" ", final_array));