using System;
using System.Text;
using System.Collections.Generic;

public class Program
{


    public static string OldPhonePad(string input)
    {
        List<char> storeletters = new List<char>();
        List<char> Finalresult = new List<char>();
        string[] keypad = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
        Console.WriteLine(input);
        input.ToList();
        storeletters = input.ToList();
        var totalcount = storeletters.Count;
        for (var i = 1; i < storeletters.Count; i++)
        {
            if (storeletters[i] == '*')
            {
                int k = i + 1;
                totalcount = totalcount - 2;
                for (var j = i - 1; j < totalcount; j++)
                {
                    storeletters[j] = storeletters[k];
                    k++;
                }
                storeletters.RemoveRange(storeletters.Count - 2, 2);
            }
        }
        { }

        for (int i = 0; i < storeletters.Count - 1; i++)
        {
            if (storeletters[i] != ' ')
            {
                int index = 0;
                for (int j = i; j < storeletters.Count; j++)
                {
                    if (storeletters[i] == storeletters[j])
                    {
                        if (i != j)
                        {
                            index++;
                        }
                    }
                    else
                    {

                        break;
                    }
                }

                int number = int.Parse(storeletters[i].ToString());
                if (number == 7 || number == 8)
                {
                    if (index >= 4)
                    {
                        Console.WriteLine("?????");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (index >= 3)
                    {
                        Console.WriteLine("?????");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                string lettercoll = keypad[number];
                lettercoll.ToCharArray();
                Finalresult.Add(lettercoll[index]);
                if (index >= 1)
                {
                    i += index;
                }
            }
        };
        char[] chars = Finalresult.ToArray();

        string result = new string(Finalresult.ToArray());
        return (result);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        Console.WriteLine(OldPhonePad("22#"));
        Console.ReadKey();
    }
}