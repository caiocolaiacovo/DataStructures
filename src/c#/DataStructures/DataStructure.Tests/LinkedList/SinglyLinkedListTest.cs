using DataStructures.LinkedList;
using ExpectedObjects;
using System;
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

        [Fact]
        public void Should_not_add_when_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            string invalidValue = null;

            void Action() => _list.Add(invalidValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_add_to_head_when_list_is_empty()
        {
            const string value = "Node value";
            var newHead = new SinglyLinkedListNode<string>(value, null);
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
            var expectedNode = new SinglyLinkedListNode<string>(newValue, null);

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
            var expectedNode = new SinglyLinkedListNode<string>(newValue, null);

            _list.Add(newValue);

            var lastNode = _list.Head.Next.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(lastNode);
        }

        [Fact]
        public void Should_not_add_first_when_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            string invalidValue = null;

            void Action() => _list.AddFirst(invalidValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_replace_head_when_add_value_to_first_position()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string newFirstValue = "New first value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            var expectedHead = new SinglyLinkedListNode<string>(newFirstValue, _list.Head);

            _list.AddFirst(newFirstValue);

            var newHead = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(newHead);
        }

        [Fact]
        public void Should_add_first_to_head_when_list_is_empty()
        {
            const string value = "First value";
            var expectedHead = new SinglyLinkedListNode<string>(value, null);

            _list.AddFirst(value);

            var head = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_not_add_before_when_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            const string newValue = "Some new value";
            string invalidValue = null;

            void Action() => _list.AddBefore(invalidValue, newValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_not_add_before_when_new_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            const string value = "Some value";
            string newValue = null;

            void Action() => _list.AddBefore(value, newValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_replace_head_when_add_before_first_value()
        {
            const string firstValue = "First value";
            const string newValue = "New value";
            _list.Add(firstValue);
            var expectedHead = new SinglyLinkedListNode<string>(newValue, _list.Head);

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
            var expectedNode = new SinglyLinkedListNode<string>(newValue, _list.Head.Next.Next);

            _list.AddBefore(thirdValue, newValue);

            var node = _list.Head.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(node);
        }

        [Fact]
        public void Should_not_add_before_when_list_is_empty()
        {
            const string expectedErrorMessage = "List is empty";
            const string nonexistentValue = "A nonexistent value";
            const string newValue = "New value";

            void Action() => _list.AddBefore(nonexistentValue, newValue);

            var errorMessage = Assert.Throws<Exception>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_not_add_before_when_value_does_not_exist()
        {
            const string expectedErrorMessage = "Value does not exist in list";
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string fourthValue = "Fourth value";
            const string newValue = "Third value";
            _list.Add(firstValue);
            _list.Add(secondValue);

            void Action() => _list.AddBefore(fourthValue, newValue);

            var errorMessage = Assert.Throws<Exception>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_not_add_after_when_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            const string newValue = "Some new value";
            string invalidValue = null;

            void Action() => _list.AddAfter(invalidValue, newValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_not_add_after_when_new_value_is_null()
        {
            const string expectedErrorMessage = "Value cannot be null.";
            const string value = "Some value";
            string newValue = null;

            void Action() => _list.AddAfter(value, newValue);

            var errorMessage = Assert.Throws<ArgumentNullException>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_add_after_head()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string newValue = "New value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            var expectedNode = new SinglyLinkedListNode<string>(newValue, _list.Head.Next);

            _list.AddAfter(firstValue, newValue);

            var node = _list.Head.Next;
            expectedNode.ToExpectedObject().ShouldMatch(node);
        }

        [Fact]
        public void Should_add_after_some_value_in_the_middle_of_the_list()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string fourthValue = "Fourth value";
            const string newValue = "New value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            _list.Add(fourthValue);
            var expectedNode = new SinglyLinkedListNode<string>(newValue, _list.Head.Next.Next);

            _list.AddAfter(secondValue, newValue);

            var node = _list.Head.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(node);
        }

        [Fact]
        public void Should_add_after_the_last_value()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string thirdValue = "Third value";
            const string newValue = "New value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            _list.Add(thirdValue);
            var expectedNode = new SinglyLinkedListNode<string>(newValue, null);

            _list.AddAfter(thirdValue, newValue);

            var node = _list.Head.Next.Next.Next;
            expectedNode.ToExpectedObject().ShouldMatch(node);
        }

        [Fact]
        public void Should_not_add_after_when_list_is_empty()
        {
            const string expectedErrorMessage = "List is empty";
            const string nonexistentValue = "A nonexistent value";
            const string newValue = "New value";

            void Action() => _list.AddAfter(nonexistentValue, newValue);

            var errorMessage = Assert.Throws<Exception>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_not_add_after_when_value_does_not_exist()
        {
            const string expectedErrorMessage = "Value does not exist in list";
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string fourthValue = "Fourth value";
            const string newValue = "Third value";
            _list.Add(firstValue);
            _list.Add(secondValue);

            void Action() => _list.AddAfter(fourthValue, newValue);

            var errorMessage = Assert.Throws<Exception>(Action).Message;
            Assert.Equal(expectedErrorMessage, errorMessage);
        }

        [Fact]
        public void Should_remove_value_from_head()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            var expectedHead = new SinglyLinkedListNode<string>(secondValue, null);

            _list.Remove(firstValue);

            var head = _list.Head;
            expectedHead.ToExpectedObject().ShouldMatch(head);
        }

        [Fact]
        public void Should_remove_value_in_the_middle_of_the_list()
        {
            const string firstValue = "First value";
            const string secondValue = "Second value";
            const string thirdValue = "Third value";
            const string fourthValue = "Fourth value";
            _list.Add(firstValue);
            _list.Add(secondValue);
            _list.Add(thirdValue);
            _list.Add(fourthValue);
            var expectedThirdNode = new SinglyLinkedListNode<string>(fourthValue, null);
            var expectedSecondNode = new SinglyLinkedListNode<string>(secondValue, expectedThirdNode);

            _list.Remove(thirdValue);

            var secondNode = _list.Head.Next;
            var thirdNode = _list.Head.Next.Next;
            expectedSecondNode.ToExpectedObject().ShouldMatch(secondNode);
            expectedThirdNode.ToExpectedObject().ShouldMatch(thirdNode);
        }
    }
}
