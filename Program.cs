using System;
using System.Dynamic;

namespace Test
{
	class Program
	{
        static dynamic Sum(int totalInches)
        {
            int feet = totalInches / 12;
            int inches = totalInches % 12;

            /*for one time use object and can return any datatype*/
            dynamic output = new ExpandoObject();
            output.feet = feet;
            output.inches = inches;
            return output;
        }
        
        static void Main(string[] arguments)
		{
            dynamic output = Sum(20);
            Console.WriteLine("This is total value of feet --> " + output.feet);
            Console.WriteLine("This is total value of inches --> " + output.inches);
            Distance d = Calculate(128);
            Console.WriteLine("Total value of feet --> "+ d.feet + " and Total value of inches -- >" +  d.inches);
        }

        static Distance Calculate(int totalValue)
        {
            Distance distance = new Distance();
            distance.feet = totalValue / 12;
            distance.inches = totalValue % 12;
            return distance;
        }
    }
}

