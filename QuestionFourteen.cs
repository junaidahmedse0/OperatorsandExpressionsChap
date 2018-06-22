
using System;
class QuestionFourteen
{
   static void Main(string[] args)
   {
     int num;
     bool isPrime=true;
     Console.WriteLine("Enter Number::");
    
     num=int.Parse(Console.ReadLine());
     for(int i=2; i<num/2;i++)
     {

        if(num%i==0)
          {

              isPrime=false;
              break;

            }
       


     }
     if(isPrime==true)
       {

          Console.WriteLine("The number is a prime");

       }
      else
        Console.WriteLine("The number is not  a prime");






   }







}