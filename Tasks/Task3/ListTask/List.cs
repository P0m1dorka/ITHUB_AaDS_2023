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

        public int Front()
        {
            return this.head.value;
        }

        public int Back()
        {
            return this.tail.value;
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
                for (int i = 0; i < b; i++) //��������

                { 
                        PopBack();
                }

            }
            size = count;
        }

        public void Swap(List other_list)
        {
            throw new NotImplementedException();
        }

        public void Remove(int value)
        {
            throw new NotImplementedException();
        }

        public void Unique()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}