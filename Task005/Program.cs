// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.WriteLine("input A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
max = num; 
if (max < num2)
     max = num2;
 if (max < num3)
     max = num3;
 Console.Write($"max = {max}");