using System;

namespace csharp_text_analyser_kettu0
{
    public interface IterableText
    {
        Iterator CharIterator();
        Iterator WordIterator();
    }

}