using ExpectedObjects;
using Xunit;

namespace DataStructure.Tests.LinkedList
{
    public class SinglyLinkedListTest
    {
        [Fact]
        public void Should_create_a_list_without_head()
        {
            var list = new SinglyLinkedList<object>();

            Assert.Null(list.Head);
        }

        [Fact]
        public void Should_add_node_to_head_when_list_is_empty()
        {
            var list = new SinglyLinkedList<string>();
            const string data = "Node data";
            var node = new Node<string>
            {
                Data = data,
                Next = null
            };
            var expectedHead = node;

            list.Add(data);

            var head = list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_add_node_to_the_end_when_list_is_not_empty()
        {
            var list = new SinglyLinkedList<string>();
            const string headData = "Head data";
            const string nodeData = "Node1 data";
            const string newNodeData = "NewNode data";
            list.Add(headData);
            list.Add(nodeData);
            var expectedNode = new Node<string>
            {
                Data = newNodeData,
                Next = null
            };

            list.Add(newNodeData);

            var lastNode = list.Head.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(lastNode);
        }

        [Fact]
        public void Should_replace_head_when_add_element_to_first_position()
        {

        }

        private class SinglyLinkedList<T> where T : class
        {
            public Node<T> Head { get; private set; }

            internal void Add(T data)
            {
                var newNode = new Node<T> { Data = data };

                if (Head == null)
                {
                    Head = newNode;
                    return;
                }

                AddNext(Head, newNode);
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
        }

        private class Node<T> where T : class
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }
    }
}
