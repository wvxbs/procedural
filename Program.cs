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
                    Error(DefaultTypeError);
                break;
            }
        }
        static void Ex1 ()
        {
            int select = 0;
            int i = 0;

            Console.WriteLine("1 para criptografar texto\n2 para descriptografar texto\n0 para sair");
            if(int.TryParse(Console.ReadLine(), out select))
            {
                
            }
            else
            {
                Error(DefaultTypeError);
            }
        }

        static void Ex1Actions (int select)
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
                    Error(DefaultTypeError);
                break;
            }
        }

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
                case 0:
                break;
                default:
                    Error(DefaultTypeError);
                break;
            }
        }

        static void ProcessRot13()
        {
                
        }

        static void ProcessVigenere(string key)
        {
            
        }

        static void Error(string error)
        {
            Console.WriteLine($"Erro: {error}");
        }
    }
}
