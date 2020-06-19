using System;
using System.IO;

namespace csharp_text_analyser_kettu0
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startOfAnalysis = DateTime.Now;

            foreach(var arg in args)
            {
                FileContent textToExamine = new FileContent(arg);
                {
                StatisticalAnalysis characterAnalysis = new StatisticalAnalysis(textToExamine.CharIterator());
                StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(textToExamine.WordIterator());   
                View programView = new View();        
                Console.WriteLine($"---{textToExamine.GetFilename()}---");
                programView.Print(characterAnalysis.Size(), "Number of characters");
                programView.Print(wordAnalysis.Size(), "Number of words");
                programView.Print(wordAnalysis.DictionarySize(), "Author's dictionary");
                programView.Print(wordAnalysis.CountOf("love"), "'love' count");
                programView.Print(wordAnalysis.CountOf("music"), "'music' count");
                programView.Print(wordAnalysis.CountOf("hate"), "'hate' count");
                programView.Print(characterAnalysis.vowelsProcentage(), "% of vowels");
                programView.Print(characterAnalysis.AERatio(), "a:e ratio");
                programView.Print(characterAnalysis.eachItemProcentage(), "% of every letter");
                programView.Print(wordAnalysis.MostUsedItems(), "Most used words (>1%)");
                }
                Console.WriteLine("\n");
            }
            var benchmarkSpan = DateTime.Now - startOfAnalysis;
            Console.WriteLine($"Benchmark: {benchmarkSpan.ToString("mm\\:ss\\:fff")}");
        }
    }
}

