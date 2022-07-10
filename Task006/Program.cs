// Написать программу вычисления значения 
//функции y = sin(a). (Класс Math)

double x,y;
System.Console.WriteLine("введите число");
x = Convert.ToDouble(Console.ReadLine());
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");