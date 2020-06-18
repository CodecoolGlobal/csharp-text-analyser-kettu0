using System;
using System.IO;

namespace csharp_text_analyser_kettu0
{
    public class FileContent : IterableText
    
    {
        private string _textFile;
        private string _textTitle;
        public string this[Int32 index]
        {  
            get { return _textFile.ToUpper()[index].ToString(); }
        }  

        public FileContent(string textFile)
        {
            this._textFile = (File.ReadAllText(textFile)).ToUpper();
            
        }

        public FileContent(string textFile, string textTitle)
            : this(textFile)
        {
            this._textTitle = textTitle;
        }

        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }

        public Iterator WordIterator()
        {
            return new WordIterator(this);
        }

        public string GetFilename()
        {
            return Path.GetFileName(_textTitle);
        }

        public Int32 GetFileContentLength()
        {
            return _textFile.Length;
        }

    }

}
