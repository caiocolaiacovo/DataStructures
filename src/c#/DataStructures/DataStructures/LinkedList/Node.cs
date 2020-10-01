﻿namespace DataStructures.LinkedList
{
    public class Node<T> where T : class
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
