// Вывести на экран кубы чисел от 1 до N
Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("куб");
for (int i = 1; i <= N; i++)
    Console.WriteLine(i*i*i);

Console.ReadLine();
