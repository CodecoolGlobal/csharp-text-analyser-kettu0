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

      public decimal vowelsProcentage()
      {
         List<string> vowels = new List<string>{"A", "E", "I", "O", "U", "Y"};
         Dictionary<string, int> vowelsAndConsonants = new Dictionary<string, int>{{"Consonants", 0}, {"Vowels", 0}};
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

         int allLetters = vowelsAndConsonants["Vowels"] + vowelsAndConsonants["Consonants"];

         return (vowelsAndConsonants["Vowels"] * 100) / allLetters;
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