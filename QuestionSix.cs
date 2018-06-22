using System;
class QuestionSix
{
  static void Main(string[] args)
  {
   int perimeter,area;
   int width,length;
   Console.WriteLine("Enter width");
   width=int.Parse(Console.ReadLine());
   Console.WriteLine("Enter leng");
   length=int.Parse(Console.ReadLine());
 
    area=width*length;
    perimeter=2(length+width);
    Console.WriteLine("AREA of rectangle"+area);
    Console.WriteLine("Perimeter of rectangle"+perimeter);
   }




}