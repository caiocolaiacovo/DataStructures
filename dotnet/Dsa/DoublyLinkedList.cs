namespace Dsa.DoublyLinkedList;

public class DLLNode
{
    public int Key;
    public int Value;
    public int Frequency;
    public DLLNode? Previous;
    public DLLNode? Next;

    public DLLNode(int key, int value, int frequency, DLLNode? previous, DLLNode? next)
    {
        Key = key;
        Value = value;
        Frequency = frequency;
        Previous = previous;
        Next = next;
    }
}

public class CustomDoublyLinkedList
{
    public DLLNode? Head;
    public DLLNode? Tail;
    private int _count;
    public int Count => _count;

    public DLLNode? First()
    {
        return Head;
    }

    public DLLNode? Last()
    {
        return Tail;
    }

    public void AddFirst(DLLNode? node)
    {
        if (node == null)
        {
            return;
        }

        _count++;

        if (Head == null && Tail == null) //empty list
        {
            Head = node;
            Tail = node;
            return;
        }

        var oldHead = Head!;
        oldHead.Previous = node;
        node.Next = oldHead;
        Head = node;
    }

    public void AddLast(DLLNode? node)
    {
        if (node == null)
        {
            return;
        }

        _count++;

        if (Head == null && Tail == null) //empty list
        {
            Head = node;
            Tail = node;
            return;
        }

        var oldTail = Tail!;
        oldTail.Next = node;
        node.Previous = oldTail;
        Tail = node;
    }

    public void Remove(DLLNode? node)
    {
        if (node == null)
        {
            return;
        }

        //only 1 element
        if (Head == node && Tail == node)
        {
            Head = null;
            Tail = null;
            _count--;
            return;
        }

        if (Head == node)
        {
            var newHead = Head.Next;
            node.Previous = null;
            node.Next = null;
            Head = newHead;
            _count--;
            return;
        }

        if (Tail == node)
        {
            RemoveLast();
            return;
        }

        //middle element
        var previous = node.Previous!;
        var next = node.Next!;

        node.Previous = null;
        node.Next = null;

        previous.Next = next;
        next.Previous = previous;
        _count--;
    }

    public void RemoveLast()
    {
        if (Tail == null)
        {
            return;
        }

        if (_count == 1)
        {
            Head = null;
            Tail = null;
            _count--;
            return;
        }

        var newTail = Tail.Previous;
        newTail.Next = null;
        Tail = newTail;
        _count--;
    }
}