using System;

namespace _01._DataTypes
{
    class Program
    { 

        static void DetermineType( int intValue)
        {
            
            int result = intValue * 2;
            Console.WriteLine(result);
        }

        static void DetermineType( double doubleValue)
        {
            
            double result = doubleValue * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void DetermineType(string stringValue)
        {
            Console.WriteLine("$" + stringValue + "$");
        }

        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string stringValue = Console.ReadLine();
            if (dataType == "int")
            {
                int integerValue = int.Parse(stringValue);
                DetermineType(integerValue);
            }
            else if (dataType == "real")
            {
                double doubleValue = double.Parse(stringValue);
                DetermineType(doubleValue);
            }
            else if (dataType == "string")
            {
                DetermineType(stringValue);
            }

        }
    }
}
