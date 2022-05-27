// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int [] ArrayCreation (int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100,1001);
    }
    return arr;
}

int FindingNumbers (int [] array, int length)
{
    int counter = 0;
    for (int i = 0; i < length; i++)
    {
        if((array[i] >= 10) && (array[i] <= 99))
        {
            counter += 1;
        }
    }
    return counter;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
int result = FindingNumbers(array, length);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($" количество чисел в промежутке от 10 до 99 = {result}");