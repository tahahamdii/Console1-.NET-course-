using System;

class Program
{
    static void Main()
    {
        bool continueTransforming = true;

        while (continueTransforming)
        {
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            // Transformation 1: Convert to Uppercase
            string uppercaseString = userInput.ToUpper();
            Console.WriteLine("Uppercase: " + uppercaseString);

            // Transformation 2: Replace Spaces with Underscores
            string underscoredString = userInput.Replace(' ', '_');
            Console.WriteLine("Underscored: " + underscoredString);

            // Transformation 3: Reverse the String
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed: " + reversedString);

            Console.WriteLine("Do you want to enter another string? (yes/no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                continueTransforming = false;
            }
        }

        Console.WriteLine("Program finished. Press Enter to exit.");
        Console.ReadLine(); // to keep the console window open
    }
}
