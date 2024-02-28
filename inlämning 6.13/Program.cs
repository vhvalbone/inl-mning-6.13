using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string spelares_kort = "5 7 7 5 5";
        int poang = BeraknaPoang(spelares_kort);
        Console.WriteLine("Spelarens poäng: " + poang);
    }

    public static int BeraknaPoang(string kort_strang)
    {

        string[] kort_lista = kort_strang.Split();

        Dictionary<string, int> antal_kort = new Dictionary<string, int>();
        foreach (string kort in kort_lista)
        {
            if (antal_kort.ContainsKey(kort))
            {
                antal_kort[kort]++;
            }
            else
            {
                antal_kort[kort] = 1;
            }
        }

        int poang = 0;
        foreach (var par in antal_kort)
        {
            poang += int.Parse(par.Key) * par.Value;
        }

        return poang;
    }
}
