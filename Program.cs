// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string GetString(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

int number = GetNumber("Input amount of elements: ");

string[] array = new string[number];

for (int i = 0; i < array.Length; i++) array[i] = GetString($"Input {i + 1} element: ");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] result = new string[count];
count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[count] = array[i];
        count++;
    }
}

Console.WriteLine($"Result array: [{string.Join(", ", result)}]");
