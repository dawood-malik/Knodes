using System;
namespace kuuuu
{
    class Node 
    {
        public int data;
        public Node next;
        public Node(int data = 0,Node next = null)
        {
            this.data = data;
            this.next = next;
        }
    }
    class MergeList
    {
        public Node MergeKList(Node[] lists)
        {
            if(lists==null && lists.Length == 0)
            {
                return null;
            }

            List<int> merger=new List<int> ();
            foreach(var list in lists)
            {
                Node dummy= list;
                while(dummy!=null)
                {
                    merger.Add(dummy.data);
                    dummy=dummy.next;
                }
            }
            merger.Sort();
            Node current=new Node();
            Node carry = current;
            foreach(var node in merger)
            {
                carry.next = new Node(node);
                carry = carry.next;
            }
            return current.next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node[] lists = new Node[]
            {
                new Node(2,new Node(3,new Node(1))),new Node(1,new Node(4,new Node(2))),
                new Node(3,new Node(1))
            };

            MergeList mergeList = new MergeList();
            Node current=mergeList.MergeKList(lists);
            while(current!=null)
            {
                Console.Write(current.data+"-->");
                current= current.next;
            }
        }
    }

}