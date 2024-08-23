using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class OverLoads
    {
    
        public bool Exists<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> FindAll<T>(List<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public int FindIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public T FindLast<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return list[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach<T>(List<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        public bool TrueForAll<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
