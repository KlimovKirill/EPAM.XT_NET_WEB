using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._3._2.SuperString
{
    public enum Languages
    {
        English,
        Russian,
        Number,
        Mixed
    }

    public static class StringExtension
    {
        public static Languages LanguageDetermination(this string text)
        {
            if (text.All(symb => symb >= '\x41' && symb <= '\x7A'))
            {
                return Languages.English;
            }
            else if (text.All(symb => (symb >= '\x410' && symb <= '\x44F') || symb == '\x401' || symb == '\x451'))
            {
                return Languages.Russian;
            }
            else if (text.All(symb => symb >= '\x30' && symb <= '\x39'))
            {
                return Languages.Number;
            }
            else
            {
                return Languages.Mixed;
            }
        }
    }
}
