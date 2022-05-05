// Задача 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] inArr = Array(10);                          // - создаем массив состоящи из 10 элиментов
RandomArray(inArr, 1, 10);                        // - ввод данных в рандом
string outStr = ConvertArray(inArr);              // - конвертируем строку в int (дано)
Console.WriteLine(outStr);                        // - выводим массива (дано)

int res = 0;
int ResSumm = 0;
for (int i = 1; i < inArr.Length; i++)
{
    if (inArr[i] % 2 != 0) 
    {
        res++;
        ResSumm = ResSumm + inArr[i];
    }
}
Console.WriteLine("Нечетные чисел в массиве: "+res);
Console.WriteLine("Сумма нечетных чисел в массиве: " +ResSumm);
