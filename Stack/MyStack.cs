using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Stack
{
    /// <summary>
    /// Implementation for Stack
    /// </summary>
    /// <typeparam name="T"> Generic Type</typeparam>
    public class StackNode<T>
    {
        public StackNode<T> Next { get; set; }
        public T Data { get; set; }
        public StackNode(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public class MyStack<T>
    {
        public StackNode<T> Top { get; private set; }
        public StackNode<T> Bottom { get; private set; }
        public int Length { get; private set; }
        public MyStack()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        public T Peek()
        {
            if (Length == 0)
                throw new Exception("Stack Empty");
            return Top.Data;
        }
        public void Push(T data)
        {
            if(Length == 0)
            {
                Top = new StackNode<T>(data);
                Bottom = Top;
            }
            else
            {
                Top = new StackNode<T>(data) { Next = Top };
            }
            Length++;
        }
        public T Pop()
        {
            if (Length == 0)
                throw new Exception("Stack Empty");
            var item = Top.Data;
            Top = Top.Next;
            Length--;
            return item;
        }
    }
}
