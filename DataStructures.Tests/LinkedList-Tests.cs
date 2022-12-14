namespace DataStructures.Tests
{
    public class LinkedList_Tests
    {
        static readonly object[] RemoveKthNodeFromEndTestData =
        {
            new object[] { 1, 2, 3, 2, new int[] { 1, 3 } },
            new object[] { 4, 5, 6, 1, new int[] { 4, 5 } }
        };

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void AddLast_AddNewItemIntoTail_AddsNewItemToTailOfLinkedList(int value, int expectedValue)
        {
            var solution = new LinkedList();
            solution.AddLast(value);

            var tailValue = solution.GetTail().Value;
            Assert.That(tailValue, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void AddFirst_AddNewItemIntoHead_AddsNewItemToTheHeadOfLinkedList(int value, int expectedValue)
        {
            var solution = new LinkedList();
            solution.AddFirst(value);

            var headValue = solution.GetHead().Value;
            Assert.That(headValue, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(1, 2, 3, 3, 2)]
        [TestCase(4, 5, 6, 5, 1)]
        [TestCase(1, 2, 3, 1, 0)]
        [TestCase(1, 2, 3, 4, -1)]
        public void IndexOf_IndexOfAnItemInNode_ReturnsIndexOfItemInNode(int value, int value1, int value2, int indexOf, int expectedValue)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            var index = solution.IndexOf(indexOf);
            Assert.That(index, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(1, 2, 3, 3, true)]
        [TestCase(4, 5, 6, 5, true)]
        [TestCase(1, 2, 3, 4, false)]
        public void Contains_HasExpectedResult_IndexOfItemInNode(int value, int value1, int value2, int valueToContain, bool expectedResult)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            var contains = solution.Contains(valueToContain);
            Assert.That(contains, Is.EqualTo(expectedResult));
        }

        [Test]
        public void RemoveFirst_HeadIsEmpty_ThrowsArgumentNullException()
        {
            var solution = new LinkedList();
            Assert.Throws<ArgumentNullException>(() => solution.RemoveFirst());
        }

        [Test]
        [TestCase(1, 2, 3, 1)]
        [TestCase(4, 5, 6, 4)]
        public void RemoveFirst_RemoveFirstElement_RemovesFirstElement(int value, int value1, int value2, int valueNotToContain)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);
            solution.RemoveFirst();

            var contains = solution.Contains(valueNotToContain);
            Assert.That(contains, Is.False);
        }

        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(4, 5, 6, 6)]
        public void RemoveLast_RemoveLastElement_RemovesLastElement(int value, int value1, int value2, int valueNotToContain)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);
            solution.RemoveLast();

            var contains = solution.Contains(valueNotToContain);
            Assert.That(contains, Is.False);
        }

        [Test]
        [TestCase(1, 2, 3, 2)]
        [TestCase(4, 5, 6, 2)]
        public void GetSize_RemoveLastElement_SizeShouldDecrease(int value, int value1, int value2, int sizeAfterRemove)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);
            solution.RemoveLast();

            var size = solution.GetSize();
            Assert.That(size, Is.EqualTo(sizeAfterRemove));
        }

        [Test]
        [TestCase(1, 2, 3, 3)]
        [TestCase(4, 5, 6, 3)]
        public void GetSize_AddElement_IncreaseSize(int value, int value1, int value2, int expectedSize)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            var size = solution.GetSize();
            Assert.That(size, Is.EqualTo(expectedSize));
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(4, 5, 6)]
        public void ToArray_ConvertLinkedListToArray_ArrayOfIntegers(int value, int value1, int value2)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            var array = solution.ToArray();
            CollectionAssert.IsNotEmpty(array);
        }

        static readonly object[] ReverseLinkedListTestData =
        {
            new object[] { 1, 2, 3, new int[] { 3,2,1 } },
            new object[] { 4, 5, 6, new int[] { 6, 5, 4 } }
        };

        [Test]
        [TestCaseSource(nameof(ReverseLinkedListTestData))]
        public void ReverseLinkedList_ReverseLinkedList_LinkedListIsReversed(int value, int value1, int value2, int[] expectedArray)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            solution.ReverseLinkedList();
            var array = solution.ToArray();
            CollectionAssert.AreEquivalent(array, expectedArray);
        }

        [Test]
        [TestCaseSource(nameof(RemoveKthNodeFromEndTestData))]
        public void RemoveKthNodeFromEnd_RemoveKthElementFromEnd_RemovesKthElement(int value, int value1, int value2, int k, int[] expectedArray)
        {
            var solution = new LinkedList();
            solution.AddLast(value);
            solution.AddLast(value1);
            solution.AddLast(value2);

            solution.RemoveKthNodeFromEnd(k);
            var array = solution.ToArray();
            CollectionAssert.AreEquivalent(array, expectedArray);
        }

        [Test]
        public void RemoveKthNodeFromEnd_KIsNegativeNumber_ThrowsArgumentNullException()
        {
            var solution = new LinkedList();
            Assert.Throws<ArgumentNullException>(() => solution.RemoveKthNodeFromEnd(-1));
        }
    }
}