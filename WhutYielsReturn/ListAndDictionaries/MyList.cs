using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionaries
{
    public class MyList<T> : IEnumerable<T>
    {
        #region
        private T[] array;
        private int count = 0;

        public int Count { get { return count; } }

        public MyList()
        {
            array = new T[100];
        }

        private void Enlarge()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                Enlarge();
            }
            array[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                array[index] = value;
            }
        }
        #endregion

        public bool Contains(T element)
        {
            foreach (var e in this)
            {
                if (e.Equals(element)) return true;
            }
            return false;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) return false;
            Point p = obj as Point;
            return X == p.X && Y == p.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 1039 + Y.GetHashCode();
        }

        public static bool operator == (Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator != (Point p1, Point p2) => !(p1 == p2);

        public override string ToString()
        {
            return string.Format(" X = {0} Y = {1}", X, Y);
        }
    }
}
