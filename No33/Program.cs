// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int [] ArrayCreation(int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

string Checkout (int [] array, int secret_num)
{
    string CheckResult = " ";
    int line = array.Length;
    for (int i = 0; i < line; i++)
    {
        if (array[i] == secret_num)
        {
            CheckResult = "да";
        }
        if (array[i] != secret_num)
        {
            CheckResult = "нет";
        }
    }
    return CheckResult;
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Какое число вы хотите здесь найти?");
int secret_num = int.Parse(Console.ReadLine());
string answer = Checkout(array, secret_num);
Console.WriteLine(answer);