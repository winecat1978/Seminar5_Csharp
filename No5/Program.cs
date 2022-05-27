// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве

int [] ArrayCreation(int length)
{
    int [] arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-10,10);
    }
    return arr;
}

int [] Multiple (int[] original_array) 
{ 
    int line = 0; 
    bool even = false; 
    if (original_array.Length % 2 == 0) 
    { 
        line = original_array.Length / 2; 
        even = true; 
    } 
    else  
    line = original_array.Length / 2 + 1; 
    int[] newArray = new int[line]; 
    for (int i = 0; i < original_array.Length/2; i++) 
    { 
        newArray[i] = original_array[i] * original_array[original_array.Length -1 - i]; 
    } 
    if (even == false) 
    { 
        newArray[newArray.Length - 1] = original_array[original_array.Length/2]; 
    } 
    return newArray; 
}
Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int [] original_array = ArrayCreation(length);
Console.WriteLine(string.Join(" ", original_array));
int [] Array = Multiple(original_array);
Console.WriteLine(string.Join(" ", Array));