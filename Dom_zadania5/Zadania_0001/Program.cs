// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве


// - создать массив
// - ввод данных, рандом, положительные, трёхзначные
// - опридиления четных чисел в массиве


// - создать массив
int[] Array(int count)
{
    int[] res = new int[count];
    return res;
}

// - ввод данных рандом
void RandomArray(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

// - вывод на консоль
string ConvertArray(int[] array)
{
    int len = array.Length;
    string result = string.Empty;
    for (int i = 0; i < len; i++)
    {
        result = result + $"{array[i]} ";
    }
    return result;
}


// - Основной код

int[] inArr = Array(10);                           // - создаем массив состоящи из 10 элиментов
RandomArray(inArr, 100, 999);                     // - ввод данных в рандом
string outStr = ConvertArray(inArr);              // - конвертируем строку в int (дано)
Console.WriteLine(outStr);                        // - выводим массива (дано)

int res = 0;
for (int i = 0; i < inArr.Length; i++)
{
    if (inArr[i] % 2 == 0) res++;
}
Console.WriteLine("Чётных чисел в массиве: "+res);
