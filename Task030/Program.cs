// Написать программу вычисления произведения чисел от 1 до N

System.Console.WriteLine("введите число");
int n= Convert.ToInt32(Console.ReadLine());
long multiply = 1;
for (int i=1;i<=n;i++)
{
 multiply= i * i;
}
Console.WriteLine(multiply);
