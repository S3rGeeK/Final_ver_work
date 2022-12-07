// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":)"]-> ["2",":>"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите количество элементов исходного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string?[] array = GetArray(size);

Console.WriteLine("Полученный массив: ");
PrintArray(array);
Console.WriteLine();

int secondArrayLength = GetSecondArrayLength(array);

string?[] secondArray = GetSecondArray(array);
Console.WriteLine("Новый массив: ");
PrintArray(secondArray);

string?[] GetArray(int size)
{
    Console.WriteLine("Введите элементы массива:");
    string?[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string?[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
}

int GetSecondArrayLength(string?[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= 3) count++;
    }
    return count;
}

string?[] GetSecondArray(string?[] array)
{
    string?[] secondArray = new string?[secondArrayLength];
    int indexOfSecondArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!.Length <= 3)
        {
            secondArray[indexOfSecondArray] = array[i];
            indexOfSecondArray++;
        }
    }
    return secondArray;
}