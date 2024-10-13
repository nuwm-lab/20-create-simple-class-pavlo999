using System;
using System.Collections.Generic;

class Human
{
    public string Name { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Human(string name, int day, int month, int year)
    {
        Name = name;
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

    // Метод для виведення інформації про людину
    public void PrintInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Дата народження: {Day}.{Month}.{Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масив людей
        Human[] people = new Human[]
        {
            new Human("Олександр", 12, 7, 1990),
            new Human("Марія", 15, 9, 1985),
            new Human("Іван", 21, 3, 2001),
            new Human("Олег", 10, 10, 2000), // Щасливий день для тесту
            new Human("Катерина", 31, 12, 1999)
        };

        List<Human> luckyPeople = new List<Human>();

        // Перевіряємо кожну людину в масиві на щасливий день
        foreach (Human person in people)
        {
            if (person.IsLuckyDay())
            {
                luckyPeople.Add(person);
            }
        }

        // Виводимо інформацію про людей, які народилися в щасливі дні
        if (luckyPeople.Count > 0)
        {
            Console.WriteLine("Люди, що народилися в щасливі дні:");
            foreach (Human luckyPerson in luckyPeople)
            {
                luckyPerson.PrintInfo();
            }
        }
        else
        {
            Console.WriteLine("Ніхто не народився в щасливий день.");
        }
    }
}
