using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentalsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise the input variable so we can use it for the loop.
            int input = 0;

            // Ensure the user enters a valid selection.
            while (input < 1 || input > 17)
            {
                // Show the user their choices.
                Console.WriteLine("Welcome to my program!\n");
                Console.WriteLine("You would like to...");
                Console.WriteLine("1.   Enter a number and have the program check if the number is divisible by three.");
                Console.WriteLine("2.   Enter some numbers until you input 'okay'.");
                Console.WriteLine("3.   Enter a number and have the program compute the factorial.");
                Console.WriteLine("4.   Attempt to guess a random number.");
                Console.WriteLine("5.   Enter some numbers and have the program find the highest.");
                Console.WriteLine("6.   Enter some names and have the program display how they liked your post.");
                Console.WriteLine("7.   Enter a name and have the program display it in reverse.");
                Console.WriteLine("8.   Enter five unique numbers and have them sorted.");
                Console.WriteLine("9.   Enter some numbers until you choose and have them displayed.");
                Console.WriteLine("10.  Enter some numbers and have the program display the smallest three.");
                Console.WriteLine("11.  Enter some numbers and have the program determine whether they're consecutive.");
                Console.WriteLine("12.  Enter some numbers and have the program determine whether there's duplicates.");
                Console.WriteLine("13.  Unavailable");
                Console.WriteLine("14.  Unavailable");
                Console.WriteLine("15.  Unavailable");
                Console.WriteLine("16.  Unavailable");
                Console.WriteLine("17.  Unavailable");
                Console.WriteLine("");

                // Take the user's choice as input.
                Console.Write("Choice: ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                // Determine which exercise they would like to launch.
                switch (input)
                {
                    case 1:
                        DivisibleByThree();
                        break;
                    case 2:
                        NumberUntilOkay();
                        break;
                    case 3:
                        ComputeFactorial();
                        break;
                    case 4:
                        GuessNumber();
                        break;
                    case 5:
                        GetMaxNumber();
                        break;
                    case 6:
                        GetLikes();
                        break;
                    case 7:
                        NameReverser();
                        break;
                    case 8:
                        FiveUniqueNumbers();
                        break;
                    case 9:
                        EnterNumbers();
                        break;
                    case 10:
                        ThreeSmallestNumbers();
                        break;
                    case 11:
                        CheckConsecutive();
                        break;
                    case 12:
                        CheckDuplicate();
                        break;
                    case 13:
                        CheckTimeFormat();
                        break;
                    case 14:
                        ConvertPascalCase();
                        break;
                    default:
                        continue;
                }
            }
        }

        static void DivisibleByThree()
        {
            // Get the start and finish parameters from the user.
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Finish: ");
            int finish = int.Parse(Console.ReadLine());

            // Set the count variable to count numbers divisible by three.
            int count = 0;

            // Loop through from start to finish and count the numbers divisible by three.
            for (int i = start; i < finish; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            // Display the result of the operation to the user.
            Console.WriteLine("Numbers Divisible By Three Between " + start + " and " + finish + ": " + count);
        }

        static void NumberUntilOkay()
        {
            // Set the sum and input variables.
            int sum = 0;
            string input = "";

            // Prompt the user for input.
            while (input != "okay")
            {
                Console.Write("Please enter 'okay' or a number: ");
                input = Console.ReadLine().ToLower();

                if (input == "okay")
                {
                    break;
                }

                sum += int.Parse(input);
            }

            Console.WriteLine(sum);
        }

        static void ComputeFactorial()
        {
            // Get input number from user.
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            int sum = input;

            // Loop through and keep multiplying sum by the next number.
            for (int i = input - 1; i > 0; i--)
            {
                sum *= i;
            }

            Console.WriteLine(input + "! = " + sum);
        }

        static void GuessNumber()
        {
            // Create Random object and declare the secret number.
            Random Random = new Random();
            int secretNumber = Random.Next(1, 10);

            // Declare variables used to determine guesses.
            const int maxGuesses = 4;
            int guess = 0;

            for (int i = 1; i <= maxGuesses; i++)
            {
                // Prompt the user to guess the secret number.
                Console.Write("Guess #" + i + ": ");
                guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You lost!");
                }
            }

            Console.WriteLine("The secret number was: " + secretNumber);
        }

        static void GetMaxNumber()
        {
            // Prompt the user to provide a comma-separated number list.
            Console.Write("Numbers: ");
            string input = Console.ReadLine();

            // Convert the string value into an array without the commas.
            string[] split = input.Split(',');

            // Declare the variable to store the highest number.
            int highestNumber = 0;

            // Loop through until we find the highest number.
            foreach (string splitString in split)
            {
                // Remove any whitespace from the array elements.
                splitString.Trim();

                // Check if the current element is the highest number seen.
                if (int.Parse(splitString) > highestNumber)
                {
                    highestNumber = int.Parse(splitString);
                }
            }

            // Write the highest found number to the console.
            Console.WriteLine("Highest Number: " + highestNumber);
        }

        static void GetLikes()
        {
            // Declare variable to store names.
            var names = new List<string>();

            // Get input of names.
            var name = "";

            do
            {
                Console.Write("Please enter a name: ");
                name = Console.ReadLine();
                if(name != "")
                    names.Add(name);
            }
            while (name != "");

            // Get amount of names entered.
            var likes = names.Count;

            // Output result depending on names.
            if (likes == 1)
                Console.WriteLine(names[0] + " liked your post.");

            if (likes == 2)
                Console.WriteLine(names[0] + " and " + names[1] + " liked your post.");

            if (likes  > 2)
                Console.WriteLine(names[0] + ", " + names[1] + ", and " + (likes - 2) + " others liked your post.");
        }

        static void NameReverser()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            char[] reverseCharacters = new char[name.Length];
            var currentChar = 0;

            for(var i = name.Length - 1; i >= 0; i--)
            {
                reverseCharacters[currentChar] = name[i];
                currentChar++;
            }

            string reverseName = "";

            for (var i = 0; i < name.Length; i++)
            {
                reverseName += reverseCharacters[i];
            }
            
            Console.WriteLine("Your reversed name is: " + reverseName);
        }

        static void FiveUniqueNumbers()
        {
            int number;
            int[] numbers = new int[5];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter a unique number: ");
                number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("ERROR: Non-Unique Number Detected! Please retry.");
                    i--;
                }
                else
                {
                    numbers[i] = number;
                }
            }

            if (numbers.Length == 5)
            {
                Array.Sort(numbers);
                
                for (var i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Number #" + (i + 1) + ": " + numbers[i]);
                }
            }
            else
            {
                Console.WriteLine("ERROR: Non-Unique Number Detected.");
            }
        }

        static void EnterNumbers()
        {
            string number;
            List<int> numbers = new List<int>();
            int intChecker = 0;

            do
            {
                Console.Write("Please enter a number: ");
                number = Console.ReadLine().ToLower();

                if (int.TryParse(number, out intChecker))
                {
                    if (!numbers.Contains(int.Parse(number)))
                    {
                        numbers.Add(int.Parse(number));
                    }
                }
            }
            while (number != "quit");

            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number #" + (i + 1) + ": " + numbers[i]);
            }
        }

        static void ThreeSmallestNumbers()
        {
            var isValid = false;
            var count = 0;
            var output = 0;
            List<int> numbers = new List<int>();

            while (isValid == false)
            {
                count = 0;

                Console.Write("Please enter a comma-separated list of numbers: ");
                string input = Console.ReadLine();

                string[] split = input.Split(',');

                foreach (string splitNumber in split)
                {
                    splitNumber.Trim();
                    count++;

                    if(int.TryParse(splitNumber, out output) && splitNumber != "")
                    {
                        numbers.Add(int.Parse(splitNumber));
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid List. Try again!");
                        isValid = false;
                        break;
                    }
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List. Try again!");
                    numbers.Clear();
                    isValid = false;
                }
            }

            numbers.Sort();

            Console.WriteLine("Three smallest numbers: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
        }

        static void CheckConsecutive()
        {
            Console.Write("Please enter numbers separated by a hyphen: ");
            string[] input = Console.ReadLine().Split("-");

            int currentNumber;
            int prevNumber;
            bool isConsecutive = true;
            bool isDescending = false;
            bool isAscending = false;

            for (var i = 0; i < input.Length; i++)
            {
                if (i != 0)
                {
                    currentNumber = int.Parse(input[i]);
                    prevNumber = int.Parse(input[i - 1]);

                    if (currentNumber - 1 == prevNumber)
                    {
                        if (!isDescending && i > 1)
                        {
                            isConsecutive = false;
                            Console.WriteLine("Not Consecutive");
                            break;
                        }

                        isDescending = true;
                    }
                    else if (currentNumber + 1 == prevNumber)
                    {
                        if (!isAscending && i > 1)
                        {
                            isConsecutive = false;
                            Console.WriteLine("Not Consecutive");
                            break;
                        }

                        isAscending = true;
                    }
                    else
                    {
                        isConsecutive = false;
                        Console.WriteLine("Not Consecutive");
                        break;
                    }
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }

            Console.ReadLine();
        }

        static void CheckDuplicate()
        {
            /*
                Write a program and ask the user to enter a few numbers separated by a hyphen.
                If the user simply presses Enter, without supplying an input, exit immediately;
                otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            */

            // Ask for the user's input.
            Console.Write("Please enter numbers separated by a hyphen: ");

            // Take the user's input and separate on the hyphens.
            var input = Console.ReadLine().Split("-");

            // Create variable to store unique numbers.
            var uniqueInput = new List<int>();

            // If the user entered some input, search for duplicates.
            if (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (uniqueInput.Contains(int.Parse(input[i])))
                    {
                        Console.WriteLine("Duplicate Detected.");
                        break;
                    }
                    else
                    {
                        uniqueInput.Add(int.Parse(input[i]));
                    }
                }
            }

            Environment.Exit(0);
        }

        static void CheckTimeFormat()
        {
            /*
                Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
                A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, "Invalid Time".
                If the user doesn't provide any values, consider it as invalid time.
            */

            // Request user input.
            Console.Write("Please enter a time value between 00:00 - 23:59: ");

            // Store user input.
            var input = Console.ReadLine().Split(":");

            // Check if the input is valid.
            if(int.Parse(input[0]) >= 0 && int.Parse(input[0]) < 24 && int.Parse(input[1]) >= 0 && int.Parse(input[1]) < 60)
            {
                Console.WriteLine("Valid input.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void ConvertPascalCase()
        {
            /*
                Write a program and ask the user to enter a few words separated by a space.
                Use the words to create a variable name with PascalCase.
                For example, if the user types: "number of students", display "NumberOfStudents".
                Make sure that the program is not dependent on the input.
                So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            */

            // Request user input.
            Console.Write("Please enter a string to convert to pascal case: ");

            // Store user input.
            var input = Console.ReadLine().ToLower().Split(" ");
            var sb = new StringBuilder();

            foreach (var split in input)
            {
                sb.Append(char.ToUpper(split[0])).Append(split[1..]);
            }

            Console.WriteLine(sb.ToString());
        }

        static void CountVowels()
        {
            /*
                Write a program and ask the user to enter an English word.
                Count the number of vowels (a, e, o, u, i) in the word.
                So, if the user enters "inadequate", the program should display 6 on the console.
            */

            // Request user input.
            Console.Write("Please enter a string to count the vowels for: ");

            // Store user input.
            var input = Console.ReadLine();
            var vowelCount = 0;

            // Loop through the characters in the input string.
            foreach (var character in input)
            {
                // If the current character is a vowel, increase the count.
                if (char.ToUpper(character) == 'A' ||
                    char.ToUpper(character) == 'E' ||
                    char.ToUpper(character) == 'I' ||
                    char.ToUpper(character) == 'O' ||
                    char.ToUpper(character) == 'U')
                {
                    vowelCount++;
                }
            }

            // Display the vowel count to the user.
            Console.WriteLine("Number of Vowels: " + vowelCount);
        }
    }
}