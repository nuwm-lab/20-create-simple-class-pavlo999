using System;
using System.Text.RegularExpressions;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задане речення
            string sentence = "Це приклад речення для роздрукування всіх слів у стовпчик.";

            // Регулярний вираз для пошуку слів (послідовність букв)
            string pattern = @"\w+";

            // Створюємо об'єкт регулярного виразу
            Regex regex = new Regex(pattern);

            // Знаходимо всі збіги (слова)
            MatchCollection matches = regex.Matches(sentence);

            // Виводимо кожне слово в стовпчик
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            // Затримка для перегляду результатів
            Console.ReadLine();
        }
    }
}
