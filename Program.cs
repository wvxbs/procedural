using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace procedural
{
    class Program
    {

        static string DefaultTypeError = "Insira um tipo válido";
        static string IndexOutOfBounds = "Selecione uma ação valida";

        static void Main(string[] args)
        {
            while(true) {
                getUserInput();
            }
        }
        
        static void getUserInput()
        {
            int select = 0;
            Print("1 para operações com rot13\n2 para operações com cifra");
            if(int.TryParse(Console.ReadLine(), out select))
            {
                processUserInput(select);
            }
            else
            {
                Error(DefaultTypeError);
            }
        }

        static void processUserInput(int select)
        {
            switch(select)
            {
                case 1:
                    Ex1();
                break;
                case 2:
                    Ex2();
                break;
                case 0:
                break;
                default:
                    Error(IndexOutOfBounds);
                break;
            }
        }

        //

        static void Ex1 ()
        {
            int select = 0;
            int i = 0;

            Print("1 para criptografar texto\n2 para descriptografar texto\n0 para sair");
            if(int.TryParse(Console.ReadLine(), out select))
            {
                Ex1Actions(select);
            }
            else
            {
                Error(DefaultTypeError);
            }
        }

        static void Ex1Actions (int select)
        {
            string str = "";

            Print("Insira o Texto");
            str = Console.ReadLine().ToUpper();

            if(str.Length > 0)
            {
                switch(select)
                {
                    case 1:
                        ProcessRot13(str);
                    break;
                    case 2:
                        ProcessRot13(str);
                    break;
                    case 0:
                    break;
                    default:
                        Error(IndexOutOfBounds);
                    break;
                }
            }
        }

        static void ProcessRot13(string code)
        {
            foreach (char c in code.ToCharArray())
            {
                if (c == 32) Print(c.ToString()); 
                else
                {
                    int i = c + 13;
                    if (i > 90)
                    {
                        i = (i - 90) + 64;
                    }
                    char i2 = (char)i;
                    Print(i2.ToString());
                }

            }
        }

        //

        static void Ex2 ()
        {

        }

        static void Ex2Actions (int select)
        {
            switch(select)
            {
                case 1:
                    Ex1();
                break;
                case 2:
                    Ex2();
                break;
                default:
                    Error(DefaultTypeError);
                break;
            }
        }

        static void ProcessVigenere(string key)
        {
            
        }

        static void Error(string error)
        {
            Print($"Erro: {error}");
        }

        static void Print(string str)
        {
            Console.WriteLine($"\n{str}");
        }
    }
}
