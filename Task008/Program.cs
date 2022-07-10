// Вывести на экран числа от -N до N

System.Console.WriteLine("введите число");
int A = Convert.ToInt32(Console.ReadLine());
if (A<0)
{
int B = A * (-1) - 1;
while(B > A)
{
{
        System.Console.Write($"{B} ");
         B=B-1;
}
}
}
else 
{
int B = A *(-1) + 1;


while(B < A)
{
{
        System.Console.Write($"{B} ");
         B=B+1;
}
}
}