using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.label1.Text = ClimbStairs(Convert.ToInt32(this.textBox1.Text)).ToString();
            int?[] input = new int?[] { -10, 9, 20, null, null, 15 };
            input = new int?[] { -790, -726, 970, 696, -266, -545, 830, -866, 669, -488, -122, 260, 116, 521, -866, -480, -573, -926, 88, 733, null, null, 483, -935, -285, -258, 892, 180, 279, -935, 675, 2, 596, 5, 50, 830, -607, -212, 663, 25, -840, null, null, -333, 754, null
               };
            
            //input = new int?[] { -10, 9, 20, null, null, 15 };
            TreeNode root = ConvertToTree(input);
            this.label1.Text = MaxPathSum2(root).ToString();

            LRUCache cache = new LRUCache(2 /* 缓存容量 */ );

            cache.Put(2, 1);
            cache.Put(2, 2);
            cache.Get(2);       // 返回  1
            cache.Put(1, 1);    // 该操作会使得密钥 2 作废
            //cache.Get(2);       // 返回 -1 (未找到)
            cache.Put(4, 11);    // 该操作会使得密钥 1 作废
            cache.Get(2);       // 返回 -1 (未找到)
            cache.Get(3);       // 返回  3
            cache.Get(4);       // 返回  4

            
        }

        public class LRUCache
        {
            int _capacity = 0;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
            }
            List<int[]> _list = new List<int[]>();
            public int Get(int key)
            {
                int result = _list.FindIndex(item=>item[0]==key);
                //leastIndex = key;
                if (result != -1)
                {
                    _count++;
                    _list[result][2]= _count;
                    result = _list[result][1];
                    
                }
                return result;
            }
            int leastIndex = 0;
            int _count = 0;
            public void Put(int key, int value)
            {
                _count++;
                int[] newOne = new int[] { key , value , _count };
                //leastIndex = key;
                int search = _list.FindIndex(item => item[0] == key);
                if (search != -1)
                {
                    _list[search][1] = value;
                    _list[search][2] = _count;
                }
                else
                {
                    if (_list.Count == _capacity)
                    {
                        int? least = null;

                        for (int i = 0; i < _list.Count; i++)
                        {
                            if (least == null || least > _list[i][2])
                            {
                                leastIndex = i;
                                least = _list[i][2];
                            }
                            //_list[i][2]--;
                            //if (_list[i][0] == leastIndex)
                            //    leastIndex = i;
                        }
                        _list.RemoveAt(leastIndex);
                        //leastIndex = 0;
                    }
                    _list.Add(newOne);
                }
            }
        }

        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */
        public int MaxPathSum2(TreeNode root)
        {
            _max = 0;
            if (root != null)
            {
                
                _max = root.val;
                getMaxValue(root);
                //Traverse(root2, ref valList);

            }
            return _max;
        }
        private int getMaxValue(TreeNode root)
        {

            if (root == null) return 0;

            int left = getMaxValue(root.left);
            int right = getMaxValue(root.right);

            //自己和左子树最大值
            int leftValue = left + root.val;

            //自己和右子树最大值
            int rigthValue = right + root.val;

            //自己和左右子树最大值
            int value = root.val + left + right;


            //最大值，包括左子树最大，右子树最大，桥接值，当前值
            _max = Math.Max(_max, Math.Max(leftValue, Math.Max(rigthValue, value)));

            //返回当前节点下的最大值，不包括桥接的，如果桥接了，那么必然与父节点断开了
            return Math.Max(Math.Max(leftValue, rigthValue), root.val);
        }
        public int MaxPathSum(TreeNode root)
        {
            _treeList = new List<TreeNode2>();
            _max = 0;
            if (root != null)
            {
                TreeNode2 root2 = new TreeNode2(root.val);
                _max = root.val;
                Traverse2(root,root2);
                //Traverse(root2, ref valList);

                foreach (var item in _treeList)
                {
                    Traverse3(item,  0,0);
                    Traverse3(item,  1, 0);
                    Traverse3(item,  2, 0);
                }
            }
            return _max;
        }
        public void Traverse2(TreeNode root, TreeNode2 root2)
        {
            //if (!_treeList.Contains(root2))
                _treeList.Add(root2);
            if (root.left != null)
            {
                TreeNode2 node = new TreeNode2(root.left.val);
                root2.left = node;
                node.father = root2;
                Traverse2(root.left, node);
            }
            if (root.right != null)
            {
                TreeNode2 node = new TreeNode2(root.right.val);
                root2.right = node;
                node.father = root2;
                Traverse2(root.right, node);
            }
        }
        public void Traverse3(TreeNode2 root, int dir,int sum)
        {
            //_treeList.Add(root);
            //int sum = 0;
            //foreach (var item in val)
            //{
                sum += root.val;
            //}
            if (sum > _max)
            {
                _max = sum;
            }
            if (dir != 1 && root.left != null)
            {
                Traverse3(root.left, 0, sum);
                
            }
            if (dir != 2 && root.right != null)
            {
                Traverse3(root.right,  0, sum);
                
            }
            if (dir != 0 && root.father != null)
            {
                if (root.father.left == root)
                    Traverse3(root.father,  1, sum);
                else
                    Traverse3(root.father,  2, sum);

                
            }
            //if ((dir == 0 && root.left == null && root.right == null)
            //    || (dir == 1 && root.father == null && root.right == null)
            //    || (dir == 2 && root.left == null && root.father == null))
            //{
            //    sum = 0;
            //    foreach (var item in val)
            //    {
            //        sum += item;
            //    }
            //    if (sum > _max)
            //    {
            //        _max = sum;
            //    }

            //}
        }
        List<TreeNode2> _treeList = new List<TreeNode2>();
        int _max = 0;
        public void Traverse(TreeNode2 root, ref List<int> val)
        {
            
            val.Add(root.val);
            if (root.left != null)
            {

                Traverse(root.left, ref val);
                val.RemoveAt(val.Count - 1);
            }
            if (root.right != null)
            {
                Traverse(root.right, ref val);
                val.RemoveAt(val.Count - 1);
            }
            if (root.left == null && root.right == null)
            {
                if (val.Count > _max)
                {
                    _max = val.Count;
                }

            }
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public class TreeNode2
        {
            public int val;
            public TreeNode2 left;
            public TreeNode2 right;
            public TreeNode2 father;
            public TreeNode2(int x) { val = x; }
        }
        public TreeNode ConvertToTree(int?[] input)
        {
            if (input.Length == 0 || input[0] == null)
                return null;

            TreeNode node = new TreeNode((int)input[0]);
            Expand(node, input);
            return node;
        }
        public void Expand(TreeNode root, int?[] input)
        {
            int level = 0;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                
                sum += Convert.ToInt32(Math.Pow(2, level));
                level++;
                if (sum > input.Length)
                    break;
            }
            //int[,] matrix = new int[level, Convert.ToInt32(Math.Pow(2, level))];
            TreeNode[,] mat = new TreeNode[level, Convert.ToInt32(Math.Pow(2, level))];
            mat[0, 0] = root;
            int count = 1;
            for (int i = 1; i < level + 1; i++)
            {
                for (int j = 0; j < Math.Pow(2, i); j++)
                {
                    //matrix[i, j] = input[count];
                    if (input.Length < count + 1)
                        break;
                    if (input[count] == null)
                    {
                        count++;
                        continue;
                    }

                    mat[i, j] = new TreeNode((int)input[count]);
                    try
                    {
                        if (j % 2 == 0)
                        {
                            mat[i - 1, (j) / 2].left = mat[i, j];
                            //mat[i, j].father = mat[i - 1, (j) / 2];
                        }
                        else
                        {
                            mat[i - 1, (j - 1) / 2].right = mat[i, j];
                            //mat[i, j].father = mat[i - 1, (j - 1) / 2];
                        }
                    }
                    catch {
                        mat[i, j] = null;
                    }
                    count++;
                }
            }
        }
        public int ClimbStairs(int n)
        {
            int result = new int();
            List<string> list = new List<string>();
            for (int i = 1; i < 1 + (n - n % 2) / 2; i++)
            {
                int howManyOne = n - i * 2;
                long chm = 1;
                for (int j = i + howManyOne; j > howManyOne; j--)
                {
                    chm = chm * j;
                    chm = chm / (i + howManyOne - j + 1);
                }
                result += Convert.ToInt32(chm);
            }
            return result + 1;
        }
        public string OneOrTwo(string[] s,int ot)
        {
            for(int i=0;i<ot;i++)
            { 

            }
            string result = ot.ToString();
            ot++;
            return result;
        } 
        public int ClimbStairs2(int i, int howManyOne)
        {
            int result = new int();
            for (int j = 0; j < i + howManyOne; j++)
            {

            }
            return result;
        }
    }
}
