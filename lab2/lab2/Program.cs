using System;

class Human
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Human(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    // Метод для обчислення суми цифр числа
    private int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Метод для перевірки щасливих днів
    public bool IsLuckyDay()
    {
        int daySum = SumOfDigits(Day);
        int monthSum = SumOfDigits(Month);
        int yearSum = SumOfDigits(Year);

        int remainderDay = daySum % 7;
        int remainderMonth = monthSum % 7;
        int remainderYear = yearSum % 7;

        // Перевірка, чи рівні остачі при діленні на 7
        return remainderDay == remainderMonth && remainderMonth == remainderYear;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Введення даних з клавіатури
        Console.Write("Введіть день народження: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Введіть місяць народження: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Введіть рік народження: ");
        int year = int.Parse(Console.ReadLine());

        // Створення об'єкта класу Human
        Human person = new Human(day, month, year);

        // Перевірка на "щасливі дні"
        if (person.IsLuckyDay())
        {
            Console.WriteLine("Ця людина народилася в щасливий день!");
        }
        else
        {
            Console.WriteLine("Ця людина не народилася в щасливий день.");
        }
    }
}
