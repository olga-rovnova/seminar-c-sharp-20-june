//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)                         //проверяем на нечетность именно индекс позиции,
    {                                       //а не пользовательское восприятие размера массива
        sum += array[i];                    //от 1 до введенного числа
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");


void FillArrayRandomNumbers(int[] array)    //заполнение массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);//возьмем диапазон чисел от -10 до +10
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