using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{

    //public class QueueEnumerator<T> : IEnumerator<T>
    //{
    //    Queue<T> queue;
    //    QueueItem<T> item;
        
    //    public QueueEnumerator(Queue<T> queue)
    //    {
    //        this.queue = queue;
    //        item = null;
    //    }

    //    public T Current => item.Value;

    //    public bool MoveNext()
    //    {
    //        if (item == null) { item = queue.Head; }
    //        else { item = item.Next; }
    //        return item != null;
    //    }

    //    #region
    //    public void Dispose()
    //    {
            
    //    }

    //    object IEnumerator.Current => Current;

    //    public void Reset()
    //    {
            
    //    }
    //    #endregion
    //}

    public class Queue<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            QueueItem<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public QueueItem<T> Head { get; private set; }
        QueueItem<T> tail;

        public bool IsEmpty { get { return Head == null; } }

        #region
        /// <summary>
        /// Алгоритм очереди 
        /// </summary>
        /// <param name="value">Что хранится в очереди</param>
        public void Enqueue(T value)
        {
            if (IsEmpty)
            {
                tail = Head = new QueueItem<T> { Value = value, Next = null };
            }
            else
            {
                QueueItem<T> item = new QueueItem<T> { Value = value, Next = null };
                tail.Next = item;
                tail = item;
            }
        }

        public T Dequeue()
        {
            if (Head == null) throw new InvalidOperationException();
            var result = Head.Value;
            Head = Head.Next;
            if (Head == null) { tail = null; }
            return result;
        }

        #endregion
    } 

    public class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> Next {get; set;  }
    }
}
