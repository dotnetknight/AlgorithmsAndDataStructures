namespace LinkedListConstruction
{
    internal class Program
    {
        public Node Head;
        public Node Tail;

        public class Node
        {
            public int Value;
            public Node Prev;
            public Node Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.Tail = program.GenerateList(program);
            var result = program.ToReverseList();
            Console.ReadLine();
        }

        public Node GenerateList(Program program)
        {
            var n1 = new Node(1);
            program.SetHead(n1);

            var n2 = new Node(2);
            program.InsertAfter(n1, n2);

            var n3 = new Node(3);
            program.InsertAfter(n2, n3);

            var n4 = new Node(4);
            program.InsertAfter(n3, n4);

            var n5 = new Node(5);
            program.InsertAfter(n4, n5);

            return program.Head;
        }

        // O(n) Time | O(1) Space
        public List<int> ToList()
        {
            var list = new List<int>();
            var node = Head;

            list.Add(node.Value);
            while (node.Next != null)
            {
                list.Add(node.Next.Value);
                node = node.Next;
            }
            return list;
        }

        // O(n) Time | O(1) Space
        public List<int> ToReverseList()
        {
            //1. If head is not null create three nodes
            //   prevNode - pointing to head,
            //   tempNode - pointing to head,
            //   curNode - pointing to next of head
            if (Head != null)
            {
                Node prevNode = Head;
                Node tempNode = Head;
                Node curNode = Head.Next;

                //2. assign next and previous of the 
                //   prevNode as null to make the first 
                //   node as last node of the reversed list
                prevNode.Next = null;
                prevNode.Prev = null;

                while (curNode != null)
                {
                    //3. While the curNode is not null adjust links 
                    //   (unlink curNode and link it to the reversed list 
                    //   from front and modify curNode and prevNode) 
                    tempNode = curNode.Next;
                    curNode.Next = prevNode;
                    prevNode.Prev = curNode;
                    prevNode = curNode;
                    curNode = tempNode;
                }

                //4. Make prevNode (last node) as head
                Head = prevNode;
            }

            return ToList();
        }

        // O(1) Time | O(1) Space
        public void LinkTwo(Node leftNode, Node rightNode)
        {
            if (leftNode != null)
            {
                leftNode.Next = rightNode;
            }

            if (rightNode != null)
            {
                rightNode.Prev = leftNode;
            }
        }

        // O(1) Time | O(1) Space
        public void SetHead(Node node)
        {
            Remove(node);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                InsertBefore(Head, node);
                Head = node;
                Head.Prev = null;
            }
        }

        // O(1) Time | O(1) Space
        public void SetTail(Node node)
        {
            Remove(node);

            if (Tail == null)
            {
                Tail = node;
                Head = node;
            }
            else
            {
                InsertAfter(Tail, node);

                Tail = node;
                Tail.Next = null;
            }
        }

        // O(1) Time | O(1) Space
        public void InsertBefore(Node node, Node nodeToInsert)
        {
            Remove(nodeToInsert);
            var temp = node.Prev;

            LinkTwo(nodeToInsert, node);
            LinkTwo(temp, nodeToInsert);

            if (nodeToInsert.Prev == null)
            {
                Head = nodeToInsert;
            }
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            Remove(nodeToInsert);
            var temp = node.Next;

            LinkTwo(node, nodeToInsert);
            LinkTwo(nodeToInsert, temp);

            if (nodeToInsert.Prev == null)
            {
                Head = nodeToInsert;
            }
        }

        // O(p) Time | O(1) Space
        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            Remove(nodeToInsert);

            if (Head == null || position == 0)
            {
                SetHead(nodeToInsert);
                return;
            }

            int i = 1;
            Node curr = Head;

            while (curr.Next != null && i < position)
            {
                curr = curr.Next;
                i++;
            }

            InsertAfter(curr, nodeToInsert);
        }

        // O(n) Time | O(1) Space
        public void RemoveNodesWithValue(int value)
        {
            var curr = Head;

            while (curr != null)
            {
                if (curr.Value == value)
                {
                    Remove(curr);
                    RemoveNodesWithValue(value);
                }

                curr = curr.Next;
            }
        }

        // O(1) Time | O(1) Space
        public void Remove(Node node)
        {
            if (Head == node)
            {
                Head = Head.Next;
            }
            if (Tail == node)
            {
                Tail = Tail.Prev;
            }

            LinkTwo(node.Prev, node.Next);

            node.Next = null;
            node.Prev = null;
        }

        // O(n) Time | O(1) Space
        public bool ContainsNodeWithValue(int value)
        {
            var curr = Head;

            while (curr != null)
            {
                if (curr.Value == value)
                {
                    return true;
                }

                curr = curr.Next;
            }
            return false;
        }
    }
}