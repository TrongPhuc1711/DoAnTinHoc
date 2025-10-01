using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    internal class Node
    {
        private float data;
        
        public Node next;
        public Node prev;

        public Node()
        {
            this.data = 0;
            
            this.next = null;
            this.prev = null;
        }

        public Node(float data, Node next, Node prev)
        {
          
            this.data= data;
            this.next = next;
            this.prev = prev;
        }

       
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Node Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
        public float Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        
        


    }
    internal class DanhSachLienKetKep
    {
        public Node head;
        public Node tail;

        public DanhSachLienKetKep()
        {
            head = null;
            tail = null;
        }

        public bool ThemCuoi(float data)
        {
            try
            {
                Node newNode = new Node(data, null, null);
                // Nếu danh sách đang rỗng, gán nút mới làm đầu và đuôi
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Prev = tail;
                    tail = newNode;
                }
                return true;
            }
            catch 
            { 
                return false;
            }
        }
    }
}
