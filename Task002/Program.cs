// С клавиатуры вводятся два вещественных числа. 
// Проверять является ли одно из них квадратом второго

System.Console.WriteLine("введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число b= ");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    System.Console.WriteLine("b является квадратом а");
}
else
{
    if (b * b == a)
    {
        System.Console.WriteLine("a является квадратом b");

    }
    else
    {
            System.Console.WriteLine("не является квадратом ");
    }

}
