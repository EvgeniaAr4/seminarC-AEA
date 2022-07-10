// 

int i=2;
System.Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
while(i<=N)
{
    if (i%2==0)
    {
        System.Console.Write($"{i} ");
    }
    i=i+1;
}