// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int [] ArrayCreation(int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr [i] = rnd.Next(-9,10);
    }
    return arr;
}

int SummNegativNumbers(int [] arr)
{
    int NegSumm = 0;
    foreach (int item in arr) // for each item in array do following
    {
        if (item < 0)
        {
            NegSumm = NegSumm + item; // negsum += item
        }
    }
    return NegSumm;
}

int SummPositiveNumbers (int [] arr)
{
    int PosSum = 0;
    foreach (int item in arr)
    {
        if(item > 0)
        {
            PosSum += item;
        }
    }
    return PosSum;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(",", array)); // вывод массива через string.Join("," , array)
int NegativeSumm = SummNegativNumbers(array);
int PositiveSumm = SummPositiveNumbers(array);
Console.WriteLine($"Сумма положительных чисел массива равна {PositiveSumm}, а отрицательных - {NegativeSumm}");
