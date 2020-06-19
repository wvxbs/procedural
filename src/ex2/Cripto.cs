using System;

namespace procedural.src
{
    public class Cripto
    {
        public Cripto()
        {
              
        }

        public char[] Criptograph(char[] Val, char[] ConvertedKey)
        {
            char[] Criptographed = new char[Val.Length];
            int Result;

            for (int i = 0; i < Val.Length; i++)
            {
                if (Val[i] == 32) Result = 32;
                else
                {
                    Result = ((Val[i] + ConvertedKey[i]) % 26) + 65; 
                }
                Criptographed[i] = (char)Result;
            }
            return Criptographed;
        }
    }
}