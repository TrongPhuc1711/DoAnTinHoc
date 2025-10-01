using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThuatToan
{
    internal class BinarySearchTree
    {
        public NodeBST root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public class NodeBST
        {
            public int data;
            public NodeBST left;
            public NodeBST right;


            public NodeBST()
            {
                this.data = 0;
                this.left = null;
                this.right = null;
            }
            public NodeBST(int data, NodeBST left, NodeBST right)
            {
                this.data = data;
                this.left = left;
                this.right = right;
            }

            public int Data
            {
                get { return this.data; }
                set { this.data = value; }
            }
            public NodeBST Left
            {
                get { return this.left; }
                set { this.left = value; }
            }
            public NodeBST Right
            {
                get { return this.right; }
                set { this.right = value; }
            }
        }
        
        //Phương thức thêm phần tử vào BST
        public void Insert(int gt)
        {
            root = InsertRec(root, gt);
        }
        private NodeBST InsertRec(NodeBST root, int gt)
        {
            if (root == null)
            {
                root = new NodeBST(gt, null, null);
                return root;
            }
            if (gt < root.Data)
            {
                root.Left = InsertRec(root.Left, gt);
            }
            else if (gt >   root.Data)
            {
                root.Right = InsertRec(root.Right, gt);
            }

            return root;
        }

        //Phương thức tìm kiếm trong BST
        public bool SearchRec(BinarySearchTree.NodeBST root, int  gt)
        {
            if (root == null)
            {
                return false;
            }

            if (gt == root.Data)
            {
                return true;
            }

            if (gt < root.Data)
            {
                return SearchRec(root.Left, gt);
            }

            return SearchRec(root.Right, gt);
        }

        //Xoa 1 node trong cay
        public NodeBST DeleteNode(NodeBST root, int gt) 
        {
            if (root == null) return null;
            if (gt < root.Data) // Nếu giá trị cần xóa nhỏ hơn node hiện tại, tìm trong cây con trái
                root.Left = DeleteNode(root.Left, gt);
            else if (gt > root.Data) // Nếu giá trị cần xóa nhỏ hơn node hiện tại, tìm trong cây con phải
                root.Right = DeleteNode(root.Right, gt);
            // Nếu giá trị cần xóa trùng với node hiện tại
            else
            {
                //Node khong co hoac chi co 1 node
                if (root.Left == null) return root.Right;
                if (root.Right == null) return root.Left;
                //Node co 2 con: Tim con nho nhat ben cay con phai
                NodeBST minNode = findMin(root.Right);
                root.Data = minNode.Data;
                root.Right = DeleteNode(root.Right, minNode.Data);
            }
        
            return root;
        }
        // Tim node nho nhat
        private NodeBST findMin(NodeBST node)
        {
            // Duyệt qua cây con bên trái cho đến khi gặp node không có con trái
            while (node.Left != null)
            {
                node = node.Left;// Tiến dần xuống các node con trái
            }
            return node;// Trả về node nhỏ nhất
        }
    } 
}
