// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Задайте количество элементов для массива строк: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] StringArray = new string[m];

void Array(string[] StringArray)
{
    for (int i = 0; i < StringArray.Length; i++)
    {
        Console.Write($"Введите в массив строку {i + 1}: ");
        StringArray[i] = Console.ReadLine()!;
    }
}

void SearchAndPrint(string[] StringArray)
{
    int n = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3)
            n++;
    }
    string[] ThreeStringArray = new string[n];
    int j = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= 3)
        {
            ThreeStringArray[j] = StringArray[i];
            j++;
        }
    }
    Console.Write(
        $"Полученный массив (с длиной строки меньше или равной 3 символам): "
            + "["
            + string.Join(", ", ThreeStringArray)
            + "]"
    );
}

Array(StringArray);
SearchAndPrint(StringArray);