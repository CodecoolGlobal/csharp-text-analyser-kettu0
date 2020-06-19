using System;
using System.IO;

namespace csharp_text_analyser_kettu0
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent textToExamine = new FileContent("test.txt", "test.txt");
            StatisticalAnalysis characterAnalysis = new StatisticalAnalysis(textToExamine.CharIterator());
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(textToExamine.WordIterator());           
            var occurance = wordAnalysis.OccurMoreThan(4);
            foreach(string word in occurance)
            {
                Console.WriteLine(word);
            }

            var occuranceChar = characterAnalysis.OccurMoreThan(5);
            foreach(string character in occuranceChar)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine(textToExamine.GetFilename());
            Console.WriteLine($"Number of characters: {characterAnalysis.Size()}");
            Console.WriteLine($"Number of words: {wordAnalysis.Size()}");
            Console.WriteLine($"Author's dictionary: {wordAnalysis.DictionarySize()}");
            Console.WriteLine($"Count of word 'the': {wordAnalysis.CountOf("the")}");
            Console.WriteLine($"Vowels %: {characterAnalysis.vowelsProcentage()}");
        }
    }
}
