namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T> where T : class
    {
        public Node<T> Head { get; private set; }

        public void Add(T data)
        {
            var newNode = new Node<T>(data, null);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            AddNext(Head, newNode);
        }

        public void AddFirst(T data)
        {
            var newHead = new Node<T>(data, Head);

            Head = newHead;
        }

        public void AddBefore(T data, T newData)
        {
            var newNode = new Node<T>(newData, null);

            if (Head.Value == data)
            {
                newNode.Next = Head;
                Head = newNode;

                return;
            }

            var nodeFound = FindNodeWithNextData(data, Head);
            newNode.Next = nodeFound.Next;
            nodeFound.Next = newNode;
        }

        private void AddNext(Node<T> currentNode, Node<T> next)
        {
            if (currentNode.Next == null)
            {
                currentNode.Next = next;
                return;
            }

            AddNext(currentNode.Next, next);
        }

        private Node<T> FindNodeWithNextData(T data, Node<T> node)
        {
            if (node.Next.Value == data)
                return node;

            return FindNodeWithNextData(data, node.Next);
        }
    }
}
