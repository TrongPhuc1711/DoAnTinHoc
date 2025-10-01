using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    internal class SapXep
    {
        private float selectionSort;
        private float quickSort;

        public SapXep()
        {
            this.selectionSort = 0;
            this.quickSort = 0;
        }


        public SapXep(float selectionSort, float quickSort)
        {
            this.selectionSort = selectionSort;
            this.quickSort = quickSort;
        }

        public float SelectionSort
        {
            get { return this.selectionSort; }
            set { this.selectionSort = value; }
        }

        public float QuickSort
        {
            get { return this.quickSort; }
            set { this.quickSort = value; }
        }

    }
}

