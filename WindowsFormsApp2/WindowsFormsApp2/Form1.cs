using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
//输出：7 -> 0 -> 8
//原因：342 + 465 = 807
        private void button1_Click(object sender, EventArgs e)
        {
            //ListNode l1=new ListNode(2);
            #region The Past
            //ListNode l12 = new ListNode(4);
            //l1.next = l12;
            //ListNode l13 = new ListNode(3);
            //l12.next = l13;
            //ListNode l2=new ListNode(5);
            //ListNode l22 = new ListNode(6);
            //l2.next = l22;
            //ListNode l23 = new ListNode(4);
            //l22.next = l23;
            int[] a = new int[] {  -1,2,1,-4 };
            //a = new int[] { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 };
            ListNode l1=convertToListNode(a);
            int[] b = new int[] { 2 };
            ListNode l2 = convertToListNode(b);
            //this.label1.Text = AddTwoNumbers(l1, l2).val.ToString() ;
            this.label1.Text = LongestPalindrome3(this.textBox1.Text);
            //this.label1.Text = MaxArea(a).ToString();
            //this.label1.Text = ThreeSumClosest(a,1).ToString();
            //b = new int[] { 1,4,5 };
            //l1 = convertToListNode(b);
            //b = new int[] { 1,3,4 };
            //l2 = convertToListNode(b);
            //b = new int[] { 2,6 };
            //ListNode l3 = convertToListNode(b);
            //ListNode[] lists = new ListNode[] { l1, l2,l3 };
            //this.label1.Text = getValueString(MergeKLists(lists));
            int[][] matrix=new int[][]{

　　　　        new int[]{1,2,3,4,5},

　　　　        new int[] {6,7,8,9,10},

　　　　        new int[] {11,12,13,14,15},
                new int[] {16,17,18,19,20},
                new int[] {21,22,23,24,25},
                new int[] {26,27,28,29,30},
                new int[] {31,32,33,34,35}
　　　　        };
            matrix=new int[][]{new int[]{1}};
            //this.label1.Text = SpiralOrder(matrix).Count.ToString();
            //this.label1.Text = GenerateMatrix(Convert.ToInt32(this.textBox1.Text)).Length.ToString();
            int?[] input = new int?[] { 3, 9, 20, null, 6, null, 7, null, null, 3, null, null, null, 7, 8 };
            //this.label1.Text = MaxDepth(ConvertToTree(input)).ToString();
            
            input = new int?[] { -10, 9, 20, null, null, 15, 7 };
            //this.label1.Text = MaxPathSum(ConvertToTree(input)).ToString();
            char[] chars = new char[] { 'A', 'B', 'C', 'A', 'D', 'C', 'A', 'C', 'A', 'B', 'B' };
            chars = new char[] { 'A', 'B',  'A'};
            this.label1.Text = LeastInterval(chars,2).ToString();

            MinStack minStack = new MinStack();
            //minStack.Push(-2);
            //minStack.Push(0);
            //minStack.Push(-3);
            //int min = minStack.GetMin();   //--> 返回 -3.
            //minStack.Pop();
            //int top =minStack.Top();      //--> 返回 0.
            //this.label1.Text  = minStack.GetMin().ToString();   //--> 返回 -2.

            string[] command = new string[] { "MinStack","push","push","push","top","pop","getMin","pop","getMin","pop","push","top","getMin","push","top","getMin","pop","getMin"};
            int[] value = new int[]{ 0,2147483646,2147483646,2147483647,0,0,0,0,0,0,2147483647,0,0,-2147483648,0,0,0,0};
//            ["MinStack","push","push","push","getMin","pop","top","getMin"]
//[[],[-2],[0],[-3],[],[],[],[]]
            command = new string[] { "MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin" };
            value = new int[]{0,-2,0,-3,0,0,0,0};
            RunCommand(minStack, command, value);

            value = new int[] { 1, 2, 3 };
            this.label1.Text = Permute(value).ToString();

            value = new int[] { 4,1,2,1, 2 };
            this.label1.Text = SingleNumber(value).ToString();
            #endregion

            input = new int?[] { 1, 4, 2, 5, 6, 3 };
            //input = new int?[] { 1, null, 2, null, null, 3 };
            TreeNode root = ConvertToTree(input);
            InorderTraversal(root);
            value = new int[] { 3,4, 5, 6, 7,8,9, 0, 1, 2 };
            value = new int[] { 5,1,2, 3, 4 };
            this.label1.Text = Search(value, 4).ToString();
        }

        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int result = 0;
            int point=-1;
            List<int> list = new List<int>();
            for (int i= 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    list.Add(nums[i]);
                    point = i;
                    break;
                }
                else
                    list.Add(nums[i]);
            }
            if (list.Count > 0 && point!=-1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i < nums.Length - point - 1)
                    {
                        nums[i] = nums[point + i + 1];
                    }
                    else
                    {
                        nums[i] = list[i+point+1 - nums.Length];
                    }
                }
            }
            int leftindex = 0;
            int rightindex = nums.Length - 1;
            result = BinarySearch(nums, ref rightindex, ref leftindex, target);
            if (-1 < result && result < nums.Length - point - 1)
                result = result +  point + 1;
            else if (result > nums.Length - point - 2)
                result = result - (nums.Length - point -1 );
            return result;
        }
        static void SetCapacity(ref int[] iarr)
        {
            Array.Resize<int>(ref iarr, iarr.Length + (2 << 3));
        }
        public int BinarySearch(int[] nums, ref int rightindex, ref int leftindex, int target)
        {
            //if (index == 0)
            //{
            //    index = nums.Length % 2 == 0 ? nums.Length / 2 : (nums.Length - 1) / 2;
            //}
            int result=-1;
            if (target == nums[leftindex])
                return leftindex;
            if (target == nums[rightindex])
                return rightindex;
            int binary = (rightindex - leftindex) % 2 == 0 ? (rightindex - leftindex) / 2 + leftindex : ((rightindex - leftindex) + 1) / 2 + leftindex;
            if (binary == rightindex || binary == leftindex)
                return result;
            if (nums[binary] > target)
            {
                rightindex = binary;
                result=BinarySearch(nums, ref rightindex, ref leftindex, target);
            }
            else if (nums[binary] == target)
            {
                return binary;
            }
            else
            {
                leftindex = binary;
                result=BinarySearch(nums, ref rightindex, ref leftindex, target);
            }
            return result;
        }
        public int FindKthLargest(int[] nums, int k)
        {
            //int result = 0;
            MaoPao(ref nums);
            return nums[k-1];
        }
        public void MaoPao(ref int[] arr)
        {
            //冒泡排序 
            int test = 0;//定义一个中间变量，用来交换值
            //int[] arr = { 45, 1, 8, 2, 9, 89 };//定义一个无序数组，用来排序
            for (int i = 0; i < arr.Length - 1; i++)//我们外层循环需要循环n-1次
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])//判断两个值大小是否要交换值
                    {
                        test = arr[j + 1];//如果数组第二个数小于前一个数，那么把第二个小的数先存放在 test中
                        arr[j + 1] = arr[j];//把前一个大的数放到后面
                        arr[j] = test;//再把我们存放在test中的小的数放到前面
                    }
                }
            }
        }
        public void MaoPaoString(ref string[] arr)
        {
            //冒泡排序 
            string test = "";//定义一个中间变量，用来交换值
            //int[] arr = { 45, 1, 8, 2, 9, 89 };//定义一个无序数组，用来排序
            for (int i = 0; i < arr.Length - 1; i++)//我们外层循环需要循环n-1次
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)//判断两个值大小是否要交换值
                    {
                        test = arr[j + 1];//如果数组第二个数小于前一个数，那么把第二个小的数先存放在 test中
                        arr[j + 1] = arr[j];//把前一个大的数放到后面
                        arr[j] = test;//再把我们存放在test中的小的数放到前面
                    }
                }
            }
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
                return result;
            
            List<int> val=new List<int>();
            List<TreeNode> tree=new List<TreeNode>();
            MidTraverse(root, ref val, ref tree);
            result = _result;
            return result;
        }
        int _max = 0;
        List<TreeNode> _treeNodes = new List<TreeNode>();
        List<int> _result = new List<int>();
        public void MidTraverse(TreeNode root, ref List<int> val,ref List<TreeNode> tree)
        {
            tree.Add(root);
            val.Add(root.val);
            if (root.left != null)
            {

                MidTraverse(root.left, ref val,ref tree);
                if (!_treeNodes.Contains(tree[tree.Count - 1]))
                {
                    _treeNodes.Add(tree[tree.Count - 1]);
                    _result.Add(val[val.Count - 1]);
                }
                val.RemoveAt(val.Count - 1);
                tree.RemoveAt(tree.Count - 1);
            }
            if (!_treeNodes.Contains(root))
            {
                _treeNodes.Add(root);
                _result.Add(root.val);
            }
            if (root.right != null)
            {
                MidTraverse(root.right, ref val,ref tree);
                if (!_treeNodes.Contains(tree[tree.Count - 1]))
                {
                    _treeNodes.Add(tree[tree.Count - 1]);
                    _result.Add(val[val.Count - 1]);
                }
                val.RemoveAt(val.Count - 1);
                tree.RemoveAt(tree.Count - 1);
            }
            //if (root.left == null && root.right == null)
            //{
            //    if (val.Count > _max)
            //    {
            //        _max = val.Count;
            //    }

            //}
        }

        #region The Past
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            //int[,] col = new int[nums.Length, 2];
            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
                
            }
            return result;
        }

        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> first = new List<int>();
            int[] count = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                count[i] = 1;
                first.Add(nums[i]); 
            }
            List<int> subresult = new List<int>();
            int sum = 0;
            PermuteRecursion(sum,nums, count, ref result, ref subresult);
            
            return result;
        }
        public void PermuteRecursion(int sum,int[] nums, int[] count, ref IList<IList<int>> result, ref List<int> subresult)
        {
            //for (int z = 0; z < nums.Length - 1; z++)
            //{
                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] != 0)
                    {
                        sum++;
                        count[i] = 0;
                        subresult.Add(nums[i]);
                        PermuteRecursion(sum, nums, count, ref result, ref subresult);
                        count[i] = 1;
                        sum--;
                        subresult.RemoveAt(subresult.Count-1);
                    }
                }
                if (sum == count.Length)
                {

                    List<int> subresult2 = new List<int>(subresult);
                    result.Add(subresult2);
                    return;
                }
            //}
        }
        public int RunCommand(MinStack minStack, string[] command, int[] value)
        {
            int reuslt = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "MinStack")
                    continue;
                if (command[i] == "push")
                {
                    minStack.Push(value[i]);
                }
                if (command[i] == "top")
                {
                    reuslt=minStack.Top();
                }
                if (command[i] == "getMin")
                {
                    reuslt = minStack.GetMin();
                }
                if (command[i] == "pop")
                {
                    minStack.Pop();
                }
            }
            return reuslt;
        }
        public class MinStack
        {

            /** initialize your data structure here. */
            public List<int> _stack = new List<int>();
            int? _min = null;
            public MinStack()
            {

            }

            public void Push(int x)
            {
                if (_min == null || x < _min)
                    _min = x;
                _stack.Add(x);
            }

            public void Pop()
            {

                bool needRestore = false;
                if (_min == _stack[_stack.Count - 1])
                    needRestore = true;
                _stack.RemoveAt(_stack.Count - 1);
                List<int> stack=new List<int>(_stack);
                if (needRestore)
                {
                    
                    _stack.Sort((str, str2) =>
                    {
                        if (str < str2)
                            return 1;
                        return 0;
                    });
                    if (_stack.Count>0)
                        _min = _stack[0];
                    _stack = stack;
                }
            }

            public int Top()
            {
                return _stack[_stack.Count - 1];
            }

            public int GetMin()
            {
                if (_min != null)
                    return (int)_min;
                else
                    return 0;
            }
        }

        
        public int LeastInterval(char[] tasks, int n)
        {
            int result = 0;
            List<string[]> list = new List<string[]>();
            //for (int i = 0; i < tasks.Length; i++)
            //{
            //    string a = tasks[i].ToString();
            //    string[] aa = list.Find(item => item[0] == tasks[i].ToString());
            //    if (list.Find(item => item[0] == tasks[i].ToString()) == null)
            //    {
            //        string[] s = new string[] { tasks[i].ToString(), "1" };
            //        list.Add(s);
            //    }
            //    else
            //    {
            //        string[] aaa = list.Find(item => item[0] == tasks[i].ToString());
            //        int count = Convert.ToInt32(list.Find(item => item[0] == tasks[i].ToString())[1]);
            //        count += 1;
            //        list.Find(item => item[0] == tasks[i].ToString())[1] = count.ToString();
            //    }
            //}
            //list.Sort((str, str2) =>
            //{
            //    if (Convert.ToInt32(str[1]) > Convert.ToInt32(str2[1]))
            //        return 1;
            //    return 0;
            //});
            list = ConvertToList(tasks);
            if (list.Count > n + 1)
            {
                for (int i = n; i < list.Count; i++)
                {
                    list=ConvertToList(tasks);
                    int r=LeastInterval2(list, i);
                    if (r < result || result==0)
                        result = r;
                }
            }
            else
            {
                int r = LeastInterval2(list, n);
                if (r < result || result == 0)
                    result = r;
            }
            return result;
        }
        public List<string[]> ConvertToList(char[] tasks)
        {
            List<string[]> list = new List<string[]>();
            for (int i = 0; i < tasks.Length; i++)
            {
                string a = tasks[i].ToString();
                string[] aa = list.Find(item => item[0] == tasks[i].ToString());
                if (list.Find(item => item[0] == tasks[i].ToString()) == null)
                {
                    string[] s = new string[] { tasks[i].ToString(), "1" };
                    list.Add(s);
                }
                else
                {
                    string[] aaa = list.Find(item => item[0] == tasks[i].ToString());
                    int count = Convert.ToInt32(list.Find(item => item[0] == tasks[i].ToString())[1]);
                    count += 1;
                    list.Find(item => item[0] == tasks[i].ToString())[1] = count.ToString();
                }
            }
            list.Sort((str, str2) =>
            {
                if (Convert.ToInt32(str[1]) > Convert.ToInt32(str2[1]))
                    return 1;
                return 0;
            });
            return list;
        }
        public int LeastInterval2(List<string[]> tasks, int n)
        {
            int result = 0;
            string queue="";
            int tasksCount = tasks.Count;
            int oldtasksCount = tasksCount;
            while (tasksCount > 0)
            {
                int sum = 0;
                for (int i = 0; i < n + 1; i++)
                {
                    //tasksCount = tasks.Count;
                    
                    for (int j = 0; j < tasks.Count; j++)
                    {
                        try
                        {
                            if (sum == n + 1)
                                break;
                            if (Convert.ToInt32(tasks[j][1]) == 0 || (queue.Contains(tasks[j][0]) && queue.Length-queue.LastIndexOf(tasks[j][0])-1 < n))
                            {
                                //tasks.Remove(tasks[j]);
                                continue;
                            }
                            else
                            {
                                sum++;
                                queue += tasks[j][0];
                                tasks[j][1] = (Convert.ToInt32(tasks[j][1]) - 1).ToString();
                            }
                        }
                        catch { }
                    }

                    //for (int z = 0; z < tasksCount; z++)
                    //{
                    //    if (Convert.ToInt32(tasks[z][1]) == 0)
                    //        tasks.Remove(tasks[z]);
                    //}
                    
                }
                //if (tasksCount < oldtasksCount)
                //{
                //    tasks.Sort((str, str2) =>
                //    {
                //        if (Convert.ToInt32(str[1]) > Convert.ToInt32(str2[1]))
                //            return 1;
                //        return 0;
                //    });
                //    oldtasksCount = tasksCount;
                //}
                tasksCount = tasks.FindAll(item => Convert.ToInt32(item[1]) != 0).Count;

                if (n + 1 > sum && tasksCount>0)
                {
                    queue += "@";
                }
            }
            return queue.Length;
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
                int result = _list.FindIndex(item => item[0] == key);
                //leastIndex = key;
                if (result != -1)
                {
                    _count++;
                    _list[result][2] = _count;
                    result = _list[result][1];

                }
                return result;
            }
            int leastIndex = 0;
            int _count = 0;
            public void Put(int key, int value)
            {
                _count++;
                int[] newOne = new int[] { key, value, _count };
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
                Traverse2(root, root2);
                //Traverse(root2, ref valList);

                foreach (var item in _treeList)
                {
                    Traverse3(item, 0, 0);
                    Traverse3(item, 1, 0);
                    Traverse3(item, 2, 0);
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
        public void Traverse3(TreeNode2 root, int dir, int sum)
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
                Traverse3(root.right, 0, sum);

            }
            if (dir != 0 && root.father != null)
            {
                if (root.father.left == root)
                    Traverse3(root.father, 1, sum);
                else
                    Traverse3(root.father, 2, sum);


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
                    catch
                    {
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
        public string OneOrTwo(string[] s, int ot)
        {
            for (int i = 0; i < ot; i++)
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
        

        public int MaxProfit3(int[] prices)
        {
            int result = new int();
            List<int[]> profits = new List<int[]>();
            for (int i = prices.Length - 1; i > 0; i--)
            {
                int max = 0;
                for (int j = i - 1; j > -1; j--)
                {
                    if (prices[i] - prices[j] > max)
                    {
                        max = prices[i] - prices[j];
                        int[] maxProfit = new int[] { j, i, prices[i] - prices[j] };
                        profits.Add(maxProfit);
                    }
                }
            }
            if (profits.Count > 1)
            {
                foreach (var item in profits)
                {
                    foreach (var item2 in profits)
                    {
                        if (item == item2)
                            continue;
                        if (item[1] > item2[0])
                            continue;
                        if ((item[2] + item2[2]) > result)
                            result = item[2] + item2[2];
                    }
                    if (item[2] > result)
                        result = item[2];
                }
            }
            else if (profits.Count == 1)
            {
                result = profits[0][2];
            }
            return result;
        }
        public int MaxProfit2(int[] prices)
        {
            int result = new int();
            for (int j = 0; j < prices.Length-1; j++)
            {
                if (prices[j + 1] - prices[j] > 0)
                    result += prices[j + 1] - prices[j];
            }
            return result;
        }
        public int MaxProfit(int[] prices)
        {
            int result = new int();
            for (int i = prices.Length-1 ; i >0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (prices[i] - prices[j] > result)
                        result = prices[i] - prices[j];
                }
            }
            return result;
        }

        
        //public int MaxDepth(TreeNode root)
        //{
        //    //int result = new int();
        //    List<int> valList=new List<int>();
        //    //_treeList = new List<TreeNode>();
        //    _max = 0;
        //    if (root != null)
        //        Traverse(root, ref valList);
        //    return _max;
        //}
        
        

        int _no = 1;
        public int[][] GenerateMatrix(int n)
        {
            int[][] result=new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            x = 0; y = 0; z = 1;
            _no = 1;
            try
            {
                for (int i = 1; i < n*2+1; i++)
                {
                    if (z % 4 == 1)
                    {
                        MoveRight2(ref result, x, y, n);
                    }
                    else if (z % 4 == 2)
                    {
                        MoveDown2(ref result, x, y, n - 1);
                    }
                    else if (z % 4 == 3)
                    {
                        MoveLeft2(ref result, x, y, n - 1);
                    }
                    else
                    {
                        MoveUp2(ref result, x, y, n);
                    }
                    z++;
                }
            }
            catch { }
            return result;
        }
        public void MoveRight2(ref int[][] result, int row, int col, int range)
        {
            for (int i = col; i < range + col; i++)
            {
                if (result[row][ i] == 0)
                {
                    result[row][i]=_no;
                    if (i == range + col - 1)
                    {
                        x = row + 1;
                        y = i;
                    }
                    _no++;
                }
                else
                {
                    x = row + 1;
                    y = i - 1;
                    break;
                }
            }
        }
        public void MoveDown2(ref int[][] result, int row, int col, int range)
        {
            for (int i = row; i < range + row; i++)
            {
                if (result[i][col] == 0)
                {
                    result[i][col] = _no;
                    if (i == range + row - 1)
                    {
                        x = i;
                        y = col - 1;
                    }
                    _no++;
                }
                else
                {
                    x = i - 1;
                    y = col - 1;
                    break;
                }
            }
        }
        public void MoveLeft2(ref int[][] result, int row, int col, int range)
        {
            for (int i = col; i > col - range; i--)
            {
                if (result[row][i] == 0)
                {
                    result[row][i] = _no;
                    if (i == col - range + 1)
                    {
                        x = row - 1;
                        y = i;
                    }
                    _no++;
                }
                else
                {
                    x = row - 1;
                    y = i + 1;
                    break;
                }
            }
        }
        public void MoveUp2(ref int[][] result, int row, int col, int range)
        {
            for (int i = row; i > row - range; i--)
            {
                if (result[i][col] == 0)
                {
                    result[i][col] = _no;
                    _no++;
                }
                else
                {
                    x = i + 1;
                    y = col + 1;
                    break;
                }
            }
        }
        int[][] _matrix;
        int[,] _count;
        int x = 0, y = 0, z = 1;
        public IList<int> SpiralOrder(int[][] matrix)
        {
            x = 0; y = 0; z = 1;
            _matrix = matrix;
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return new List<int>();
            List<int> result = new List<int>();
            int m, n;
            m = matrix.Length;
            n = matrix[0].Length;
            _count = new int[m, n];
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        result.Add(matrix[i][j]);
            //    }
            //}
            try
            {
                while (_count[x, y] != 1)
                {
                    if (z % 4 == 1)
                    {
                        MoveRight(ref result, x, y, n);
                    }
                    else if (z % 4 == 2)
                    {
                        MoveDown(ref result, x, y, m - 1);
                    }
                    else if (z % 4 == 3)
                    {
                        MoveLeft(ref result, x, y, n - 1);
                    }
                    else
                    {
                        MoveUp(ref result, x, y, m);
                    }
                    z++;
                }
            }
            catch { }
            //MoveRight(ref result, 0, 0, 4);
            //MoveDown(ref result, 1, 3, 2);
            //MoveLeft(ref result, 2, 2, 3);
            //MoveUp(ref result, 1, 0, 1);
            //MoveRight(ref result, 1, 1, 2);
            return result;
        }
        public void MoveRight(ref List<int> result,int row,int col,int range)
        {
            for (int i = col; i < range + col; i++)
            {
                if (_count[row, i] != 1)
                {
                    result.Add(_matrix[row][i]);
                    _count[row, i] = 1;
                    if (i == range + col-1)
                    {
                        x = row + 1;
                        y = i;
                    }
                }
                else
                {
                    x = row + 1;
                    y = i - 1;
                    break;
                }
            }
        }
        public void MoveDown(ref List<int> result, int row, int col, int range)
        {
            for (int i = row; i < range + row; i++)
            {
                if (_count[i, col] != 1)
                {
                    result.Add(_matrix[i][col]);
                    _count[i, col] = 1;
                    if (i == range + row - 1)
                    {
                        x = i;
                        y = col - 1;
                    }
                }
                else
                {
                    x = i - 1;
                    y = col - 1;
                    break;
                }
            }
        }
        public void MoveLeft(ref List<int> result, int row, int col, int range)
        {
            for (int i = col; i > col - range; i--)
            {
                if (_count[row, i] != 1)
                {
                    result.Add(_matrix[row][i]);
                    _count[row, i] = 1;
                    if (i == col - range + 1)
                    {
                        x = row-1;
                        y = i ;
                    }
                }
                else
                {
                    x = row - 1;
                    y = i + 1;
                    break;
                }
            }
        }
        public void MoveUp(ref List<int> result, int row, int col, int range)
        {
            for (int i = row; i > row - range; i--)
            {
                if (_count[i, col] != 1)
                {
                    result.Add(_matrix[i][col]);
                    _count[i, col] = 1;
                }
                else
                {
                    x = i + 1;
                    y = col + 1;
                    break;
                }
            }
        }
        
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;
            List<int> result2 = new List<int>();
            foreach (var item in lists)
            {
                if (item == null)
                    continue;
                getLevel(item, 1, ref result2);
            }
            int[] arr = result2.ToArray();
            arr = arr.OrderBy(a => a).ToArray();
            if (arr.Length == 0)
                return null;
            ListNode result = convertToListNode(arr);

            return result;
        }
        public ListNode convertToListNode(int[] list)
        {
            ListNode l23 = new ListNode(list[0]);
            ListNode last = new ListNode(list[0]);
            bool flag = false;
            for (int i = 1; i < list.Length; i++)
            {
                ListNode l = new ListNode(list[i]);
                if (!flag)
                {
                    flag = true;
                    l23.next = l;
                }
                last.next = l;
                last = l;
            }
            return l23;
        }
        public int getLevel(ListNode l, int now, ref List<int> result2)
        {
            result2.Add(l.val);
            if (l.next == null)
                return now;
            else
            {
                return getLevel(l.next, now + 1,ref result2);
            }
        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = 0;
            int diff = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int z = j + 1; z < nums.Length; z++)
                    {
                        int temp = nums[i] + nums[j] + nums[z];
                        if (diff == -1 || (temp > target ? temp - target : target - temp) < diff)
                        {
                            result = nums[i] + nums[j] + nums[z];
                            diff = result > target ? result - target : target - result;
                        }
                    }
                }
            }
            return result;
        }
        public int MaxArea(int[] a)
        {
            int max = 0;
            for (int i = 0, j = a.Length - 1; i < j; )
            {
                int minHeight = a[i] < a[j] ? a[i++] : a[j--];
                max = Math.Max(max, (j - i + 1) * minHeight);
            }
            return max;
        }
        public int MaxArea2(int[] height)
        {
            int result = 0;
            //int[] index = new int[height.Length];
            //for (int i = 0; i < height.Length; i++)
            //{
            //    index[i] = i + 1;
            //}
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i+1; j < height.Length; j++)
                {
                    if (i != j)
                    {
                        if (height[i] >= height[j] && height[j] * (i > j ? i - j : j - i)>result)
                        {
                            result = height[j] * (i > j ? i - j : j - i);
                        }
                        else if (height[i] < height[j] && height[i] * (i > j ? i - j : j - i) > result)
                        {
                            result = height[i] * (i > j ? i - j : j - i);
                        }
                    }
                }
            }
            return result;
        }
        
        public string LongestPalindrome2(string s)
        {
            string result = "";
            List<string> result2 = new List<string>();
            List<string> subs = GetAllSub(s, ref result2);
            int resultLength = 0;
            foreach (var item in result2)
            {
                //if (item == "cdc")
                //{
                if (item.Length > resultLength && IsPalindrome2(item))
                {
                    if (item.Length > result.Length)
                    {
                        result = item;
                        resultLength = item.Length;
                    }
                }
                //}
            }
            foreach (var item in subs)
            {
                //if (item == "cdc")
                //{
                if (item.Length > resultLength && IsPalindrome2(item))
                {
                    if (item.Length > result.Length)
                    {
                        result = item;
                        resultLength = item.Length;
                    }
                }
                //}
            }
            return result;
        }
        public string LongestPalindrome4(string s)
        {
            if (s == "")
                return "";
            string result = "";
            //List<string> subs=GetAllSub(s);
            string[,] re = GetAllSub2(s);
            
            for (int i = s.Length; i > 0;i-- )
            {
                for (int j = 0; j < s.Length+1-i; j++)
                {
                    //if (item == "cdc")
                    //{
                    if (re[i, j] == null)
                    {
                        break;
                    }
                    else
                    {
                        if (IsPalindrome2(re[i, j]))
                        {
                            return re[i, j];
                        }
                    }
                }
                //}
            }
            //foreach (var item in subs)
            //{
            //    //if (item == "cdc")
            //    //{
            //        if (item.Length>resultLength && IsPalindrome2(item))
            //        {
            //            if (item.Length > result.Length)
            //            {
            //                result = item;
            //                resultLength = item.Length;
            //                break;
            //            }
            //        }
            //    //}
            //}
            return result;
        }
        //private int Comparison(student student1, student student2)
        //{
        //    return student1.age - student2.age;
        //}
        public bool IsPalindrome(string s)
        {
            string beforeRevert = s;
            if (s.Length % 2 == 1)
            {
                for (int i = 0; i < (s.Length - 1) / 2; i++)
                {
                    s=RevertChar(s, i);
                }
                if (s.Equals(beforeRevert))
                    return true;
            }
            else
            {
                for (int i = 0; i < (s.Length) / 2; i++)
                {
                    s = RevertChar(s, i);
                }
                if (s.Equals(beforeRevert))
                    return true;
            }
            return false;
        }
        public bool IsPalindrome2(string s)
        {
            string beforeRevert = s;
            if (s.Length % 2 == 1)
            {
                for (int i = 0; i < (s.Length - 1) / 2; i++)
                {
                    if (s.Substring(i, 1) != s.Substring(s.Length - 1 - i, 1))
                    {
                        return false;
                    }
                }
                
                return true;
            }
            else
            {
                for (int i = 0; i < (s.Length) / 2; i++)
                {
                    if (s.Substring(i, 1) != s.Substring(s.Length - 1 - i, 1))
                    {
                        return false;
                    }
                }
                
                return true;
            }
            return false;
        }
        public string RevertChar(string input, int index)
        {
            string begin = input.Substring(index,1);
            int endIndex = input.Length - 1 - index;
            string end = input.Substring(endIndex, 1);
            input=input.Remove(index, 1);
            input = input.Insert(index, end);
            input = input.Remove(endIndex, 1);
            input = input.Insert(endIndex, begin);
            return input;
        }
        public string[,] GetAllSub2(string s)
        {
            string[,] result = new string[s.Length+1, s.Length];
            result[s.Length,0]=s;
            int[] count = new int[s.Length + 1];
            for (int i = 0; i < s.Length + 1; i++)
            {
                count[i] = 0;
            }
            ///cbbd
            for (int i = 0; i < s.Length - 1; i++)
            {
                //result.Add(s.Substring(0, i + 1));

                result[i + 1, count[i+1]] = s.Substring(0, i + 1);
                count[i + 1]++;        
                    
                //result.Add(s.Substring(i + 1, s.Length - (i + 1)));

                result[s.Length - (i + 1), count[s.Length - (i + 1)]] = s.Substring(i + 1, s.Length - (i + 1));
                count[s.Length - (i + 1)]++;
                        
                if ((s.Length - i - 1) > 1)
                {
                    for (int j = 1; j < s.Length - i - 1; j++)
                    {
                        //result.Add(s.Substring(i + 1, s.Length - (i + 1) - j));

                        result[s.Length - (i + 1) - j, count[s.Length - (i + 1) - j]] = s.Substring(i + 1, s.Length - (i + 1) - j);
                        count[s.Length - (i + 1) - j]++;        
                    }
                }
            }
            
            return result;
        }
        public List<string> GetAllSub(string s, ref List<string> result2)
        {
            List<string> result = new List<string>();
            result.Add(s);
            ///cbbd
            for (int i=0; i < s.Length-1; i++)
            {
                result.Add(s.Substring(0,i+1));
                result.Add(s.Substring(i + 1, s.Length - (i + 1)));
                if ((s.Length - i - 1) > 1)
                {
                    for (int j = 1; j < s.Length - i - 1; j++)
                    {
                        result2.Add(s.Substring(i + 1, s.Length - (i + 1) - j));
                    }
                }
            }
            //string[] arr=result.ToArray();
            //arr = arr.OrderByDescending(a => a.Length).ToArray();
            ////冒泡排序 
            //string test = "";//定义一个中间变量，用来交换值
            ////int[] arr = { 45, 1, 8, 2, 9, 89 };//定义一个无序数组，用来排序
            //for (int i = 0; i < arr.Length - 1; i++)//我们外层循环需要循环n-1次
            //{
            //    for (int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        if (arr[j].Length < arr[j + 1].Length)//判断两个值大小是否要交换值
            //        {
            //            test = arr[j + 1];//如果数组第二个数小于前一个数，那么把第二个小的数先存放在 test中
            //            arr[j + 1] = arr[j];//把前一个大的数放到后面
            //            arr[j] = test;//再把我们存放在test中的小的数放到前面
            //        }
            //    }
            //}
            //result = arr.ToList();
            //foreach (var item in arr)//遍历这个排序后的数组
            //{
            //    Console.Write(item + " ");//输出
            //}

            return result;
        }
        public string LongestPalindrome3(string s)
        {
            string result = "";
            if (s.Length > 10)
            {
                if (IsPalindrome2(s))
                    return s;

                List<string> subs = GetSub(s, 7);
                bool find = false;
                foreach (var item in subs)
                {
                    if (IsPalindrome2(item))
                    {

                        result = item;
                        find = true;
                        break;

                    }
                }
                if (find)
                {
                    find = false;
                    subs = GetSub(s, 8);
                    foreach (var item in subs)
                    {
                        if (IsPalindrome2(item))
                        {

                            result = item;
                            find = true;
                            break;

                        }
                    }
                    if (find)
                    {
                        for (int i = 0; i < ((s.Length - 8) - (s.Length - 8) % 2) / 2; i++)
                        {
                            if (find)
                            {
                                find = false;
                                subs = GetSub(s, 8 + (i + 1) * 2);
                                foreach (var item in subs)
                                {
                                    if (IsPalindrome2(item))
                                    {

                                        result = item;
                                        find = true;
                                        break;

                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        find = true;
                        for (int i = 0; i < ((s.Length - 7) - (s.Length - 7) % 2) / 2; i++)
                        {
                            if (find)
                            {
                                find = false;
                                subs = GetSub(s, 7 + (i + 1) * 2);
                                foreach (var item in subs)
                                {
                                    if (IsPalindrome2(item))
                                    {

                                        result = item;
                                        find = true;
                                        break;

                                    }
                                }
                            }
                            else
                                break;
                        }
                    }
                }
                else
                {
                    find = false;
                    subs = GetSub(s, 8);
                    foreach (var item in subs)
                    {
                        if (IsPalindrome2(item))
                        {

                            result = item;
                            find = true;
                            break;

                        }
                    }
                    if (find)
                    {
                        for (int i = 0; i < ((s.Length - 8) - (s.Length - 8) % 2) / 2; i++)
                        {
                            if (find)
                            {
                                find = false;
                                subs = GetSub(s, 8 + (i + 1) * 2);
                                foreach (var item in subs)
                                {
                                    if (IsPalindrome2(item))
                                    {

                                        result = item;
                                        find = true;
                                        break;

                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                        for (int i = 6; i > 0; i--)
                        {
                            subs = GetSub(s, i);
                            find = false;
                            foreach (var item in subs)
                            {
                                if (IsPalindrome2(item))
                                {

                                    result = item;
                                    find = true;
                                    return result;

                                }
                            }
                        }
                    }
                }
            }
            else
            {
                result = LongestPalindrome4(s);
            }
            return result;
        }
        public List<string> GetSub(string s, int range)
        {
            List<string> result7 = new List<string>();

            for (int i = 0; i < s.Length - range + 1; i++)
            {
                result7.Add(s.Substring(i, range));
            }
            
            return result7;
        }
        public string[] GetAllSub3(string s,int range)
        {
            List<string> result = new List<string>();
            List<string> result7 = new List<string>();
            //123456789abcde
            if (s.Length > 10)
            {
                for (int i = 0; i < s.Length-6; i++)
                {
                    result7.Add(s.Substring(i, range));
                }
            }

            result.Add(s);
            ///cbbd
            for (int i = 0; i < s.Length - 1; i++)
            {
                result.Add(s.Substring(0, i + 1));
                result.Add(s.Substring(i + 1, s.Length - (i + 1)));
                if ((s.Length - i - 1) > 1)
                {
                    for (int j = 1; j < s.Length - i - 1; j++)
                    {
                        result.Add(s.Substring(i + 1, s.Length - (i + 1) - j));
                    }
                }
            }
            string[] arr=result.ToArray();
            arr = arr.OrderByDescending(a => a.Length).ToArray();
            ////冒泡排序 
            //string test = "";//定义一个中间变量，用来交换值
            ////int[] arr = { 45, 1, 8, 2, 9, 89 };//定义一个无序数组，用来排序
            //for (int i = 0; i < arr.Length - 1; i++)//我们外层循环需要循环n-1次
            //{
            //    for (int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        if (arr[j].Length < arr[j + 1].Length)//判断两个值大小是否要交换值
            //        {
            //            test = arr[j + 1];//如果数组第二个数小于前一个数，那么把第二个小的数先存放在 test中
            //            arr[j + 1] = arr[j];//把前一个大的数放到后面
            //            arr[j] = test;//再把我们存放在test中的小的数放到前面
            //        }
            //    }
            //}
            //result = arr.ToList();
            //foreach (var item in arr)//遍历这个排序后的数组
            //{
            //    Console.Write(item + " ");//输出
            //}

            return arr;
        }
        
       
 // Definition for singly-linked list.
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //double value1 = getValue(l1, 0, 0);
            string value1 = getValueString(l1);
            string value2 = getValueString(l2);
            string sum = TwoBigNumAdd(value1, value2);
            return calculateListNode(sum);
        }
        public string getValueString(ListNode l,string s="")
        {
            if (l.next == null)
                return l.val.ToString() + s;
            else
            {
                return getValueString(l.next, l.val.ToString() + s);
            }
        }
        public double getValue(ListNode l, int times, double val)
        {
            if (times == 30)
            {
                times = times;
            }
            if (ifZero(l))
                return 0;
            int layer = getLayer(l, 1);
            if (layer == 1)
            {
                double pow = l.val * Math.Pow(10, times);
                val += pow;
                return val;
            }
            else
            {
                double pow = l.val * Math.Pow(10, times);
                val += pow;
                return getValue(l.next, times + 1, val);
            }
        }
        public bool ifZero(ListNode l)
        {
            if (l.next == null && l.val == 0)
                return true;
            else
                return false;
        }
        public int getLayer(ListNode l, int now)
        {
            if (l.next == null)
                return now;
            else
            {
                return getLayer(l.next, now + 1);
            }
        }
        public ListNode calculateListNode(string sum)
        {

            if (sum == "0")
            {
                ListNode listNode = new ListNode(0);
                listNode.next = null;
                return listNode;
            }
            else
            {
                //int la = getLayer2(sum, 0);
                string s = sum;
                ListNode listNode = new ListNode(Convert.ToInt32(s.Substring(s.Length - 1)));
                //for (int i = 0; i < la; i++)
                //{

                //}
                if (s.Length > 1)
                    calculate(listNode, s.Substring(0, (s.Length - 1)));
                return listNode;
            }
        }
        public ListNode calculateListNode(double sum)
        {

            if (sum == 0)
            {
                ListNode listNode = new ListNode(0);
                listNode.next = null;
                return listNode;
            }
            else
            {
                //int la = getLayer2(sum, 0);
                string s = sum.ToString();
                ListNode listNode = new ListNode(Convert.ToInt32(s.Substring(s.Length - 1)));
                //for (int i = 0; i < la; i++)
                //{

                //}
                if (s.Length > 1)
                    calculate(listNode, s.Substring(0, (s.Length - 1)));
                return listNode;
            }
        }
        static string TwoBigNumAdd(string a, string b)
        {
            int k = 0;
            List<int> array = new List<int>();
            List<int> one = new List<int>();
            List<int> two = new List<int>();

            //将两个数处理成相同长度的字符串，短的小的数字前面补0
            for (int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++)
            {
                if (i >= a.Length)
                    one.Insert(i - a.Length, 0);
                else
                    one.Add(int.Parse(a[i].ToString()));
                if (i >= b.Length)
                    two.Insert(i - b.Length, 0);
                else
                    two.Add(int.Parse(b[i].ToString()));
            }

            //array集合用于存储相加的和，所以长度最大也只会比最大的数长度长1，刚开始全部存0
            for (int i = 0; i <= (a.Length > b.Length ? a.Length : b.Length); i++)
            {
                array.Add(0);
            }

            //从低位往高位每位开始相加，如果相加 >=10 则进1取余
            for (int i = (a.Length > b.Length ? a.Length : b.Length) - 1; i >= 0; i--)
            {
                array[i + 1] += (one[i] + two[i]) % 10;
                k = (one[i] + two[i]) / 10;
                if (array[i + 1] > 9)
                {
                    array[i + 1] = array[i + 1] - 10;
                    k = k + 1;
                }
                array[i] += k;
            }

            //如果首位为0，则移除
            if (array[0] == 0)
            {
                array.RemoveAt(0);
            }

            //将集合转换成字符串返回
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < array.Count; i++)
            {
                result.Append(array[i]);
            }
            return result.ToString();
        }
        public ListNode calculate(ListNode ln, string s)
        {
            ListNode l = new ListNode(Convert.ToInt32(s.Substring(s.Length - 1)));
            ln.next = l;
            if (s.Length > 1)
            {
                return calculate(l, s.Substring(0, (s.Length - 1)));
            }
            else
            {
                return l;
            }
        }
        public int getLayer2(int now, int times)
        {
            if (now >= Math.Pow(10, times))
            {
                return getLayer2(now, times + 1);
            }
            else
            {
                return times;
            }
        }
        #endregion
    }
}
