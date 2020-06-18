using System;
using System.IO;

namespace csharp_text_analyser_kettu0
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent textToExamine = new FileContent("test2.txt", "test2.txt");
            StatisticalAnalysis characterAnalysis = new StatisticalAnalysis(textToExamine.CharIterator());
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(textToExamine.WordIterator());           
            Console.WriteLine(textToExamine.GetFilename());
            Console.WriteLine($"Number of characters: {characterAnalysis.Size()}");
            Console.WriteLine($"Number of words: {wordAnalysis.Size()}");
            Console.WriteLine($"Author's dictionary: {wordAnalysis.DictionarySize()}");
        }
    }
}
