using System;
using System.Collections.Generic;

namespace csharp_text_analyser_kettu0
{
    public class StatisticalAnalysis
    {
        private Iterator _iterator;
        public StatisticalAnalysis(Iterator iterator)
        {
            this._iterator = iterator;
        }

        public Int32 CountOf(params string[] wordsToCheck)
   
         {
            int wordCounter = 0;
               
            foreach(string wordToCheck in wordsToCheck)
            {
               while(_iterator.HasNext() == true)
               {
                  string word = _iterator.MoveNext();
                  if (word == wordToCheck.ToUpper())
                  {
                     wordCounter += 1;
                  }
               }
            _iterator.Reset();
            }

         return wordCounter;
         }

      public Int32 DictionarySize()
      {
         Dictionary<string, int> authorDictionary = new Dictionary<string, int>();
         int sumOfOccurences = 0;

         while (_iterator.HasNext() == true)
         {
            string word = _iterator.MoveNext();
            if (!authorDictionary.ContainsKey(word))
            {
               authorDictionary.Add(word, 1);
               
            }
            else if (authorDictionary.ContainsKey(word))
            {
               authorDictionary[word]++;
            }
         }
       
         foreach (string occurences in authorDictionary.Keys)
         {
            sumOfOccurences += 1;
         }
      _iterator.Reset();
      return sumOfOccurences;
      }

      public Int32 Size()
      {
         Int32 counter = 0;
         while (_iterator.HasNext() == true)
         {
            _iterator.MoveNext();
            counter += 1;
         }
         _iterator.Reset();
         return counter;
      }

      public double vowelsProcentage()
      {
         List<string> vowels = new List<string>{"A", "E", "I", "O", "U", "Y"};
         Dictionary<string, double> vowelsAndConsonants = new Dictionary<string, double>{{"Consonants", 0}, {"Vowels", 0}};
         while (_iterator.HasNext() == true)
         {
            string character = _iterator.MoveNext();

               if (vowels.Contains(character))
               {
                  vowelsAndConsonants["Vowels"]++;
               }
               else if (!vowels.Contains(character))
               {
                  vowelsAndConsonants["Consonants"]++;
               }
         }
         _iterator.Reset();

         int allLetters = this.Size();
         return (vowelsAndConsonants["Vowels"] * 100) / allLetters;
      }

      public double AERatio()
      {
         Dictionary<string, double> AEDictionary = new Dictionary<string, double>{{"A", 0}, {"E", 0}};
         while (_iterator.HasNext() == true)
         {
            string letter = _iterator.MoveNext();

            if (letter == "A")
            {
               AEDictionary["A"]++;
            }
            else if (letter == "E")
            {
               AEDictionary["E"]++;
            }
         }
         _iterator.Reset();
         return AEDictionary["A"]/AEDictionary["E"];
      }

      public Dictionary<string, double> eachLetterProcentage()
      {
         Dictionary<string, double> lettersOccurance = new Dictionary<string, double>();
         
         int allLetters = this.Size();

         while (_iterator.HasNext() == true)
         {
            string letter = _iterator.MoveNext();

            if (!lettersOccurance.ContainsKey(letter))
            {
               lettersOccurance.Add(letter, 1);
            }
            else if (lettersOccurance.ContainsKey(letter))
            {
               lettersOccurance[letter]++;
            }
         }
         _iterator.Reset();

         List<string> lettersProcentage = new List<string>(lettersOccurance.Keys);

         foreach(string usedLetter in lettersProcentage)
         {  
            lettersOccurance[usedLetter] = (lettersOccurance[usedLetter] / allLetters) * 100;
         }
         return lettersOccurance;
      }

      public void 
      public void Print(Dictionary<string, double> contentDictionary)
      {
            foreach (string key in contentDictionary.Keys)
            {
                Console.Write($"[{key} -> {contentDictionary[key].ToString("F2")}] ");
            }
            Console.WriteLine();
      }
      
      public ISet<string> OccurMoreThan(Int32 number)
      {
         Dictionary<string, int> countOfElements = new Dictionary<string, int>();
         var listOfElements = new SortedSet<string>();
         while (_iterator.HasNext() == true)
         {
            string element = _iterator.MoveNext();
            if (!countOfElements.ContainsKey(element))
            {
               countOfElements.Add(element, 1);
            }
            else if (countOfElements.ContainsKey(element))
            {
               countOfElements[element]++;
            }
         }

         _iterator.Reset();

         foreach (KeyValuePair<string, int> instance in countOfElements)
         {
            if (instance.Value > number)
            {
               listOfElements.Add(instance.Key);
            }
         }
         return listOfElements;
      }
   

   }
}