using System;

namespace csharp_text_analyser_kettu0
{

    public class WordIterator : Iterator
    {
        private Int32 _currentPosition;
        private Int32 _nextStep;
        private FileContent _fileContents;
        
        public WordIterator(FileContent fileContent)
        {
            this._currentPosition = 0;
            this._nextStep = 1;
            this._fileContents = fileContent;
            
        }
        public bool HasNext()
        {
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

