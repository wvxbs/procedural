using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using CommandLine;

using procedural.src;

namespace procedural
{
    class Program
    {

        static string DefaultTypeError = "Insira um tipo válido";
        static string IndexOutOfBounds = "Selecione uma ação valida";

        public class Options
        {
            [Option('c', "criptografia", Required = true, HelpText = "Selecionar criptografia")]
            public bool criptografia { get; set; }

            [Option('t', "texto", Required = true, HelpText = "Inserir texto")]
            public bool texto { get; set; }

            [Option('k', "chave", Required = false, HelpText = "Inserir chave")]
            public bool chave { get; set; }

            [Option('a', "acao", Required = true, HelpText = "Criptografar e descriptografar")]
            public bool acao { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                    if(o.criptografia)
                    {
                        Ex1 e1 = new Ex1();
                    }
                    if(o.texto)
                    {

                    }
                    if(o.chave)
                    {

                    }
                    if(o.acao)
                    {

                    }
                   });
        }
        
        static void getUserInput()
        {
            int select = 0;
            Print("1 para operações com Rot13\n2 para operações com Vigenére");
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

            List<char> l = new List<char>();

            foreach (char c in code.ToCharArray())
            {
                if (c == 32) l.Add(c); 
                else
                {
                    int i = c + 13;
                    if (i > 90)
                    {
                        i = (i - 90) + 64;
                    }
                    char temp = Convert.ToChar(i);
                    l.Add(temp);
                }

            }

            Print("Resultado:\n");

            printRot13(l);
        }

        static void printRot13(List<char> l)
        {
            for(int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i].ToString());
            }

            Print("");
        }

        //

        static void Ex2 ()
        {

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
