using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quadratic Equation Solver");

        // Wprowadzenie współczynników równania kwadratowego
        Console.Write("Enter the coefficient a: ");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
            Console.Write("Enter the coefficient b: ");
            if (double.TryParse(Console.ReadLine(), out double b))
            {
                Console.Write("Enter the coefficient c: ");
                if (double.TryParse(Console.ReadLine(), out double c))
                {
                    // Obliczenia pierwiastków
                    double delta = b * b - 4 * a * c;

                    if (delta > 0)
                    {
                        // Dwa pierwiastki rzeczywiste
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        Console.WriteLine($"Two real roots: x1 = {x1:F2}, x2 = {x2:F2}");
                    }
                    else if (delta == 0)
                    {
                        // Jeden pierwiastek rzeczywisty (podwójny)
                        double x = -b / (2 * a);

                        Console.WriteLine($"One real root (double root): x = {x:F2}");
                    }
                    else
                    {
                        // Brak pierwiastków rzeczywistych
                        Console.WriteLine("No real roots");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for coefficient c.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for coefficient b.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for coefficient a.");
        }
    }
}
