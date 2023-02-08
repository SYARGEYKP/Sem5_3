// Задача 3: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
double[] GenerateArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        double num = Math.Round(rnd.NextDouble() * 99+ 1,8);
        array[i] = num;
    }
    return array;
}
void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
}
double PoiskMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double PoiskMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
int len = InputInt("Введите длину массива");
double[] array = GenerateArray(len);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между макс и мин числом  массива равна {PoiskMax(array) - PoiskMin(array)}");

