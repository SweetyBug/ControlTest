void CreateArray(string[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write($"Введите {i}-е значение в массив");
        mass[i] = Console.ReadLine();
    }
}


int len = Convert.ToInt32(Console.ReadLine());
string[] array = new string[len];