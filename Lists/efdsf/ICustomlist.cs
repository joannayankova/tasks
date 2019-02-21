using System;
using System.Collections.Generic;
using System.Text;

namespace efdsf
{
   public interface ICustomlist<T>
    {
        void Add(T add);
        bool NumberExist(T search);
        void Clean();
        void AddRange(T[] array);
    }
}
