int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
string[] Array(int len)
{
    string content = "";
    string[] array = new string[len];
    System.Console.WriteLine("Введите значения (цифра или слово) для заполнения массива");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i+1}-й элемент массива: ");
        content = Console.ReadLine();
        array[i] = content;
    }
    return array;
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
PrintArray(array);
System.Console.WriteLine();
