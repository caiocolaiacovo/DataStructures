using DataStructures.LinkedList;
using ExpectedObjects;
using Xunit;

namespace DataStructure.Tests.LinkedList
{
    public class SinglyLinkedListTest
    {
        private readonly SinglyLinkedList<string> _list;

        public SinglyLinkedListTest()
        {
            _list = new SinglyLinkedList<string>();
        }

        [Fact]
        public void Should_create_a_list_without_head()
        {
            var list = new SinglyLinkedList<object>();

            Assert.Null(list.Head);
        }

        //TODO: Should not add invalid values

        [Fact]
        public void Should_add_to_head_when_list_is_empty()
        {
            const string value = "Node value";
            var newHead = new Node<string>(value, null);
            var expectedHead = newHead;

            _list.Add(value);

            var head = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_add_to_heads_next_when_list_contains_only_head()
        {
            const string firstValue = "First value";
            const string newValue = "New value";
            _list.Add(firstValue);
            var expectedNode = new Node<string>(newValue, null);

            _list.Add(newValue);

            var headsNextNode = _list.Head.Next;
            expectedNode.ToExpectedObject().ShouldMatch(headsNextNode);
        }

        [Fact]
        public void Should_add_to_the_end_when_list_is_not_empty()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string thirdValue = "Thirdvalue";
            const string newValue = "New value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            _list.Add(thirdValue);
            var expectedNode = new Node<string>(newValue, null);

            _list.Add(newValue);

            var lastNode = _list.Head.Next.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(lastNode);
        }

        [Fact]
        public void Should_replace_head_when_add_value_to_first_position()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string newFirstValue = "New first value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            var expectedHead = new Node<string>(newFirstValue, _list.Head);

            _list.AddFirst(newFirstValue);

            var newHead = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(newHead);
        }

        [Fact]
        public void Should_add_first_to_head_when_list_is_empty()
        {
            const string value = "First value";
            var expectedHead = new Node<string>(value, null);

            _list.AddFirst(value);

            var head = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_replace_head_when_add_before_first_value()
        {
            const string firstValue = "First value";
            const string newValue = "New value";
            _list.Add(firstValue);
            var expectedHead = new Node<string>(newValue, _list.Head);

            _list.AddBefore(firstValue, newValue);

            var head = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_add_before_specific_value()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string thirdValue = "Third value";
            const string newValue = "New value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            _list.Add(thirdValue);
            var expectedNode = new Node<string>(newValue, _list.Head.Next.Next);

            _list.AddBefore(thirdValue, newValue);

            var node = _list.Head.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(node);
        }

        //TODO: Shuld not add before when list is empty
        //TODO: Shoud not add before when value does not exist
    }
}
