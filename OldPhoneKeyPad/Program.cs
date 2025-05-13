//using System;
//using System.Text;
//using System.Collections.Generic;

//public class Program
//{
//    public static char key = ' ';
//    public static List<char> storeletters = new List<char>();
//    public static List<char> Finalresult = new List<char>();
//    public static string[] keypad = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

//    public static string OldPhonePad(string input)
//    {
//        input.ToList();
//        Console.Write("#");
//        var totalcount = storeletters.Count;
//        for (var i = 1; i < storeletters.Count; i++)
//        {
//            if (storeletters[i] == '*')
//            {
//                int k = i + 1;
//                totalcount = totalcount - 2;
//                for (var j = i - 1; j < totalcount; j++)
//                {
//                    storeletters[j] = storeletters[k];
//                    k++;
//                }
//                storeletters.RemoveRange(storeletters.Count - 2, 2);
//            }
//        }


//        for (int i = 0; i < storeletters.Count; i++)
//        {
//            if (storeletters[i] != ' ')
//            {
//                int index = 0;
//                for (int j = i; j < storeletters.Count; j++)
//                {
//                    if (storeletters[i] == storeletters[j])
//                    {
//                        index++;
//                    }
//                    else
//                    {

//                        break;
//                    }
//                }

//                int number = int.Parse(storeletters[i].ToString());
//                if (number == 7 || number == 8)
//                {
//                    if (index > 4)
//                    {
//                        Console.WriteLine();
//                        Console.WriteLine("?????");
//                        Console.ReadKey();
//                        Environment.Exit(0);
//                    }
//                }
//                else
//                {
//                    if (index > 3)
//                    {
//                        Console.WriteLine();
//                        Console.WriteLine("?????");
//                        Console.ReadKey();
//                        Environment.Exit(0);
//                    }
//                }
//                string lettercoll = keypad[number];
//                lettercoll.ToCharArray();
//                Finalresult.Add(lettercoll[index]);
//                if (index > 1)
//                {
//                    i += index - 1;
//                }
//            }
//        };
//        return (Finalresult.ToString());
//    }

//    public static void Main(string[] args)
//    {

//        while (true)
//        {
//            ConsoleKeyInfo pressedkey = Console.ReadKey(true);
//            if (pressedkey.KeyChar == '#' || pressedkey.KeyChar == '*' || pressedkey.KeyChar == ' ' || char.IsDigit(pressedkey.KeyChar))
//            {
//                if (pressedkey.KeyChar == '#')
//                {
//                    var final = OldPhonePad(storeletters.ToString());
//                    final.ToList();
//                    Console.WriteLine();
//                    for (int i = 0; i < Finalresult.Count; i++)
//                    {
//                        Console.Write(Finalresult[i].ToString());
//                    }
//                }
//                else
//                {
//                    Console.Write(pressedkey.KeyChar);
//                    storeletters.Add(pressedkey.KeyChar);
//                }
//            }

//        }

//    }
//}