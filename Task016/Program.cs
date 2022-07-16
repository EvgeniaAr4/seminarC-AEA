// Дано число. Проверить кратно ли оно 7 и 23

bool b,c,d;
b=true;
d=false;
System.Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
b=x%7==0;
c=x%23==0;
d=b && c;
System.Console.WriteLine(x);
System.Console.WriteLine(d);