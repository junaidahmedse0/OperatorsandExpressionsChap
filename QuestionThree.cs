using System;
class QuestionThree
{

   static void Main(string[] args)
   {
     int num=0;
     Console.WriteLine("Enter Number");
     num=int.Parse(Console.ReadLine());
     num=num/100;
     if(num%10==7)
     {

       Console.WriteLine("The  third num is 7");

     }
     else
    {
       Console.WriteLine("7 Not third number");
    }

    }


}