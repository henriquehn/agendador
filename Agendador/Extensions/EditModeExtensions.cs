using System;

namespace Agendador.Extensions
{
    static class EditModeExtensions
    {
        public static bool Contains(this EditMode value, params EditMode[] values)
        {
            foreach (var current in values)
            {
                if ((value & current) != EditMode.None)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsAll(this EditMode value, params EditMode[] values)
        {
            foreach (var current in values)
            {
                if ((value & current) == EditMode.None)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
