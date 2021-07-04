using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentalsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise the input variable so we can use it for the loop.
            int input = 0;

            // Ensure the user enters a valid selection.
            while (input < 1 || input > 11)
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
                Console.WriteLine("11.  Unavailable");
                Console.WriteLine("12.  Unavailable");
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
    }
}