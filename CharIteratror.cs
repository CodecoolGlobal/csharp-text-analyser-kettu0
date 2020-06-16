using System;
using System.Collections.Generic;

namespace csharp_text_analyser_kettu0
{

    public class CharIterator : Iterator
    {
        private FileContent _fileContents;
        private Int32 _currentPosition;
        private Int32 _nextStep;
        private List<string> _charList;
        public CharIterator(FileContent fileContent)
        {
            this._currentPosition = 0;
            this._nextStep = 1;
            this._fileContents = fileContent;
            this._charList = new List<string>{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","R","S","T","U","W","X","Y","Z"};
        }

        public bool HasNext()
        {
            _currentPosition += _nextStep;

            if (_currentPosition - 1 == _fileContents.GetFileContentLength())
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
            while (HasNext() == false && !_charList.Contains(_fileContents[_currentPosition]));
            return _fileContents[_currentPosition];
        }

        public void Reset()
        {
         this._currentPosition = 0;   
        }
    }
}

