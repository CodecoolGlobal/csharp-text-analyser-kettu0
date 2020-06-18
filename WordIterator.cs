using System;
using System.Collections.Generic;

namespace csharp_text_analyser_kettu0
{

    public class WordIterator : Iterator
    {
        private Int32 _currentPosition;
        private Int32 _nextStep;
        private List<string> _charList= new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        private FileContent _fileContents;
        
        public WordIterator(FileContent fileContent)
        {
            this._currentPosition = -1;
            this._nextStep = 1;
            this._fileContents = fileContent;
            
        }
        public bool HasNext()
        {
            if (_currentPosition == _fileContents.GetFileContentLength() - 1)
            {
                return false;  
            }
            return true;
        }

        public string MoveNext()
        {
            string word = "";

            do
            {
                _currentPosition += _nextStep;
            }
            while (!_charList.Contains(_fileContents[_currentPosition]) && HasNext() == true);

            while (_charList.Contains(_fileContents[_currentPosition]))
            {
                word += _fileContents[_currentPosition];
                if (HasNext() == true)
                {
                    _currentPosition += _nextStep;
                }
                else
                {
                    return word;
                }
            }

        return word;
        }
        public void Reset()
        {
            this._currentPosition = -1;
        }

    }
}

