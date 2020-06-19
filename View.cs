using System;
using System.Collections.Generic;

namespace csharp_text_analyser_kettu0
{
public class View
{
    public void Print(int number, string message)
    {
        Console.WriteLine($"{message}: {number}");
    }

    public void Print(double percent, string message)
    {
        Console.WriteLine($"{message}: {percent.ToString("F2")}");
    }

    public void Print(Dictionary<string, double> dictionaryStatistics, string message)
    {
        Console.WriteLine($"{message}: ");
        foreach (string dictionaryKey in dictionaryStatistics.Keys)
        {
            Console.WriteLine($"[{dictionaryKey} -> {dictionaryStatistics[dictionaryKey].ToString("F2")}]");
        }
    }

    public void Print(List<string> listStatistics, string message)
    {
        string elementString = "";

        foreach (string element in listStatistics)
        {
            elementString += element + ", ";
        }

        Console.WriteLine($"{message}: [{elementString.TrimEnd(new char[] {',', ' '})}]");
    }
    
    public void Print(ISet<string> setStatistics, string message)
    {
        Console.WriteLine($"{message}: ");
        foreach (string element in setStatistics)
        {
            Console.WriteLine($"{element}, ");
        }
    }
}


}
