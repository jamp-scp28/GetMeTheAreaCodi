using GetMeTheAreaApp.Logic.BusinessLogic.Implement;
using GetMeTheAreaApp.Logic.Domain.Dto;
using GetMeTheAreaApp.Logic.Domain.Helpers;
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
            SimpleResult<int> shape = new();
            SimpleResult<int> radio = new();
            SimpleResult<int> baseV = new();
            SimpleResult<int> height = new();

            shape = ParseInput.TryParse(Console.ReadLine());

            if (shape.Result == 1)
            {
                Console.WriteLine("Please enter the radio of the circle (integer only): ");
                radio = ParseInput.TryParse(Console.ReadLine());
                if(radio.ExcMessage == "") _result = _factory.Area.GetCircleArea(radio.Result);
                if(radio.ExcMessage != "") _result.ExcMessage = "Invalid input";
            }
            if (shape.Result == 2)
            {
                Console.WriteLine("Please enter the base of the trianlge (integer only): ");
                baseV = ParseInput.TryParse(Console.ReadLine());
                Console.WriteLine("Please enter the height of the trianlge (integer only): ");
                height = ParseInput.TryParse(Console.ReadLine());
                if(baseV.ExcMessage == "" && height.ExcMessage == "") _result = _factory.Area.GetTriangleArea(baseV.Result, height.Result);
                if(baseV.ExcMessage != "" || height.ExcMessage != "") _result.ExcMessage = "Invalid input";
            }
            if (shape.Result == 0) HandleBadParsing(shape.ExcMessage);

            return _result;
        }

        public static void HandleBadParsing(string message)
        {
            Console.WriteLine(message);
        }
    }
}
