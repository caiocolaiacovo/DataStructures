using System;

namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T> where T : class
    {
        public SinglyLinkedListNode<T> Head { get; private set; }

        public void Add(T value)
        {
            ValidateValue(value);

            var newNode = new SinglyLinkedListNode<T>(value, null);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            AddNext(Head, newNode);
        }

        public void AddFirst(T value)
        {
            ValidateValue(value);

            var newHead = new SinglyLinkedListNode<T>(value, Head);

            Head = newHead;
        }

        public void AddBefore(T value, T newValue)
        {
            ValidateValue(value);
            ValidateValue(newValue);
            ValidateIfListContainsElements();

            var newNode = new SinglyLinkedListNode<T>(newValue, null);

            if (Head.Value == value)
            {
                newNode.Next = Head;
                Head = newNode;
            }

            var nodeFound = FindNodeWithNextValue(value, Head);
            newNode.Next = nodeFound.Next;
            nodeFound.Next = newNode;
        }

        public void AddAfter(T value, T newValue)
        {
            ValidateValue(value);
            ValidateValue(newValue);
            ValidateIfListContainsElements();

            var nodeFound = FindNodeWithValue(value, Head);
            var newNode = new SinglyLinkedListNode<T>(newValue, nodeFound.Next);
            nodeFound.Next = newNode;
        }

        public void Remove(T value)
        {
            if (Head.Value == value)
            {
                Head = Head.Next;
                return;
            }

            var nodeFound = FindNodeWithNextValue(value, Head);
            nodeFound.Next = nodeFound.Next.Next;
        }

        private void AddNext(SinglyLinkedListNode<T> currentNode, SinglyLinkedListNode<T> next)
        {
            if (currentNode.Next == null)
            {
                currentNode.Next = next;
                return;
            }

            AddNext(currentNode.Next, next);
        }

        private SinglyLinkedListNode<T> FindNodeWithNextValue(T value, SinglyLinkedListNode<T> node)
        {
            if (node == null)
                throw new Exception("Value does not exist in list");

            if (node.Next != null && node.Next.Value == value)
                return node;

            return FindNodeWithNextValue(value, node.Next);
        }

        private SinglyLinkedListNode<T> FindNodeWithValue(T value, SinglyLinkedListNode<T> node)
        {
            if (node == null)
                throw new Exception("Value does not exist in list");

            if (node.Value == value)
                return node;

            return FindNodeWithValue(value, node.Next);
        }

        private void ValidateValue(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
        }

        private void ValidateIfListContainsElements()
        {
            if (Head == null)
                throw new Exception("List is empty");
        }
    }
}
