using System;
using System.Linq;
using System.Text;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();

        }

        static void Ex1()
        {
            /*Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
            siruri de caractere fiind citite de la tastatura*/

            string n = Console.ReadLine();
            string m = Console.ReadLine();
            Console.WriteLine(n.IndexOf(m));
        }

        static void Ex2()
        {
            /*Scrieti un program care sa verifice daca un sir de caractere citit de la
            tastatura este sau nu palindrom.*/
            string n = Console.ReadLine();
            char[] stringArray = n.ToCharArray();
            int index = n.Length;
            bool Palindorm = false;
            /* Array.Reverse(stringArray);
            // Console.WriteLine(stringArray);
           
             for (int i = 0; i < n.Length; i++)
             {
                 if (n[i] == stringArray[i])
                     Palindorm = true;
                 else Palindorm = false;
             }
             Console.WriteLine(Palindorm);*/
            for (int i = 0; i < n.Length; i++)
            {
                if (n[index - i-1] == n[i])
                {
                    Palindorm = true;
                }
                else Palindorm = false;

            }
            Console.WriteLine(Palindorm);

        }

        static void Ex3()
        {
            /*Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
de caractere. Atat caracterul cautat cat si sirul de caracter vor fi citite de la
tastatura*/
            string n = Console.ReadLine();
            char c = Console.ReadKey().KeyChar;
            int counter = 0;

            foreach (var caracter in n)
            {
                if (caracter  == c)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

            
        }

        static void Ex4()
        {
            /*Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
            de la tastatura, ignorand caseing-ul literelor.*/
            String str = "abBBBBbbbbbbbbbbbbbbracadacbra";
            str=  str.ToLower();
            int[] charCount = new int[256];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {

                charCount[str[i]]++;
               


            }
            
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }
            }
            Console.WriteLine($"The string is:{str}");
            Console.WriteLine($"The highest occurring character in the above string is:{character} " );
            Console.WriteLine($"Number of times this character occurs:{maxCount} " );
        }

        static void Ex5()
        {
            /*Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
*/
            string n = Console.ReadLine();
            StringBuilder sb = new StringBuilder(n);
            sb.Replace(n[0], char.ToUpper(n[0]));
            for (int i = 0; i <= n.Length-1; i++)
            {
                
                if (char.IsWhiteSpace(n[i]) )
                {
                   sb.Replace( n[i+1] , char.ToUpper(n[i+1])); 
                }
            }

           
            Console.WriteLine(sb);

        }

        static void Ex6()
        {
            /*Screiti un program care va numara vocalele dintr-un sir de caractere citit de
        la tastatura.
                */
            string n = Console.ReadLine();
            int vocale = 0;
            int consoane = 0;
            bool isVowel = "aeiouAEIOU".IndexOf(n[0]) >= 0;
            foreach (var item in n)
            {
                if ("aeiouAEIOU".IndexOf(item) >= 0)
                {
                   
                    vocale++;
                }
                else { consoane++; }
                    

            }
            Console.WriteLine($"vocale:{vocale},consoane:{consoane}");
        }
        
        static void Ex7()
        {
            /*Scrieti un program care va citi doua siruri de caractere de la tastatura si va
        verifica daca cele doua siruri de caractere sunt anagrame.*/
            string n = Console.ReadLine();
            string m = Console.ReadLine();
            char[] x = m.ToCharArray();
            char[] y = n.ToCharArray();
            Array.Sort(x);
            Array.Sort(y);
            Console.WriteLine(x.SequenceEqual(y));



        }


        

    }
}
