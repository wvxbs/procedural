using System;
using System.Collections.Generic;
using System.IO;
using Newstonsoft.json;

namespace procedural
{
    class Program
    {
        static void Main(string[] args)
        {
            getUserInput();
        }

        static void getUserInput()
        {
            int select = 0;
            Console.WriteLine("1 para operações com rot13\n2 para operações com cifra");
            if(int.TryParse(Console.ReadLine(), out select))
            {
                processUserInput(select);
            }
            else
            {
                Error("tipo de entrada errado");
            }
        }

        static void processUserInput(int select)
        {
            int i;

            while(i == 0)
            {
                if(select == 1)
                {
                    Ex1();
                }
                else
                if(select == 2)
                {
                    Ex2();
                }
                else
                if(select == 0)
                {
                    i++;
                }
                else
                {
                    Error("tipo de enrada inválido");
                }
            }
        }

        static void Ex1 ()
        {
            int select = 0;

            Console.WriteLine("1 para criptografar texto\n2 para descriptografar texto\n0 para sair");
            if(int.TryParse(Console.ReadLine(), out select))
            {
                        
            }
        }

        static void Ex2 ()
        {

        }

        static void ProcessRot13()
        {
            
        }

        static void loadJson()
            RootObject ro = new RootObject();
                try
                {

                    StreamReader sr = new StreamReader(FileLoc);
                    string jsonString = sr.ReadToEnd();
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    ro = ser.Deserialize<RootObject>(jsonString);


            }
        }

        public class RootObject 
        {
            string characte;
            int index;
        }

        static void Error(string error)
        {
            Console.WriteLine($"Erro: {error}");
        }
    }
}
