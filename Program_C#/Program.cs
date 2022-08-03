﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа. Первоночальный массив можно ввести с 
// клавиатуры либо задать на старте выполенения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = { "hello", "2", "world", ":-)" };

int LengthNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] arr, int count)
{
    int j = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            j++;
        }
    }
    return newArray;
}

