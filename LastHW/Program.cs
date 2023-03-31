// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
string GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string[] CreateArray(int n)
{
    return new string[n];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = GetIncomingData($"Введите {i + 1} элемент массива");
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (string.IsNullOrEmpty(array[i]) == true)
        {
            continue;
        }
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

string[] GetElementArrayFixedLength(string[] array)
{
    string[] result = CreateArray(array.GetLength(0));
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

int n = Convert.ToInt32(GetIncomingData("Введите длину массива"));
string[] array = CreateArray(n);
FillArray(array);
string[] result = GetElementArrayFixedLength(array);
PrintArray(result);
