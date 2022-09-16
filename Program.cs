void SecondNumber(int x)
{
    int number = x;
if(number>99){
    while(number>1000)
    {
    number=number/10;
    }
    int result = number%10;
    Console.WriteLine($"Третья цифра числа {x} = {result}");
}
else if (number<-99){
     number = number*-1;
     while(number>1000)
    {
      number=number/10;
    }
    int result = number%10;
    Console.WriteLine($"Третья цифра числа {x} = {result}");
}
else {Console.WriteLine("Третьей цифры нет!)"); }
}  

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

SecondNumber(number);
