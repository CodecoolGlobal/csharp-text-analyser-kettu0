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

        public Int32 CountOf(string[] textArray)
        {
           throw new System.NotImplementedException();
        }

        public Int32 DictionarySize()
        {
           throw new System.NotImplementedException();
        }

        public Int32 Size()
        {
           throw new System.NotImplementedException();
        }

        public ISet<string> OccurMoreThan(Int32 number)
        {
           throw new System.NotImplementedException();
        }
    }


}