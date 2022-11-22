//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int CountOfElements = int.Parse(Console.ReadLine() ?? "0");

int[] Array = new int[CountOfElements];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write("Введите число: ");
    Array[i] = int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("Вывод массива:");

for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i]);
    Console.WriteLine();
}

int count = default;
foreach (int elem in Array)
{
    if(elem > 0) count++;
}
Console.Write($"количество чётных чисел в массиве => {count}");
Console.WriteLine();

