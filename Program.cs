using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            int i = 0;

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
        
        static void LoadJSON() 
        {
            var weatherForecast = JsonSerializer.DeserializeAsync(OpenFile("index.json"));
        }   

        static FileStream OpenFile(string path)
        {   
            using (FileStream fs = File.OpenRead(""))
            {
                return fs;
            }
        }

        public class Obj
        {
            string character;
            int index;
        }

        static void Error(string error)
        {
            Console.WriteLine($"Erro: {error}");
        }
    }
}
