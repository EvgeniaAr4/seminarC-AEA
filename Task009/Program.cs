// Вывести на экран четные числа от 1 до N

int i=2;
System.Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
while(i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2;
}
