using System;

namespace procedural.src
{
    public class Decripto
    {
        public Decripto()
        {
                      
        }

        public char[] Val(char[] Val, char[] ConvertedKey)
        {
            char[] Valed = new char[Val.Length];
            int Result;

            for (int i = 0; i < Val.Length; i++)
            {
                if (Val[i] == 32) Result = 32;
                else
                {
                    Result = ((Val[i] - ConvertedKey[i] + 26) % 26) + 65; 
                }
                Valed[i] = (char)Result; 
            }
            return Valed;
        }
    }
}