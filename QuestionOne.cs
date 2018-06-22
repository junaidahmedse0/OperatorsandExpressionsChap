using System;

class QuestionOne
{

  static void Main(string[] args)
  {
    int num=0;
    Console.WriteLine("Enter Number");
    num=Convert.ToInt32(Console.ReadLine());
    if(num%2==0)
    {
        Console.WriteLine("Even");    
      
    } 
    else
   { 
     Console.WriteLine("Odd");

   }


   }




}