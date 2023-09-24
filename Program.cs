// Task: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//       длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//       либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//       лучше обойтись исключительно массивами.

Console.Clear();

string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan","4","pip897","arr","Array" };

string[] SortArray(string[] array)
{
    string[] newArray = new string[array.Length];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

Console.Write($"Начальный массив :[" + string.Join(", ", array) + "]"+"\n"+"\n");
Console.Write($"Конечный массив :[" + string.Join(", ", SortArray(array)) + "]");