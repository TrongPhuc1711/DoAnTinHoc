using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    internal class DanhMucSapXep:DanhSachLienKetKep
    {

        private DanhSachLienKetKep dsLKKep;
        private List<SapXep> dsSapXep;
        

        public DanhMucSapXep()
        {
            this.dsLKKep = new DanhSachLienKetKep();
            
        }
        public DanhMucSapXep(DanhSachLienKetKep dsLKKep)
        {
            this.dsLKKep=dsLKKep;
           
        }

        public DanhSachLienKetKep DSLKKep
        {
            get { return this.dsLKKep; }
            set { this.dsLKKep = value; }
        }
       
        //selectionSort
        public  void SelectionSort()
        {
            Node curr = dsLKKep.head;
            while (curr != null)
            {
                Node min = curr;
                Node nextNode = curr.Next;
                while (nextNode != null)
                {
                    if (nextNode.Data < min.Data)
                    {
                        min = nextNode;
                    }
                    nextNode = nextNode.Next;
                }
                if (min != curr)
                {
                    float temp = curr.Data;
                    curr.Data = min.Data;
                    min.Data = temp;
                }
                curr=curr.Next;
            }
        }

        //QuickSort
        public void QuickSort()
        {
            QuickSortRec(dsLKKep.head,dsLKKep.tail);
        }
        private void QuickSortRec(Node start, Node end)
        {
            if (start == null || end == null || start == end || start == end.Next)
            { 
                return;
            }
            // Lấy phần tử pivot
            Node pivotNode = PhanVung(start, end);

            // Sắp xếp phần tử nhỏ hơn pivot
            if (pivotNode != null && pivotNode.Prev != null)
            {
                QuickSortRec(start, pivotNode.Prev);
            }

            // Sắp xếp phần tử lớn hơn pivot
            if (pivotNode != null && pivotNode.Next != null)
            {
                QuickSortRec(pivotNode.Next, end);
            }
            
        }
        private Node PhanVung(Node start, Node end)
        {
            float pivot = end.Data;
            Node i=start.Prev;
            for(Node j = start; j != end; j = j.Next)
            {
                if(j.Data < pivot)
                {
                    i = ((i == null) ? start : i.Next);

                    Swap(i, j);
                }
            }
            i=((i==null) ? start : i.Next);
            Swap(i,end);
            return i;
        }


        //ham swap
        public void Swap(Node a, Node b) 
        {
            float temp = a.Data;
            a.Data = b.Data;
            b.Data = temp;
        }

    }
}
