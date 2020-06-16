using System;

namespace csharp_text_analyser_kettu0
{

    public interface Iterator
    {
        bool HasNext();
        string MoveNext();
        void Reset();
    }

}

