using System;

namespace procedural.src
{
    public class Convert
    {
        public Convert()
        {

        }

        public char[] ConvertKey(char[] Val, char[] Key)
        {
            int z = 0;
            char[] converted = new char[Val.Length];

            for (int i = 0; i < Val.Length; i++)
            {

                if (z > Key.Length - 1) z = 0;
                if (Val[i] == 32) converted[i] = Val[i];
                else
                {

                    converted[i] = Key[z];
                    z++;
                }
            }
            return converted;
        }
    }
}