using System;

namespace csharp_text_analyser_kettu0
{

    public class CharIterator : Iterator
    {
        private FileContent _fileContents;
        private Int32 _currentPosition = 0;
        private Int32 _nextStep = 1;

        public CharIterator(FileContent fileContents)
        {
            this._fileContents = fileContents;
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
            while (HasNext() == false);
            return _fileContents[_currentPosition];
        }

        public void Reset()
        {
         this._currentPosition = 0;   
        }
    }
}

