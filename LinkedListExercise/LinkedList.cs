namespace LinkedListExercise
{
    public class LinkedList
    {
        private Node Head;
        private Node Tail;
        private int Size;

        public class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        //O(1)
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty(Head))
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

            Size++;
        }

        //O(1)
        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty(Head))
            {
                Head = Tail = node;
            }
            else
            {
                Head.Next = node;
                Head = node;
            }

            Size++;
        }

        //O(n)
        public int IndexOf(int item)
        {
            int index = 0;
            var current = Head;

            while (!IsEmpty(current))
            {
                if (current.Value == item)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        public void RemoveFirst()
        {
            if (IsEmpty(Head))
            {
                throw new ArgumentNullException(nameof(Head));
            }

            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }

            var nextNode = Head.Next;
            Head.Next = null;
            Head = nextNode;

            Size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty(Head))
            {
                throw new ArgumentNullException(nameof(Head));
            }

            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                var previous = GetPrevious(Tail);
                Tail = previous;
                Tail.Next = null;
            }

            Size--;
        }

        //O(n)
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        //O(1)
        public int GetSize()
        {
            return Size;
        }

        public int[] ToArray()
        {
            int[] array = new int[Size];

            var current = Head;
            var index = 0;
            while (!IsEmpty(current))
            {
                array[index++] = current.Value;
                current = current.Next;
            }

            return array;
        }

        public Node GetHead()
        {
            return Head;
        }

        public Node GetTail()
        {
            return Tail;
        }

        private bool IsEmpty(Node node)
        {
            return node == null;
        }

        private Node GetPrevious(Node node)
        {
            var current = Head;
            while (current is not null)
            {
                if (current.Next == node)
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }
    }
}