int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
string[] Array(int len)
{
    string[] array = new string[len];
    System.Console.WriteLine("Введите значения (цифра или слово) для заполнения массива");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] NewArray(string [] array, int size)
{
    int count = 0;
    string [] newarray = new string [size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count ++;
        }
    }
    return newarray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int size = Prompt("Введите размер массива -> ");
string[] array = Array(size);
string[] newarray = NewArray(array, size);
PrintArray(array);
System.Console.WriteLine();
PrintArray(newarray);
System.Console.WriteLine();
