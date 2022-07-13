// По двум заданным числам проверять является 
// ли одно квадратом другого. Используйте подпрограмму.

bool chek (int a,int b)
{
return a*a==b;
}
System.Console.WriteLine("введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число b= ");
int b = Convert.ToInt32(Console.ReadLine());
if (chek(a,b))
{
    System.Console.WriteLine("b является квадратом а");
}
else
{
    if (chek(b,a))
    {
        System.Console.WriteLine("a является квадратом b");

    }
    else
    {
            System.Console.WriteLine("не является квадратом ");
    }

}
