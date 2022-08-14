// Задача 2: 
// Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] CreateStringArray(int a)
{
    string[] array = new string[a];
    for (int i = 0; i < a; i++)
    {
        Console.Write("Input string array element number " + (i + 1) + ": ");
        string? newElement = Convert.ToString(Console.ReadLine());
        array[i] = newElement;
    }
    return array;
}

void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ";");
    }
    Console.WriteLine();
}

string[]RelationArray (string[] arrayOne, string[] arrayTwo) {
    int lengthArray = arrayOne.Length;
    string[] newArray = new string[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        newArray[i] = arrayOne[i] + arrayTwo[i];
    }
    return newArray;
}

Console.Write("Input number of element of two arrays: ");
int a = Convert.ToInt32(Console.ReadLine());

string[] userArrayFirst = CreateStringArray(a);

string[] userArraySecond = CreateStringArray(a);

PrintArray(userArrayFirst);

PrintArray(userArraySecond);

string[] finalArray = RelationArray(userArrayFirst, userArraySecond);

PrintArray(finalArray);