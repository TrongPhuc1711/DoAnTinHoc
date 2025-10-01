using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    internal class DanhMucBST:BinarySearchTree
    {
        private BinarySearchTree bst;


        public DanhMucBST() 
        {
            this.bst = new BinarySearchTree();
        }

        public DanhMucBST(BinarySearchTree bst)
        {
            this.bst = bst;
        }

        public BinarySearchTree BST
        {
            get { return this.bst; }
            set { this.bst = value; }
        }
       
        //Thêm BST
        public new void Insert(int gt)
        {
            bst.Insert(gt);
        }
       


        // Tim BST
        public (bool found, double time) TimCoTG(int gt)
        {
            if(BST==null||BST.root == null)
            {
                return (false, 0);
            }
            Stopwatch sw = Stopwatch.StartNew();
            bool found = SearchRec(BST.root,gt);
            sw.Stop();
            double thoiGian = sw.Elapsed.TotalMilliseconds;
            return (found, thoiGian);
        }
        //Xoa node
        public void Delete(int gt) 
        {
            BST.root = DeleteNode(BST.root, gt);//cập nhật lại giá trị root sau khi xóa
        }
       
    }
}
