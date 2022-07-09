// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
Console.WriteLine("input A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
max = num; 
if (max < num2)
     max = num2;

System.Console.WriteLine($"max: {max}");