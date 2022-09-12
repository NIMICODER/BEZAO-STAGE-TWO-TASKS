using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_translate_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Text to convert to Pig-Latin word: ");
            string text = Console.ReadLine();
            string pigLatin = Translate(text);
            Console.WriteLine($"Translation: {pigLatin}");
            Console.WriteLine();

            Console.WriteLine("Enter a Pig-Latin word to convert back English: ");
            string pigword = Console.ReadLine();
            string plainText = TranslateBackToEnglish(pigword);
            Console.WriteLine($"Translation: {plainText}");

            string Translate(string sentence)
            {
                string[] words = sentence.Split(' ');
                var result = string.Empty;

                foreach (var word in words)
                {
                    bool isUpper = false;
                    var firstChar = word[0];

                    if (Char.IsUpper(firstChar))
                        isUpper = true;

                    var temp = "";

                    for (int i = 1; i < word.Length; i++)
                    {
                        if (isUpper && i == 1)
                        {
                            temp += Char.ToUpper(word[i]);
                            continue;
                        }

                        temp += word[i];
                    }

                    temp += Char.ToLower(firstChar);
                    temp += "ay";
                    result += $"{temp} ";


                }

                return result;
            }
            string TranslateBackToEnglish(string sentence)
            {
                var result = string.Empty;
                string[] words = sentence.Trim().Split(' ');


                foreach (var word in words)
                {
                    bool isUpper = false;

                    if (Char.IsUpper(word[0]))
                        isUpper = true;

                    string temp = "";
                    char firstChar = word[word.Length - 3];

                    if (isUpper)
                    {
                        temp += Char.ToUpper(firstChar);
                    }
                    else
                        temp += firstChar;

                    for (int i = 0; i < word.Length - 3; i++)
                    {
                        temp += Char.ToLower(word[i]);
                    }

                    result += $"{temp} ";
                }

                return result;
            }
        }
    }
}
