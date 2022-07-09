// С клавиатуры вводится целое число. Вывести квадрат числа 

System.Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b;
b=a*a;
System.Console.WriteLine($"{a}*2={b}");