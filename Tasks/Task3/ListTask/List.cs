using System.Collections.Generic;
using System;
namespace ListTask 
{
    class Program{

         public static void Main(string[] args)
        {
            Console.WriteLine("df");
        }
    }
    public class List
    {
        class Node
        {
            public int value;
            public Node next;
            public Node prev;
        }

        private Node head;
        private Node tail;
        private int size;

        public List() 
        {
            head = null;
            tail = null;
            size = 0;   
        }

        public List(IEnumerable<int> collection) 
        {
            foreach (int size in collection)
            {
                PushBack(size);
            }  
        }

        public int? Front()
        {
             if (head != null)
                return head.value;

            else
            {
                return null;
            }
        }

        public int? Back()
        {
            if (tail != null)
                return tail.value;

            else
            {
                return null;
            }
        }

        public bool Empty()
        {
            if(this.size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return this.size;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public void PushBack(int value)
        {
           Node newNode = new Node(); //создали новый нод
           newNode.value = value; //присвоили ему значение от пользователя
           if(tail is Node && head is Node){ //
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
           } 
           else{
            head = newNode;
            tail = newNode;
           }
           size++;
        }
        public int PopBack()
        {
            int buf = tail.value;
            tail = tail.prev;
            tail.next = null;
            size--;
            return buf;
        }
        public void PushFront(int value)
        {
             Node newNode = new Node();
            newNode.value = value;

            if (tail is Node && head is Node)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            else
            {
                head = newNode;
                tail = newNode;
            }

            size++;
        }

        public int PopFront()
        {
            size--;
            int buf = head.value;
            head = head.next;
            return buf; 
        }

        public void Resize(int count)
        {
           if (count > size)
            {
                int a = count - size;
                for (int i = 0; i < a; i++)
                {
                    PushBack(0);
                }
            }
            else if (count < size)
            {
                int b = size - count;
                for (int i = 0; i < b; i++)
                { 
                        PopBack();
                }

            }
            size = count;
        }

        public void Swap(List other_list)
        {
            List buf = new List();
            buf.head = other_list.head;
            buf.tail = other_list.tail;
            other_list.head = head;
            other_list.tail = tail;
            head = buf.head;
            tail = buf.tail;
        }

        public void Remove(int value)
        {
           Node buf = head;

            while (buf.value != value && buf != tail)
            {
                buf = buf.next;

            }

            if (buf.value != value)
            {
                throw new Exception("No such value");

            }

            if (buf == tail)
            {
                tail = buf.prev;

            }
            else if (buf == head)
            {
                head = buf.next;
            }
            else
            {

                buf.prev.next = buf.next;
                buf.next.prev = buf.prev;
            }
            size--;
        }

        public void Unique()
        {
           if (head == null && tail == null)
            {
                throw new NullReferenceException();
            }

            Node buff = head;
            while (buff.next != null)
            {
                if (buff.next.value == buff.value)
                {
                    Node buff2 = buff.next;
                    while (buff2.next != null && buff2.next.value == buff.value)
                    {
                        buff2 = buff2.next;

                    }

                    if (buff2.next != null)
                    {
                        buff.next = buff2.next;
                        buff2.next.prev = buff;
                    }
                    else
                    {
                        buff.next = null;
                        tail = buff;
                        return;
                    }

                }
                buff = buff.next;
            }
        }

        public void Sort()
        {
             Node node = head;
            Node bufNode = head;
            Node min = head;
            while (node.next != null)
            {
                while (bufNode != null)
                {
                    if (min.value > bufNode.value)
                    {
                        min = bufNode;
                    }
                    bufNode = bufNode.next;
                }

                int buf = node.value;
                node.value = min.value;
                min.value = buf;

                node = node.next;
                bufNode = node;
                min = node;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > size - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (index == 0)
                {
                    return head.value;
                }
                else
                {
                    int ind = 0;
                    Node buf = head;
                    while (index != ind)
                    {
                        buf = buf.next;
                        ind++;
                    }
                    return buf.value;
                }

            }
            set
            {
                if (index < 0 || index > size - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                if (index == 0)
                {
                    head.value = value;
                }
                else
                {
                    int ind = 0;
                    Node buf = head;
                    while (index != ind)
                    {
                        buf = buf.next;
                        ind++;
                    }
                    buf.value = value;
                }
            }
        }
    }
}