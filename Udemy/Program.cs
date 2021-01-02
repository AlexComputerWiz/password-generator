using System;
using System.Diagnostics;
using System.Dynamic;

namespace Udemy
{
    class Program
    { 
        static void Main(string[] args)
        {
            // ask for length of password
            Console.WriteLine("Enter the length of your desired password: ");
            var passwordLengthInput = Console.ReadLine();

            // convert string to int
            var passwordLength = Convert.ToInt32(passwordLengthInput);
            Console.WriteLine("{0}", passwordLength);

            var random = new Random();
            for (var i = 0; i < passwordLength; i++)
            {
                var characterTypeSelection = (random.Next(0, 4)); // maxValue cannot be used, which is why it's 4 here. Only 0-3 are valid.

                switch (characterTypeSelection)
                {
                    case 0: // lowercase
                        Console.Write((char)random.Next(97, 122));
                        continue;
                    case 1: // uppercase
                        Console.Write((char)random.Next(65, 90));
                        continue;
                    case 2: // number
                        Console.Write(random.Next(0, 9));
                        continue;
                    case 3: // symbol
                        int[] symbols =
                        {
                            126, 96, 33, 64, 35, 36, 37, 94, 38, 42, 40, 41, 95, 45, 43, 61, 123, 125, 91, 93, 124, 92,
                            58, 59, 34, 39, 60, 44, 62, 46, 63, 47
                        }; // ~`! @#$%^&*()_-+={[}]|\:;"'<,>.?/
                        int index = random.Next(symbols.Length);
                        Console.Write((char)symbols[index]);
                        continue;
                }
            }

        }

    }
}