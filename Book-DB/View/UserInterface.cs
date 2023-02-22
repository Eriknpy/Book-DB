using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_DB.View
{
    internal class UserInterface
    {
        public void PrintLn(Object obj)
        {
            Console.WriteLine(obj);
        }

        public void PrintTitle(string title)
        {
            Console.WriteLine("\n --" + title + " --");
        }

        public void PrintOption(char option, string description)
        {
            Console.WriteLine("(" + option + ")" + " " + description);
        }

        public char Choice(string options)
        {
            // Given string options -> "abcd"
            // keep asking user for input until one of provided chars is provided
            string userInput;
            do
            {
                Console.WriteLine($"Choose[{options}]: ");
                userInput = Console.ReadLine();
            } while ((string.IsNullOrEmpty(userInput)
                      || userInput.Length != 1)
                     && !options.Contains(userInput));

            return userInput[0];
        }

        public string ReadString(string prompt, string defaultValue)
        {
            // Ask user for data. If no data was provided use default value.
            // User must be informed what the default value is.
            PrintPrompt(prompt, defaultValue);
            var userInput = Console.ReadLine();
            return string.IsNullOrEmpty(userInput) ? defaultValue : userInput;
        }
        private void PrintPrompt(string prompt, object defaultValue)
        {
            Console.WriteLine($"{prompt} [{defaultValue}]: ");
        }

        public DateOnly ReadDate(string prompt, DateOnly defaultValue)
        {
            // Ask user for a date. If no data was provided use default value.
            // User must be informed what the default value is.
            // If provided date is in invalid format, ask user again.
            while (true)
            {
                PrintPrompt(prompt, defaultValue.ToString(" MM / dd / yyyy "));
                var userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                    return defaultValue;

                try
                {
                    return DateOnly.Parse(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Bad date format! Specify in the following way: dd / mm / yyyy ");
                }
            }
        }

        public int ReadInt(string prompt, int defaultValue)
        {
            // Ask user for a number. If no data was provided use default value.
            // User must be informed what the default value is.
            while (true)
            {
                PrintPrompt(prompt, defaultValue);
                var userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                    return defaultValue;

                try
                {
                    return int.Parse(userInput);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Enter an integer! ");
                }
            }
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
