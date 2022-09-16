void SecondNumber(int x)
{
    if (x > 99 && x < 1000)
    {
        int result = x / 10 % 10;
        Console.WriteLine($"Вторая цифра числа {x} = {result}");
    }
    else if (x > -1000 && x < -99)
    {
        x = x * -1;
        int result = x / 10 % 10;
        Console.WriteLine($"Вторая цифра числа {-x} = {result}");
    }
    else { Console.WriteLine("Число не трехзначное, попробуйте снова :)"); }
}


Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

SecondNumber(number);