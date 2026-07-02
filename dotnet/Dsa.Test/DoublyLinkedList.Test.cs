using Dsa.DoublyLinkedList;

namespace Dsa.Test;

public class CustomDoublyLinkedListest
{
    [Fact]
    public void Should_add_node_to_first_when_empty_list()
    {
        var node = new DLLNode<int>(99);
        var dll = new CustomDoublyLinkedList<int>();
        
        dll.AddFirst(node);

        var first = dll.First();
        var last = dll.Last();
        Assert.Equal(node, first);
        Assert.Equal(node, last);
    }

    [Fact]
    public void Should_handle_null_node_when_adding_first()
    {
        var dll = new CustomDoublyLinkedList<int>();

        dll.AddFirst(null);

        var first = dll.First();
        Assert.Null(first);
    }

    [Fact]
    public void Should_add_node_to_first_when_list_has_more_than_one_element()
    {
        var node1 = new DLLNode<int>(99);
        var node2 = new DLLNode<int>(10);
        var node3 = new DLLNode<int>(55);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddFirst(node1);
        dll.AddFirst(node2);
        var expectedCount = 3;

        dll.AddFirst(node3);
        
        var first = dll.First();
        var last = dll.Last();
        Assert.Equal(node3, first);
        Assert.Equal(node1, last);
        Assert.Equal(expectedCount, dll.Count);
    }

    [Fact]
    public void Should_add_node_to_last_when_empty_list()
    {
        var node = new DLLNode<int>(99);
        var dll = new CustomDoublyLinkedList<int>();

        dll.AddLast(node);
        
        var last = dll.Last();
        var first = dll.First();
        Assert.Equal(node, last);
        Assert.Equal(node, first);
    }

    [Fact]
    public void Should_handle_null_node_when_adding_last()
    {
        var dll = new CustomDoublyLinkedList<int>();

        dll.AddLast(null);

        var first = dll.Last();
        Assert.Null(first);
    }

    [Fact]
    public void Should_add_node_to_last_when_list_has_more_than_one_element()
    {
        var node1 = new DLLNode<int>(99);
        var node2 = new DLLNode<int>(10);
        var node3 = new DLLNode<int>(55);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddLast(node1);
        dll.AddLast(node2);
        var expectedCount = 3;

        dll.AddLast(node3);

        var last = dll.Last();
        var first = dll.First();
        Assert.Equal(node3, last);
        Assert.Equal(node1, first);
        Assert.Equal(expectedCount, dll.Count);
    }

    [Fact]
    public void Should_remove_node_when_list_has_only_one_element()
    {
        var node = new DLLNode<int>(99);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddFirst(node);

        dll.Remove(node);

        var first = dll.First();
        var last = dll.Last();
        Assert.Null(first);
        Assert.Null(last);
    }

    [Fact]
    public void Should_remove_the_first_node()
    {
        var node1 = new DLLNode<int>(99);
        var node2 = new DLLNode<int>(10);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddFirst(node1);
        dll.AddFirst(node2);

        dll.Remove(node2);

        var first = dll.First();
        var last = dll.Last();
        Assert.Equal(node1, first);
        Assert.Equal(node1, last);
    }

    [Fact]
    public void Should_remove_the_last_node()
    {
        var node1 = new DLLNode<int>(99);
        var node2 = new DLLNode<int>(15);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddFirst(node1);
        dll.AddFirst(node2);

        dll.Remove(node1);

        var first = dll.First();
        var last = dll.Last();
        Assert.Equal(node2, first);
        Assert.Equal(node2, last);
    }

    [Fact]
    public void Should_remove_middle_node()
    {
        var node1 = new DLLNode<int>(99);
        var node2 = new DLLNode<int>(15);
        var node3 = new DLLNode<int>(10);
        var dll = new CustomDoublyLinkedList<int>();
        dll.AddFirst(node1);
        dll.AddFirst(node2);
        dll.AddFirst(node3);
        var expectedCount = 2;

        dll.Remove(node2);

        var first = dll.First();
        var last = dll.Last();
        Assert.Equal(node3, first);
        Assert.Equal(node1, last);
        Assert.Equal(expectedCount, dll.Count);
    }

    [Fact]
    public void Should_handle_null_node_when_removing()
    {
        var dll = new CustomDoublyLinkedList<int>();

        dll.Remove(null);

        var first = dll.Last();
        Assert.Null(first);
    }

    [Fact]
    public void Should_remove_last()
    {
        //TODO: dll.RemoveLast()
    }
}