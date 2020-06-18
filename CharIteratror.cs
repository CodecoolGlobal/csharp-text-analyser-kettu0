using System;
using System.Collections.Generic;

namespace csharp_text_analyser_kettu0
{

    public class CharIterator : Iterator
    {
        private FileContent _fileContents;
        private Int32 _currentPosition;
        private Int32 _nextStep;
        private List<string> _charList= new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        public CharIterator(FileContent fileContent)
        {
            this._currentPosition = -1;
            this._nextStep = 1;
            this._fileContents = fileContent;
        }

        public bool HasNext()
        {
            if (_currentPosition == _fileContents.GetFileContentLength()-1)
            {
                return false;
            }
            return true;
        }

        public string MoveNext()
        {
            do 
            {
                _currentPosition += _nextStep;


            }
            while (HasNext() == true && !_charList.Contains(_fileContents[_currentPosition]));
            return _fileContents[_currentPosition];
        }

        public void Reset()
        {
         this._currentPosition = -1;   
        }


    }
}

