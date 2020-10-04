namespace DataStructures.LinkedList
{
    public class SinglyLinkedListNode<T> where T : class
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T value, SinglyLinkedListNode<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
