// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите элементы массива, разделенные пробелом:");
string massive= Console.ReadLine();

var arraystr = massive.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = Array.ConvertAll(arraystr, Convert.ToInt32);
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество элементов больше нуля: {sum}");