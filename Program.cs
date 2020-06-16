using System;

namespace csharp_text_analyser_kettu0
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent textToExamine = new FileContent("test2.txt");
            StatisticalAnalysis characterAnalysis = new StatisticalAnalysis(textToExamine.CharIterator());
        }
    }
}
