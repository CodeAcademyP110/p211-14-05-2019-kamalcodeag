using System;
using System.Text;

namespace P110_ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Try Parse
            //Console.Write("Reqem daxil edin:");
            //string demo = Console.ReadLine();
            //int kamal;

            //bool hasSucceeded = int.TryParse(demo, out kamal);

            //while (!hasSucceeded)
            //{
            //    Console.Write("Duzgun reqem daxil edin:");
            //    demo = Console.ReadLine();
            //    hasSucceeded = int.TryParse(demo, out kamal);
            //}
            #endregion

            #region Classwork reverse sentence by words
            //Console.WriteLine("Please, input a sentence:");
            //string userInput = Console.ReadLine();
            //string result = "";
            ////salam samir qaqa
            ////malas rimas aqaq

            ////1. Split sentence into words
            //string[] words = userInput.Split(' ');

            ////2. loop words in order
            //for (int i = 0; i < words.Length; i++)
            //{
            //    //3. loop in word in reverse order
            //    string word = words[i];
            //    for (int j = word.Length - 1; j >= 0; j--)
            //    {
            //        result += word[j];
            //    }
            //    result += " ";
            //}

            //Console.WriteLine(result);
            #endregion

            #region Array resize
            //long currentReservedMemory = GC.GetTotalMemory(false);
            //Console.WriteLine(currentReservedMemory);

            //int[] numbers = new int[5];
            //numbers[0] = 15;
            //numbers[1] = 25;
            //numbers[2] = 5;
            //numbers[3] = 3;
            //numbers[4] = 7;

            //Array.Resize(ref numbers, 6);
            #endregion

            #region Char
            //char letterAInt = 'a';
            //Console.WriteLine((int)letterAInt);

            //for(char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.Write(c);
            //    Console.Write(",");
            //}

            //Console.WriteLine(GetLetter(5));
            #endregion

            #region Strings

            //Console.WriteLine("Salam" + ", " + " Samir");

            //StringBuilder word = new StringBuilder();
            //word.Append("12345678901234567");
            //word.Remove(4, 3);

            //Console.WriteLine(word.Length);
            //Console.WriteLine(word.Capacity);
            //Console.WriteLine(word);

            int[] n = { 10, 20, 40 };
            Sum(n);

            #endregion
        }

        //static char GetLetter(int n)
        //{
        //    return (char)('a' + n - 1);
        //}

        static void Sum(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
			{
                Console.WriteLine(numbers[i]);
			}
            Console.ReadLine();
        }

    }
    
}
