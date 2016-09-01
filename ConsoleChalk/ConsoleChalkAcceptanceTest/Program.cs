using System;
using System.Collections.Generic;
using DrCircuit.ConsoleUtilities;

namespace ConsoleChalkAcceptanceTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("This text should be normal");
            Console.WriteLine("Green".Green() + " should appear green");
            Console.WriteLine("Blue".Blue(true) + "should appear blue on it's own line");
            Console.WriteLine($"{"Red".Red()} Should appear red, even though it's defined in an expression");
            Console.WriteLine(" Writing " + "red".Red() + " in the middle of a string, sadly moves it first. Color calls are resolved first.");
            Console.WriteLine("Yellow".Yellow() + " and ".Gray() + "Red".Red() + " should look like two different colors...");
            Console.WriteLine("However writing ".Gray() + "red".Red() + " in the middle of a chain of calls, works!".Gray());
            "Call red on a string, will render it in red".Red();

            Console.Read();
            var words = new List<string>
            {
                "zoom",
                "fractal",
                "zeta",
                "riemann",
                "complex",
                "imaginary",
                "quantum",
                "einstein",
                "bohr",
                "csharp",
                "cplusplus",
                "basic",
                "cobol",
                "grace",
                "hopper",
                "mandelbrot",
                "ramanujan",
                "infinity",
                "undefined",
                "stackoverflow",
                "bolle",
                "danish",
                "carbonara",
                "chicks4free"
            };
            
            var colors = new List<Func<string, string>>
            {
                ConsoleChalk.Gray,
                ConsoleChalk.Green,
                ConsoleChalk.Blue,
                ConsoleChalk.Cyan,
                ConsoleChalk.Red,
                ConsoleChalk.White,
                ConsoleChalk.Yellow,
                ConsoleChalk.Magenta
            };
            PrintRandomWordsInRandomColors(words, colors);
            Console.ReadKey();
        }

        private static void PrintRandomWordsInRandomColors(List<string> words, List<Func<string, string>> colors)
        {
            Random r = new Random(1337);
            for (int i = 1000; i > 0; i--)
                colors[r.Next(0, colors.Count - 1)](words[r.Next(0, words.Count - 1)]);
        }
    }
}