using DataStructureAndAlgorithms.Queue;
using DataStructureAndAlgorithms.Stack;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Challenges
{
    class QueueUsingStack<T>
    {
        public int Length { get; private set; }
        public T First { get; private set; }
        public T Last { get; private set; }

        private MyStack<T> _s1 { get;set; }
        private MyStack<T> _s2 { get;set; }
        public QueueUsingStack()
        {
            Length = 0;
            _s1 = new MyStack<T>();
            _s2 = new MyStack<T>();
        }
        public void Enqueue(T Data)
        {
            if (Length == 0)
            {
                _s1.Push(Data);
                First = Data;
                Last = Data;
            }
            else
            {
                while (!_s1.IsEmpty())
                    _s2.Push(_s1.Pop());
                _s1.Push(Data);
                while (!_s2.IsEmpty())
                    _s1.Push(_s2.Pop());
                Last = Data;
            }
            Length++;
            
        }
        public T Dequeue()
        {
            T result;
            if (!_s1.IsEmpty())
            {
                result = _s1.Pop();
                if (_s1.IsEmpty())
                {
                    First = default;
                    Last = default;
                }
                else
                    First = _s1.Peek();
                Length-=1;
                return result;
            }
            throw new Exception("Queue Empty");

        }
        public T Peek()
        {
            return _s1.Peek();
        }
        public bool IsEmpty()
        {
            return _s1.IsEmpty();
        }
    }
}
