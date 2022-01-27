// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int normalLenght = 3;
var ArrayA = new string[4];
ArrayA[0] = "hello";
ArrayA[1] = "2";
ArrayA[2] = "world";
ArrayA[3] = ":-)";
string[] Dev1(string[] ArrayA)
{
    int lenB = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i].Length <= normalLenght) lenB++; 
    }
    string[] ArrayB = new string[lenB];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i].Length <= normalLenght)
        {
            ArrayB[j] = ArrayA[i];
            j++;
        }
    }
    return (ArrayB); 
}

void WriteArray(string[] ArrayA, string[] ArrayB)
{
    Console.Write("[");
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.Write(ArrayA[i]);
        if (i != ArrayA.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.Write(ArrayB[i]);
        if (i != ArrayB.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]\n");
}

void Task()
{
    WriteArray(ArrayA, Dev1(ArrayA));
}

Task();

