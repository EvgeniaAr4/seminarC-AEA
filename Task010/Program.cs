// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

System.Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>10)
{
a = a%10;
System.Console.WriteLine($"{a}");
}
else
{
    System.Console.WriteLine("incorret");
}