using System;

namespace procedural.src
{
    class Ex2
    {
        public Ex2 ()
        {
            Ex2Actions();
        }

        static void Ex2Actions (/)
        {
            bool Run = true;
            var con = new Convert();

            Console.WriteLine("Insira o texto")
            string text = Console.ReadLine();
            Console.WriteLine("Insira a chave");
            string key = Console.ReadLine();

            char[] convertedText = con.ConvertKey(text.ToUpper().ToCharArray(), key.ToUpper().ToCharArray());

            string Val = "";
            
            while(Run)
            {
                switch(select)
                {
                    case 1:
                        Console.WriteLine("");
                        try
                        {
                            Val = Console.ReadLine();
                            var cr = new Cripto();

                            cr.Criptograph(Val.ToCharArray(), key);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    break;
                    case 2:
                        var dc = new Decripto();
                    break;
                    default:
                        
                    break;
                }
            }
        }
    }
}
