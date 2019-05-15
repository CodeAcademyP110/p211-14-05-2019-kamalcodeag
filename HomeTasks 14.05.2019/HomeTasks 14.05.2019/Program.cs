using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_14._05._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HomeTask1
            //string input = "abcd efgh qwer adadadasd dasdasd sdadasdasd asdasdas sadad";
            //Console.WriteLine("Enter your sentence to find the number of spaces into it");
            //string input = Console.ReadLine();
            //string[] inputResult = input.Split(' ');
            //FindTheNumberOfSpaces(inputResult);
            #endregion

            #region HomeTask2
            //int[] input = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Enter numbers by commas as you want");
            //string input = Console.ReadLine();
            //string[] input2 = input.Split(',');
            //FindAverageNumber(input2);
            #endregion

            #region HomeTask3
            //string input = Console.ReadLine();
            //string[] input2 = input.Split(' ');
            //GetArrayOfEvenNumbers(input2);
            #endregion

            #region HomeTask4
            //string input = Console.ReadLine();
            //string[] input2 = input.Split(',');
            //FindElderThanAverageNumber(input2);
            #endregion

            #region HomeTask5
            //string input = Console.ReadLine();
            //string input2 = Console.ReadLine();
            //int firstNumber = int.Parse(input);
            //int secondNumber = int.Parse(input2);
            //FindPowerOfNumber(firstNumber, secondNumber);
            #endregion

            #region HomeTask6
            //string input = Console.ReadLine();
            //string[] input2 = input.Split(' ');
            //FindLongWord(input2);
            #endregion

            #region HomeTask7
            //string input = Console.ReadLine();
            //string[] input2 = input.Split(',');
            //ConcatWords(input2);
            #endregion

        }

        #region HomeTask1
        //static void FindTheNumberOfSpaces(string[] sentence)
        //{
        //    int spacesNumber = sentence.Length - 1;
        //    Console.WriteLine(spacesNumber);
        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask2
        //static void FindAverageNumber(string[] numbers)
        //{
        //    int total = 0;
        //    double result = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        total += int.Parse(numbers[i]);
        //        result = total / numbers.Length;
        //    }
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask3
        //static void GetArrayOfEvenNumbers(string[] numbers)
        //{
        //    string result = "";
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        int number = int.Parse(numbers[i]);

        //        if (number % 2 == 0)
        //        {
        //            result += number + " ";

        //            //for (int j = 0; j < result.Length; j++)
        //            //{
        //            //    if(result[result.Length - 1] == ',')
        //            //    {
        //            //        result[result.Length - 1] = '.';
        //            //    }
        //            //}

        //        }

        //    }
        //    Console.Write(result);
        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask4
        //static void FindElderThanAverageNumber(string[] numbers)
        //{
        //    int total = 0;
        //    int average = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        int number = int.Parse(numbers[i]);
        //        total += number;
        //        average = total / numbers.Length;


        //    }

        //    for (int j = 0; j < numbers.Length; j++)
        //    {
        //        int number = int.Parse(numbers[j]);
        //        if (number > average)
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }

        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask5
        //static void FindPowerOfNumber(int number1,int number2)
        //{
        //    int number = number1;
        //    for (int i = 1; i < number2; i++)
        //    {
        //        number1 = number * number1;
        //    }

        //    Console.WriteLine(number1);
        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask6
        //static void FindLongWord(string[] words)
        //{
        //    string longWord = " ";
        //    int length = words[0].Length;

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (length < words[i].Length)
        //        {
        //            length = words[i].Length;
        //            longWord = words[i];
        //        }
        //        else
        //        {
        //            longWord = words[0];
        //        }
        //    }
        //    Console.Write(longWord);

        //    Console.ReadLine();
        //}
        #endregion

        #region HomeTask7
        //static void ConcatWords(string[] words)
        //{
        //    //string result = "";
        //    //string result2 = "";
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        //result += words[i];
        //        //result2 = result + ",";
        //        Console.Write(words[i] + ',');
        //    }

        //    Console.ReadLine();
        //}
        #endregion
    }
}
