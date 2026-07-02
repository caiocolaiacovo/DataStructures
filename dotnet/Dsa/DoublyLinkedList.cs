namespace Dsa.DoublyLinkedList;

public class DLLNode<T>
{
    public T Value;
    public DLLNode<T>? Previous;
    public DLLNode<T>? Next;

    public DLLNode(T value)
    {
        Value = value;
    }
}

public class CustomDoublyLinkedList<T>
{
    private DLLNode<T>? _head;
    private DLLNode<T>? _tail;
    private int _count;
    public int Count => _count;

    public DLLNode<T>? First()
    {
        return _head;
    }

    public DLLNode<T>? Last()
    {
        return _tail;
    }

    public void AddFirst(DLLNode<T>? node)
    {
        if (node == null)
        {
            return;
        }

        _count++;

        if (_head == null && _tail == null) //empty list
        {
            _head = node;
            _tail = node;
            return;
        }

        var oldHead = _head!;
        oldHead.Previous = node;
        node.Next = oldHead;
        _head = node;
    }

    public void AddLast(DLLNode<T>? node)
    {
        if (node == null)
        {
            return;
        }

        _count++;

        if (_head == null && _tail == null) //empty list
        {
            _head = node;
            _tail = node;
            return;
        }

        var oldTail = _tail!;
        oldTail.Next = node;
        node.Previous = oldTail;
        _tail = node;
    }

    public void Remove(DLLNode<T>? node)
    {
        if (node == null)
        {
            return;
        }

        //only 1 element
        if (_head == node && _tail == node)
        {
            _head = null;
            _tail = null;
            _count--;
            return;
        }

        if (_head == node)
        {
            var newHead = _head.Next;
            node.Previous = null;
            node.Next = null;
            _head = newHead;
            _count--;
            return;
        }

        if (_tail == node)
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
        if (_tail == null)
        {
            return;
        }

        if (_count == 1)
        {
            _head = null;
            _tail = null;
            _count--;
            return;
        }

        var newTail = _tail.Previous;
        newTail.Next = null;
        _tail = newTail;
        _count--;
    }
}