//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int max = int.MinValue;
int min = int.MaxValue;

FillArrayRandomNumbers(array);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"разница между максимальным и минимальным элементами массива: {max - min}");



void FillArrayRandomNumbers(int[] array)    //заполнение массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);//возьмем диапазон чисел от -100 до +100
    }
}

void PrintArray(int[] array)                //печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}