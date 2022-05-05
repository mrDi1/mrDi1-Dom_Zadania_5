// Задача 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

int max = 0;
int min = 0;
for (int i = 0; i < inArr.Length; i++)
{
    if (inArr[i] >= max)
    {
        max = inArr[i];
    }
    if (inArr[i] <= min)
    {
        min = inArr[i];
    }
}
Console.WriteLine("Максимум: {0}; Минимум: {1};", max, min);
int SummMaMi = max - min;
Console.WriteLine("Разницу между max и min: " + SummMaMi);

// Не могу разабратся почему у меня min всегда 0 ((
// Не смог создать массив из Double((

// сделал что смог, дедлайн поджимает(((
