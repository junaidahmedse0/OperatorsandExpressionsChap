using System;
class QuestionTwo
{
   static void Main(string[] args)
   {
       Console.WriteLine("Enter number ");
       int num=0;
       num=int.Parse(Console.ReadLine());
       if((num/5)*5==num && (num/7)*7==num)
       {

         Console.WriteLine("Divisble by 5 and 7");



       }
       else 
       {


         Console.WriteLine("Not divisible By both");
       }
       
        


   }



}