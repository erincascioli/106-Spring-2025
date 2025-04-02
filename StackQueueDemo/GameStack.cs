using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDemo
{
    internal class GameStack<T> : IStack<T>
    {
        // Fields
        private List<T> data;

        public int Count { get; }

        public bool IsEmpty { get; }

        public GameStack()
        {
            data = new List<T>();
        }

        public T Peek()
        {
            return default(T)!;
        }

        public void Push(T item)
        {

        }

        public T Pop()
        {
            return default(T)!;
        }

    }
}
