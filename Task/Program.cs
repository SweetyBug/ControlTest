//Создание массива
void CreateArray(string[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write($"Введите {i}-е значение в массив: ");
        mass[i] = Console.ReadLine();
    }
}
//Вывод массива
void PrintArray(string[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + "; ");
    }
}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine()); //задаем длину массива
string[] array = new string[len];

CreateArray(array);
PrintArray(array);
Console.WriteLine();
int n;
int k = -1;
int j = 0;
if (len < 3)
{
    n = new Random().Next(0, len+1);
}
else
{
    n = new Random().Next(0, 4);
}


//Цикл, который выводит значения из массива
while(j < n)
{
    int m = new Random().Next(0, len);
    if(m != k)
    {
        k = m;
        Console.Write(array[m] +"; ");
        j++;

    }
}
