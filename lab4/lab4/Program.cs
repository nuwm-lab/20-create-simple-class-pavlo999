using System;

class LinearFunction
{
    protected double a1, a0;

    // Метод для задання коефіцієнтів лінійної функції
    public void SetCoefficients(double a1, double a0)
    {
        this.a1 = a1;
        this.a0 = a0;
    }

    // Метод для виведення коефіцієнтів лінійної функції
    public void PrintCoefficients()
    {
        Console.WriteLine($"Лінійна функція: f(x) = {a1}x + {a0}");
    }

    // Метод для обчислення значення лінійної функції в точці x
    public double CalculateValue(double x)
    {
        return a1 * x + a0;
    }
}

class Polynomial : LinearFunction
{
    private double a2, a3, a4;

    // Перевантажений метод для задання коефіцієнтів багаточлена
    public void SetCoefficients(double a4, double a3, double a2, double a1, double a0)
    {
        this.a4 = a4;
        this.a3 = a3;
        this.a2 = a2;
        base.SetCoefficients(a1, a0);
    }

    // Перевантажений метод для виведення коефіцієнтів багаточлена
    public void PrintCoefficients()
    {
        Console.WriteLine($"Багаточлен: f(x) = {a4}x^4 + {a3}x^3 + {a2}x^2 + {a1}x + {a0}");
    }

    // Перевантажений метод для обчислення значення багаточлена в точці x
    public double CalculateValue(double x)
    {
        return a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу LinearFunction
        LinearFunction linearFunction = new LinearFunction();

        // Задання коефіцієнтів для лінійної функції
        Console.WriteLine("Задайте коефіцієнти для лінійної функції (a1 та a0):");
        double a1 = double.Parse(Console.ReadLine());
        double a0 = double.Parse(Console.ReadLine());
        linearFunction.SetCoefficients(a1, a0);

        // Виведення коефіцієнтів та обчислення значення в точці
        linearFunction.PrintCoefficients();
        Console.Write("Введіть точку x для обчислення значення лінійної функції: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Значення лінійної функції в точці {x} = {linearFunction.CalculateValue(x)}");

        // Створення об'єкта класу Polynomial
        Polynomial polynomial = new Polynomial();

        // Задання коефіцієнтів для багаточлена
        Console.WriteLine("\nЗадайте коефіцієнти для багаточлена (a4, a3, a2, a1, a0):");
        double a4 = double.Parse(Console.ReadLine());
        double a3 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        a1 = double.Parse(Console.ReadLine());
        a0 = double.Parse(Console.ReadLine());
        polynomial.SetCoefficients(a4, a3, a2, a1, a0);

        // Виведення коефіцієнтів та обчислення значення в точці
        polynomial.PrintCoefficients();
        Console.Write("Введіть точку x для обчислення значення багаточлена: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine($"Значення багаточлена в точці {x} = {polynomial.CalculateValue(x)}");
    }
}
