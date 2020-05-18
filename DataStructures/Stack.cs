﻿using System;
namespace DataStructures.Stack
{
    public class Stack<T>
    {
        private Node top;

        public void Push(T value)
        {
            Node newValue = new Node(value);
            newValue.Next = top;
            top = newValue;
        }

        public T Pop()
        {
            return default;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new ArgumentException();
            }

            return default;
        }

        public bool IsEmpty()
        {
            if (top == null)
            {
                return true;
            }

            return false;
        }

        public class Node
        {
            public Node Next { get; set; }
            public T Value { get; set; }
            public Node(T value)
            {
                Value = value;
            }
        }

    }


}