// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("input number of a day: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("incorrect day");
}

 else
switch (day)
{
    case 1: 
         System.Console.WriteLine("monday");
         break;
    case 2: 
         System.Console.WriteLine("tuesday");
         break; 
    case 3: 
         System.Console.WriteLine("wednesday");
         break;  
    case 4: 
         System.Console.WriteLine("thursday");
         break;   
    case 5: 
         System.Console.WriteLine("firday");
         break;  
    case 6: 
         System.Console.WriteLine("saturday");
         break; 
    case 7: 
         System.Console.WriteLine("sunday");
         break;                 

}   
  if (day>5)
  {
    System.Console.WriteLine("weekends");
  } 
  else{
    System.Console.WriteLine("weekdays");
  }
