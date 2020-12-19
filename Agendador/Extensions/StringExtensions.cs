using System;

namespace Agendador.Extensions
{
    static class StringExtensions
    {
        public static string SafeTrim(this string value)
        {
            if (value==null)
            {
                return "";
            }
            else
            {
                return value.Trim();
            }
        }

    }
}
