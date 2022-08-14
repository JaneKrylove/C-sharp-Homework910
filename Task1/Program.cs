// Задача 1: 
// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

string[] CreateStringArray(int a)
{
    string[] array = new string[a];
    for (int i = 0; i < a; i++)
    {
        Console.Write("Input string array element number: " + (i + 1) + " ");
        string? newElement = Convert.ToString(Console.ReadLine());
        array[i] = newElement;
    }
    return array;
}

void PrintArray(string[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write(array[i] + ";");
    }
    Console.WriteLine();
}

int CountElements(string[] array)
{
    int len = array.Length;
    string vowels = "aiueoy";
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i][0] == vowels[0] || array[i][0] == vowels[1] || array[i][0] == vowels[2] || array[i][0] == vowels[3] || array[i][0] == vowels[4] || array[i][0] == vowels[5])
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter number of words: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] userArray = CreateStringArray(n);

PrintArray(userArray);

Console.WriteLine("Number of words per vowel: " + CountElements(userArray));
