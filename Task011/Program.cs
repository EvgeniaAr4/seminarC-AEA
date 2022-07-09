// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
System.Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b=a/10%10;
System.Console.WriteLine(b);