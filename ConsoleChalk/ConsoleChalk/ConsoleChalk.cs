using System;
using System.Collections.Generic;

namespace DrCircuit.ConsoleUtilities
{
    public static class ConsoleChalk
    {
        private static readonly Dictionary<string, ConsoleColor> Palette = new Dictionary<string, ConsoleColor>
        {
            {"red", ConsoleColor.Red},
            {"green", ConsoleColor.Green},
            {"yellow", ConsoleColor.Yellow},
            {"cyan", ConsoleColor.Cyan},
            {"blue", ConsoleColor.Blue},
            {"magenta", ConsoleColor.Magenta},
            {"gray", ConsoleColor.Gray},
            {"white", ConsoleColor.White}
        };

        public static string Blue(this string s) => Blue(s, false);

        public static string Blue(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["blue"]);
            else
                ColoredWrite(s, Palette["blue"]);
            return string.Empty;
        }

        public static string Cyan(this string s) => Cyan(s, false);

        public static string Cyan(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["cyan"]);
            else
                ColoredWrite(s, Palette["cyan"]);
            return string.Empty;
        }

        public static string Gray(this string s) => Gray(s, false);

        public static string Gray(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["gray"]);
            else
                ColoredWrite(s, Palette["gray"]);
            return string.Empty;
        }

        public static string Green(this string s) => Green(s, false);

        public static string Green(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["green"]);
            else
                ColoredWrite(s, Palette["green"]);
            return string.Empty;
        }

        public static string Magenta(this string s)
        {
            return Magenta(s, false);
        }

        public static string Magenta(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["magenta"]);
            else
                ColoredWrite(s, Palette["magenta"]);
            return string.Empty;
        }

        public static string Red(this string s) => Red(s, false);

        public static string Red(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["red"]);
            else
                ColoredWrite(s, Palette["red"]);
            return string.Empty;
        }

        public static string White(this string s) => White(s, false);

        public static string White(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["white"]);
            else
                ColoredWrite(s, Palette["white"]);
            return string.Empty;
        }

        public static string Yellow(this string s) => Yellow(s, false);

        public static string Yellow(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["yellow"]);
            else
                ColoredWrite(s, Palette["yellow"]);
            return string.Empty;
        }

        private static void ColoredWrite(string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(s);
            Console.ResetColor();
        }

        private static void ColoredWriteLine(string s, ConsoleColor color)
        {
            ColoredWrite($"{s}{Environment.NewLine}", color);
        }
    }
}