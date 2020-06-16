using System;
using System.IO;

namespace csharp_text_analyser_kettu0
{
    public class FileContent : IterableText
    
    {
        private string _textFile;
        public string this[Int32 index]
        {  
            get { return _textFile.ToUpper()[index].ToString(); }
        }  

        public FileContent(string textFile)
        {
            this._textFile = (File.ReadAllText(textFile)).ToUpper();
        }

        public Iterator CharIterator()
        {
            return new CharIterator(this);
        }

        public Iterator WordIterator()
        {
            return new WordIterator(this);
        }

        public string GetFilename(string textFile)
        {
            return Path.GetFileName(textFile);
        }

        public Int32 GetFileContentLength()
        {
            return _textFile.Length;
        }


    }

}
