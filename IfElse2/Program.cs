using System;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Enter today's day: ");
          int today = Convert.ToInt32(Console.ReadLine());

          Console.Write("Enter the number of days elapsed since today: ");
          int future = Convert.ToInt32(Console.ReadLine());

          future = (today + future) % 6;

          string todayText = null;
          string futureText = null;
  
          if(today == 0) 
          {
            todayText = "Sunday"; 
          }
          else if(today == 1)
          {
              todayText = "Monday";
          }
          else if(today == 2)
          {
              todayText = "Tuesday";
          }
          else if(today == 3)
          {
            todayText = "Wednesday";
          }
          else if(today == 4)
          {
            todayText = "Thursday";
          }
          else if(today == 5)
          {
              todayText = "Friday";
          }
          else if(today == 6)
          {
              todayText = "Saturday";
          }
    
            if(future == 0)
            {
               futureText = "Sunday";
            }
            else if(future ==1)
            {
              futureText = "Monday";
            }
            else if(future == 2)
            {
              futureText = "Tuesday";
            }
            else if(future == 3)
            {
              futureText = "Wednesday"; 
            }
            else if(future == 4)
            {
              futureText = "Thursday"; 
            }
            else if(future == 5)
            {
              futureText = "Friday"; 
            }
            else if(future == 6)
            {
              futureText = "Saturday";
            }
    
            Console.WriteLine("Today is " + todayText + " and the future day is " + futureText);
        }
    }
}
