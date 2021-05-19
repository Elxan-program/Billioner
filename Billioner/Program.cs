using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billioner
{
    class Program
    {
        static void Question1()
        {
            Console.WriteLine("Azerbaycanin paytaxti?\nA)Baki\nB)Mingechevir\nC)Sumqayit\nD)Sidney");
        }
        static void CorrectAnswer()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Your Answer Is Correct");
            Console.ResetColor();
        }
        static void WrongAnswer()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Answer Is Not Correct");
            Console.ResetColor();
        }
        static void NotFoundAnswer()
        {
            Console.WriteLine("There Is Not Answer Which You Write");//ERROR 404
        }
        static void Question2()
        {
            Console.WriteLine("1941-194 ci illerde ne bas verib?\nA)1-ci dunya muharibesi\nB)2-ci dunya muharibesi\nC)Kosmik yarish\nD)SSRI dagildi");
        }
        static void Question3()
        {
            Console.WriteLine("Roma hansi olkenin seheri ve paytaxtidir?\nA)Mozambik\nB)Banqladesh\nC)Efqanistan\nD)Italiya");
        }
        static void Question4()
        {
            Console.WriteLine("Vyetnamin paytaxti?\nA)Moskva\nB)Laos\nC)Hanoy\nD)Xiamen");
        }
        static void Question5()
        {
            Console.WriteLine("Amerika Birlesmis Statlar ne vaxt musteqil oldu?\nA)1776\nB)1919\nC)1204\nD)2021");
        }
        static void Question6()
        {
            Console.WriteLine("Azerbaycanin ehalisinin sayi?\nA)22000000\nB)12000000\nC)12000\nD)10000000");
        }
        static int CalculateAllPoints(int pt1, int pt2, int pt3, int pt4, int pt5, int pt6)
        {
            return pt1 + pt2 + pt3 + pt4 + pt5 + pt6;
        }
        static void Main(string[] args)
        {
            int point1 = 0; int point2 = 0;
            int point3 = 0; int point4 = 0;
            int point5 = 0; int point6 = 0;

            Question1();
            bool answer = char.TryParse(Console.ReadLine(), out char result);
            result = char.ToUpper(result);
            switch (result)
            {
                case 'A':
                    {
                        CorrectAnswer();
                        point1 = 5;
                        break;
                    }
                case 'B':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'C':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'D':
                    {
                        WrongAnswer();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There Is Not Answer Which You Write");
                        break;
                    }
            }

            Question2();
            bool answer2 = char.TryParse(Console.ReadLine(), out char result2);
            result2 = char.ToUpper(result2);
            switch (result2)
            {
                case 'A':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'B':
                    {
                        CorrectAnswer();
                        point2 = 5;
                        break;
                    }
                case 'C':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'D':
                    {
                        WrongAnswer();
                        break;
                    }
                default:
                    {
                        NotFoundAnswer();
                        break;
                    }
            }

            Question3();
            bool answer3 = char.TryParse(Console.ReadLine(), out char result3);
            result3 = char.ToUpper(result3);
            switch (result3)
            {
                case 'A':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'B':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'C':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'D':
                    {
                        CorrectAnswer();
                        point3 = 5;
                        break;
                    }
                default:
                    {
                        NotFoundAnswer();
                        break;
                    }
            }

            Question4();
            bool answer4 = char.TryParse(Console.ReadLine(), out char result4);
            result4 = char.ToUpper(result4);
            switch (result4)
            {
                case 'A':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'B':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'C':
                    {
                        CorrectAnswer();
                        point4 = 5;
                        break;
                    }
                case 'D':
                    {
                        WrongAnswer();
                        break;
                    }
                default:
                    {
                        NotFoundAnswer();
                        break;
                    }
            }

            Question5();
            bool answer5 = char.TryParse(Console.ReadLine(), out char result5);
            result5 = char.ToUpper(result5);
            switch (result5)
            {
                case 'A':
                    {
                        CorrectAnswer();
                        point5 = 5;
                        break;
                    }
                case 'B':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'C':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'D':
                    {
                        WrongAnswer();
                        break;
                    }
                default:
                    {
                        NotFoundAnswer();
                        break;
                    }
            }

            Question6();
            bool answer6 = char.TryParse(Console.ReadLine(), out char result6);
            result6 = char.ToUpper(result6);
            switch (result6)
            {
                case 'A':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'B':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'C':
                    {
                        WrongAnswer();
                        break;
                    }
                case 'D':
                    {
                        CorrectAnswer();
                        point6 = 5;
                        break;
                    }
                default:
                    {
                        NotFoundAnswer();
                        break;
                    }
            }

            Console.WriteLine("\nSum Of Your All point is " + CalculateAllPoints(point1, point2, point3, point4, point5, point6));
        }
    }
}
