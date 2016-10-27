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
            {"white", ConsoleColor.White},
            {"darkred", ConsoleColor.DarkRed},
            {"darkblue", ConsoleColor.DarkBlue},
            {"darkcyan", ConsoleColor.DarkCyan},
            {"darkgray", ConsoleColor.DarkGray},
            {"darkgreen", ConsoleColor.DarkGreen},
            {"darkmagenta", ConsoleColor.DarkMagenta},
            {"darkyellow", ConsoleColor.DarkYellow}
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

        public static string Blue(this object o) => Blue(o.ToString());
        public static string Blue(this object o, bool writeLine) => Blue(o.ToString(), writeLine);
        public static string Cyan(this string s) => Cyan(s, false);

        public static string Cyan(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["cyan"]);
            else
                ColoredWrite(s, Palette["cyan"]);
            return string.Empty;
        }

        public static string Cyan(this object o) => Cyan(o.ToString());
        public static string Cyan(this object o, bool writeLine) => Cyan(o.ToString(), writeLine);
        public static string DarkBlue(this object o) => DarkBlue(o.ToString());
        public static string DarkBlue(this object o, bool writeLine) => DarkBlue(o.ToString(), writeLine);

        public static string DarkBlue(this string s) => DarkBlue(s, false);

        public static string DarkBlue(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkblue"]);
            else
                ColoredWrite(s, Palette["darkblue"]);
            return string.Empty;
        }

        public static string DarkCyan(this object o) => DarkCyan(o.ToString());
        public static string DarkCyan(this object o, bool writeLine) => DarkCyan(o.ToString(), writeLine);

        public static string DarkCyan(this string s) => DarkCyan(s, false);

        public static string DarkCyan(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkcyan"]);
            else
                ColoredWrite(s, Palette["darkcyan"]);
            return string.Empty;
        }

        public static string DarkGray(this object o) => DarkGray(o.ToString());
        public static string DarkGray(this object o, bool writeLine) => DarkGray(o.ToString(), writeLine);

        public static string DarkGray(this string s) => DarkGray(s, false);

        public static string DarkGray(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkgray"]);
            else
                ColoredWrite(s, Palette["darkgray"]);
            return string.Empty;
        }

        public static string DarkGreen(this object o) => DarkGreen(o.ToString());
        public static string DarkGreen(this object o, bool writeLine) => DarkGreen(o.ToString(), writeLine);

        public static string DarkGreen(this string s) => DarkGreen(s, false);

        public static string DarkGreen(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkgreen"]);
            else
                ColoredWrite(s, Palette["darkgreen"]);
            return string.Empty;
        }

        public static string DarkMagenta(this object o) => DarkMagenta(o.ToString());
        public static string DarkMagenta(this object o, bool writeLine) => DarkMagenta(o.ToString(), writeLine);

        public static string DarkMagenta(this string s) => DarkMagenta(s, false);

        public static string DarkMagenta(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkmagenta"]);
            else
                ColoredWrite(s, Palette["darkmagenta"]);
            return string.Empty;
        }

        public static string DarkRed(this object o) => DarkRed(o.ToString());
        public static string DarkRed(this object o, bool writeLine) => DarkRed(o.ToString(), writeLine);

        public static string DarkRed(this string s) => DarkRed(s, false);

        public static string DarkRed(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkred"]);
            else
                ColoredWrite(s, Palette["darkred"]);
            return string.Empty;
        }

        public static string DarkYellow(this object o) => DarkYellow(o.ToString());
        public static string DarkYellow(this object o, bool writeLine) => DarkYellow(o.ToString(), writeLine);

        public static string DarkYellow(this string s) => DarkYellow(s, false);

        public static string DarkYellow(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["darkyellow"]);
            else
                ColoredWrite(s, Palette["darkyellow"]);
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

        public static string Gray(this object o) => Gray(o.ToString());
        public static string Gray(this object o, bool writeLine) => Gray(o.ToString(), writeLine);
        public static string Green(this string s) => Green(s, false);

        public static string Green(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["green"]);
            else
                ColoredWrite(s, Palette["green"]);
            return string.Empty;
        }

        public static string Green(this object o) => Green(o.ToString());
        public static string Green(this object o, bool writeLine) => Green(o.ToString(), writeLine);

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

        public static string Magenta(this object o) => Magenta(o.ToString());
        public static string Magenta(this object o, bool writeLine) => Magenta(o.ToString(), writeLine);
        public static string Red(this string s) => Red(s, false);

        public static string Red(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["red"]);
            else
                ColoredWrite(s, Palette["red"]);
            return string.Empty;
        }

        public static string Red(this object o) => Red(o.ToString());
        public static string Red(this object o, bool writeLine) => Red(o.ToString(), writeLine);
        public static string White(this string s) => White(s, false);

        public static string White(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["white"]);
            else
                ColoredWrite(s, Palette["white"]);
            return string.Empty;
        }

        public static string White(this object o) => White(o.ToString());
        public static string White(this object o, bool writeLine) => White(o.ToString(), writeLine);
        public static string Yellow(this string s) => Yellow(s, false);

        public static string Yellow(this string s, bool writeLine)
        {
            if (writeLine)
                ColoredWriteLine(s, Palette["yellow"]);
            else
                ColoredWrite(s, Palette["yellow"]);
            return string.Empty;
        }

        public static string Yellow(this object o) => Yellow(o.ToString());
        public static string Yellow(this object o, bool writeLine) => Yellow(o.ToString(), writeLine);

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