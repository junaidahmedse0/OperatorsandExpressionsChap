using System;
class QuestionTen
{

   static void Main(string[] args)
   {

    int a,b,c,d;
    Console.WriteLine("Enter a::");
    a=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter b::");
    b=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter c::");
    c=int.Parse(Console.ReadLine());
    Console.WriteLine("Enter d::");
    d=int.Parse(Console.ReadLine());
    int result=a+b+c+d;
    Console.WriteLine("sum of all digits::"+result);
    Console.WriteLine("The digits in reverse {3}{2}{1}{0}",a,b,c,d);
    Console.WriteLine("Last digit in first position {3}{0}{1}{2}",a,b,c,d);
    Console.WriteLine("The second and third digits exchanged: {0}{2}{1}{3}",a,b,c,d);

    



   }

}