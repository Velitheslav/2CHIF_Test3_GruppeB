using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2CHIF_Test3_GruppeB
{
    class DLL
    {
        class Node // NICHT VERÄNDERN!
        {
            public int data;
            public Node prev;
            public Node next;
            public Node(int number) => data = number;
            public override string ToString() => data.ToString();
        }

        private Node head, tail;


        public void AddAtEnd(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = tail = node;
                return;
            }
            tail.next = node;
            node.prev = tail;
            tail = node;
        }
        public int Count
        {
            get
            {
                Node current = head;
                int anz = 0;
                while (current != null)
                {
                    current = current.next;
                    anz++;
                }
                return anz;
            }
        }

        public void RemoveLast(int count)
        {
            Node current = head;

            if (count <= 0 || count > Count)
            {
                return;
            }
            int l = Count - count;

            for (int i = l; i < Count; i++)
            {
                current = current.next;
                RemoveAt(i);
            }


        }

        public void SwapFirstAndLast()
        {
            if (Count <= 1)
                return;

            Node currentHead = head;
            Node currentTail = tail;

            if (Count == 2)
            {
                //(head, tail) = (tail, head);

                head.prev = tail;
                head.next = null;

                tail.next = head;
                tail.prev = null;

                head = currentTail;
                tail = currentHead;
                return;
            }


            currentHead.next.prev = currentTail;
            currentTail.prev.next = currentHead;

            currentTail.next = currentHead.next;
            currentHead.prev = currentTail.prev;

            currentTail.prev = null;
            currentHead.next = null;


            head = currentTail;
            tail = currentHead;

        }
        private bool RemoveAt(int index)
        {
            Node current = head;
            int i = 0;

            if (index < 0 || index >= Count)
            {
                return false;
            }

            if (head == tail)
            {
                head = null;
                tail = null;
                return true;
            }

            if (index == 0)
            {
                head = head.next;
                head.prev = null;

                return true;
            }

            if (index == Count - 1)
            {
                tail.prev.next = null;
                tail = tail.prev;
                return true;
            }

            while (current != null)
            {
                if (index == i)
                {
                    break;
                }

                current = current.next;
                i++;
            }

            current.prev.next = current.next;
            current.next.prev = current.prev;
            return true;
        }
        public void RemoveFistAndLast()
        {

            if (Count <= 1)
            {
                return;
            }
            if (Count == 2)
            {
                head = tail = null;
            }
            //Node currentHead = head;
            //Node currentTail = tail;

            //currentHead.next.prev = null;
            head = head.next;
            head.prev = null;

            tail = tail.prev;
            tail.next = null;

        }

        public void Set(int index, int zahl)
        {
            Node newNode = new Node(zahl);
            Node current = head;
            if (index < 0 || index > Count)
            {
                return;
            }



            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            Node temp = current;



            newNode.prev = current.prev;
            if (current == head)
            {
                head = newNode;
            }
            else
                current.prev.next = newNode;
            newNode.next = current.next;
            if (current == tail)
            {
                tail = newNode;
            }
            else
                current.next.prev = newNode;


            current.prev = null;
            current.next = null;
            //current = newNode;
            //current.prev = temp.prev;
            //current.next = temp.next;


        }

        public int[] toArray()
        {
            Node current = head;
            if (Count==null)
            {
                return null;
            }

            int[] array = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i] = current.data;
                current = current.next;
            }
            return array;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
