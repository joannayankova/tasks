using System;

namespace efdsf
{
    public class MyCustomList<T> : ICustomlist<T>
    {
        private T[] elements = new T[200];
        private int currentIndex;

        public void Add(T add)
        {
            if (currentIndex < elements.Length)
            {
                elements[currentIndex] = add;
                currentIndex++;
            }
            else
            {
                Array.Resize(ref elements, elements.Length * 2);

                elements[currentIndex] = add;
            }
        }

        public bool NumberExist(T search)
        {
            foreach (var Object in elements)
            {
                if (search.Equals(Object)) return true;
            }
            return false;
        }

        public void Clean()
        {
            elements = new T[0];
        }

        public void Sort(Func<T, T, bool> predicate )
        {
            T temp;

            for (int write = 0; write < currentIndex; write++)
            {
                for (int sort = 0; sort < currentIndex - 1; sort++)
                {
                    if (predicate.Invoke(elements[sort], elements[sort + 1]))
                    {
                        temp = elements[sort + 1];
                        elements[sort + 1] = elements[sort];
                        elements[sort] = temp;

                    }
                }
            }

            var gg = 1;
        }


        public void AddRange(T[] elementsay)
        {
            for (int j = 0; j < elementsay.Length; j++)
            {
                Add(elementsay[j]);
            }
        }


    }
}



