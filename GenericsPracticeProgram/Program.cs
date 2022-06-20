using System;
namespace GenericsPracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Practice Program of Generics....");
            int[] intArray = { 11, 22, 33, 44, 55, 66};
            double[] doubleArray = { 11.22, 33.44, 55.66, 77.88 };
            char[] charArray = { 'I', 'N', 'D', 'I', 'A' };

            PrintArray.Toprint<int>(intArray);
            PrintArray.Toprint<double>(doubleArray);
            PrintArray.Toprint<char>(charArray);
        }
    }
}