using System;

namespace CSharp.LabExercise4
{
    class Shape
    {
        string shapeName;
        public string ShapeName
        {
            get => shapeName;
            set => shapeName = value;
        }
    }

    interface IShape
    {
        public void ComputeArea();
        public void DisplayArea();
    }

    class Circle : Shape, IShape
    {
        string shapeName = "circle";
        decimal area;

        public void ComputeArea()
        {
            decimal radius = 5;
            decimal pi = Convert.ToDecimal(Math.PI);
            area = pi * radius * radius;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"{shapeName} area = {area}");
        }
    }

    class Square : Shape, IShape
    {
        string shapeName = "square";
        decimal area;

        public void ComputeArea()
        {
            decimal side = 5;
            area = side * side;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"{shapeName} area = {area}");
        }
    }

    class Rectangle : Shape, IShape
    {
        string shapeName = "rectangle";
        decimal area;

        public void ComputeArea()
        {
            decimal length = 5;
            decimal width = 4;
            area = length * width;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"{shapeName} area = {area}");
        }
    }

    interface IOperation
    {
        public decimal Compute(decimal num1, decimal num2);
        
    }

    class Add : IOperation
    {
        public decimal Compute(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
    class Subtract : IOperation
    {
        public decimal Compute(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
    class Multiply : IOperation
    {
        decimal product;
        int x, y;

        public decimal Compute(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
    class Divide : IOperation
    {
        public decimal Compute(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }

    class Calculator
    {
        public decimal Compute(IOperation operation, decimal num1, decimal num2)
        {
            return operation.Compute(num1, num2);
        }
    }

    internal class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to Shape Area Calculator\n");
            IShape circleArea = new Circle();
            IShape squareArea = new Square();
            IShape rectangleArea = new Rectangle();
            circleArea.ComputeArea();
            circleArea.DisplayArea();
            squareArea.ComputeArea();
            squareArea.DisplayArea();
            rectangleArea.ComputeArea();
            rectangleArea.DisplayArea();
        }
        static void Number2()
        {
            Console.WriteLine("Welcome to Basic Operation Calculator\n");
            IOperation add = new Add();
            IOperation subtract = new Subtract();
            IOperation multiply = new Multiply();
            IOperation divide = new Divide();
            Calculator calculator = new Calculator();

            decimal sum = calculator.Compute(add, 15M, 3M);
            Console.WriteLine($"Sum = {sum}");
            decimal difference = calculator.Compute(subtract, 15M, 3M);
            Console.WriteLine($"Difference = {difference}");
            decimal product = calculator.Compute(multiply, 15M, 3M);
            Console.WriteLine($"Product = {product}");
            decimal quotient = calculator.Compute(divide, 15M, 3M);
            Console.WriteLine($"Quotient = {quotient}");
        }
        static void Main(string[] args)
        {
            Number1();
            Number2(); 
        }
    }
}
