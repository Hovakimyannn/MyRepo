using System;

namespace Kesar
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Write\n 1: Text to Code\n 2: Code to Text");
                int.TryParse(Console.ReadLine(), out int select);
                int key;
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Text to Code");
                        Console.Write("Kesar Key: ");
                        int.TryParse(Console.ReadLine(), out key);
                        Console.Write("Text: ");
                        Console.WriteLine(Console.ReadLine().ToLower().ToCode(key));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Code To Text");
                        Console.Write("Kesar Key: ");
                        int.TryParse(Console.ReadLine(), out key);
                        Console.Write("Code: ");
                        Console.WriteLine(Console.ReadLine().ToLower().ToText(key));
                        break;

                    default:
                        Console.WriteLine("I have not this Function");
                        break;
                }
                Console.WriteLine("Please press any key to countionue");
                Console.ReadKey(true);
                Console.Clear();
            }
        }


    }

    static class Code
    {
        public static string ToCode(this string text, int key)
        {
            string code = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 96 && text[i] < 123)
                {
                    int c = text[i] - key;
                    if (c < 97) c = text[i] + 26 - key;
                    code += ((char)c).ToString();
                }
                else
                {
                    code += text[i].ToString();
                }
            }
            return code;
        }

        public static string ToText(this string code, int key)
        {
            string text = "";
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] > 96 && code[i] < 123)
                {
                    int c = code[i] + key;
                    if (c > 122) c = code[i] - 26 + key;
                    text += ((char)c).ToString();
                }
                else
                {
                    text += code[i].ToString();
                }
            }
            return text;
        }
    }
}
