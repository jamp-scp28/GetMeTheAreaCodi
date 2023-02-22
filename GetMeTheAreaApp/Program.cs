using GetMeTheAreaApp.Logic.BusinessLogic.Implement;
using GetMeTheAreaApp.Logic.Domain.Dto;
using System;

namespace GetMeTheAreaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GetMeTheAreaApp By Jorge Molano");
            SimpleResult<double> result = GetMeTheAreaApp();
            if(result.ExcMessage != null && result.Result != 0)
            {
                Console.WriteLine($"There you go, here is your area: {result.Result}");
            }
            else
            {
                Console.WriteLine($"We are really sorry, there was an error; here are the details: {result.ExcMessage}");
            }
        }

        public static SimpleResult<double> GetMeTheAreaApp()
        {
            FactoryLogic _factory = new FactoryLogic();
            SimpleResult<double> _result = new();

            // Type your username and press enter
            Console.WriteLine("Calculate Shape Area. Please select 1: Cicle or 2: Triangle: ");
            // Create a string variable and get user input from the keyboard and store it in the variable
            int shape = Int32.Parse(Console.ReadLine());
            if (shape == 1)
            {
                Console.WriteLine("Please enter the radio of the circle (integer only): ");
                int radio = Int32.Parse(Console.ReadLine());
                _result = _factory.Area.GetCircleArea(radio);
            }
            if (shape == 2)
            {
                Console.WriteLine("Please enter the base of the trianlge (integer only): ");
                int baseV = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height of the trianlge (integer only): ");
                int height = Int32.Parse(Console.ReadLine());
                _result = _factory.Area.GetTriangleArea(baseV, height);
            }
            return _result;
        }
    }
}
