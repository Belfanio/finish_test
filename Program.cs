int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

string[] initStartMassiv(int len)
{
    string[] startMassiv = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i+1} элемент изначального массива - ");
        startMassiv[i] = Console.ReadLine();
    }
    return startMassiv;
}

string[] InitEndMassiv(string[] startMassiv)
{
    int count = 0;
    string[] endMassiv = new string[startMassiv.Length];
    for (int i = 0; i < startMassiv.Length; i++)
    {
    if(startMassiv[i].Length <= 3)
        {
        endMassiv[count] = startMassiv[i];
        count++;
        }
    }
    return endMassiv;
}
void PrintEndMassiv(string[] endMassiv)
{   
    for (int i = 0; i < endMassiv.Length; i++)
    {
        Console.Write($"{endMassiv[i]} ");
    }
    Console.WriteLine();
}

int len = GetNumber("Введите размерность массива");
string[] startMassiv = initStartMassiv(len);
string[] endMassiv = InitEndMassiv(startMassiv);
Console.WriteLine("Изначальный массив");
PrintEndMassiv(startMassiv);
Console.WriteLine("Получившийся массив");
PrintEndMassiv(endMassiv);