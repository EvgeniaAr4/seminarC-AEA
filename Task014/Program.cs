// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.WriteLine("введите первое число a = ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите второе число b= ");
double b = Convert.ToDouble(Console.ReadLine());
if (a%b == 0){
    System.Console.WriteLine("кратно");
}
else {
    if (a%b != 0)
    {
        double sum = a%b;
        System.Console.WriteLine(sum);
    }
}