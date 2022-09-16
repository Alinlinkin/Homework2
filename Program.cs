void Week(int x)
{
    if (x > 0 && x < 8)
    {
        if (x > 0 && x < 6)
        { Console.WriteLine("Будний денечек"); }
        else { Console.WriteLine("Выходной денечек"); }
    }
    else { Console.WriteLine("Такого дня недели нет!)"); }
}
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
Week(number);
