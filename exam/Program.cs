int Prompt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int[] Array(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int content = 
int size = Prompt("Введите размер массива -> ");
int[] array = Array(size);
SetOutput(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве -> {Honest(array)}");
