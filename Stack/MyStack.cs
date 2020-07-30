using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Stack
{
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
        StackNode<T> top;
        StackNode<T> bottom;
        int Length;
        public MyStack()
        {
            top = null;
            bottom = null;
            Length = 0;
        }

        public void Peek()
        {

        }
        public void Push(T data)
        {
            if(Length == 0)
            {
                top = new StackNode<T>(data);
                bottom = top;
            }
            else
            {
                top.Next = new StackNode<T>(data);
                top = top.Next;
            }
            Length++;
        }
        public void Pop()
        {

        }
    }
}
