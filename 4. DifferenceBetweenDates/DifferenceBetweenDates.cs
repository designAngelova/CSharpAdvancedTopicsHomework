//4. Write a program that enters two dates in format dd.MM.yyyy 
// and returns the number of days between them. 
using System;
using System.Globalization;

    class DifferenceBetweenDates
    {
        static void Main()
        {
            Console.WriteLine("Please enter begin & end date in dd.MM.yyyy format");
            Console.Write("Begin date = ");
            DateTime beginDate, endDate;
            CultureInfo bgBG = new CultureInfo("bg-BG");
            
            try
            {
               
               beginDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);
               Console.Write("End date = ");
               endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);
               if (beginDate.DayOfYear > endDate.DayOfYear)
               {
                   Console.WriteLine("Begin date must me earlier than end date");
               }
               else
               {
                   int duration = endDate.DayOfYear - beginDate.DayOfYear;

                   Console.WriteLine("Number of days between these dates are {0}", duration);
               }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date! Dates must be in format dd.MM.yyyy.");
            }
            
            
           
        }

    }

