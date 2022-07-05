namespace Udemy;

class Program
{
    enum Menu {
        Add = 1,
        Subtract = 2, 
        Multiply = 3,
        Divide = 4,
        Potentiation = 5,
        SquareRoot = 6,
        Exit = 7
    }
    static void Main(string[] args) 
    {
        bool exit = false;
        while(!exit) /// ENQUANTO O USUARIO NÃO(!) ESCOLHER SAIR EXIBA O MENU.
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter one of the following options:");
            Console.WriteLine("1-Add\n2-Subtract\n3-Multiply\n4-Divide\n5-Potentiation\n6-Square Root\n7-Exit");
            Menu option = (Menu)int.Parse(Console.ReadLine());
            switch (option)
            {
                case Menu.Add:
                    Add();
                    break;
                case Menu.Subtract:
                    Subtract();
                    break;
                case Menu.Multiply:
                    Multiply();
                    break;
                case Menu.Divide:
                    Divide();
                    break;
                case Menu.Potentiation:
                    Potentiation();
                    break;
                case Menu.SquareRoot:
                    SquareRoot();
                    break;
                case Menu.Exit:
                    exit = true;
                    break;
            }
            Console.WriteLine(option);
            Console.Clear();
        }

        static void Add()
        {
            Console.WriteLine("Sum of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of the two numbers is: {sum} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Subtract()
        {
            Console.WriteLine("Subtraction of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int subtraction = num1 - num2;
            Console.WriteLine($"The subtraction of the two numbers is: {subtraction} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Multiply()
        {
            Console.WriteLine("Multiplication of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int multiplication = num1 * num2;
            Console.WriteLine($"The multiplication of the two numbers is: {multiplication} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Divide()
        {
            Console.WriteLine("Division of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            float division =  (float)num1 / (float)num2;
            Console.WriteLine($"The division of the two numbers is: {division} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Potentiation()
        {
            Console.WriteLine("Potentiation of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int potency = (int)Math.Pow(num1, num2);
            Console.WriteLine($"The potency of the two numbers is: {potency} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void SquareRoot()
        {  
            Console.WriteLine("Square root of two numbers");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            double squareRoot = Math.Sqrt(num1);
            Console.WriteLine($"The square root of the two numbers is: {squareRoot} ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        
    }
}