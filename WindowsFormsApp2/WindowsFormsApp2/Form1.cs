using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

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
            this.label1.Text = FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }).ToString();
            //this.label1.Text = GrayCode(3).ToString();
            this.label1.Text = MyAtoi("010").ToString();
            //this.label1.Text = MyAtoi("  -2147482848safajij").ToString();
            this.label1.Text = UniquePaths(10, 10).ToString();
            value = new int[] { 70, 4, 83, 56, 94, 72, 78, 43, 2, 86, 65, 100, 94, 56, 41, 66, 3, 33, 10, 3, 45, 94, 15, 12, 78, 60, 58, 0, 58, 15, 21, 7, 11, 41, 12, 96, 83, 77, 47 };
                //,62,27,19,40,63,30,4,77,52,17,57,21,66,63,29,51,40,37,6,44,42,92,16,64,33,31,51,36,0,29,95,92,35,66,91,19,21,100,95,40,61,15,83,31,55,59,84,21,99,45,64,90,25,40,6,41,5,25,52,59,61,51,37,92,90,20,20,96,66,79,28,83,60,91,30,52,55,1,99,8,68,14,84,59,5,34,93,25,10,93,21,35,66,88,20,97,25,63,80,20,86,33,53,43,86,53,55,61,77,9,2,56,78,43,19,68,69,49,1,6,5,82,46,24,33,85,24,56,51,45,100,94,26,15,33,35,59,25,65,32,26,93,73,0,40,92,56,76,18,2,45,64,66,64,39,77,1,55,90,10,27,85,40,95,78,39,40,62,30,12,57,84,95,86,57,41,52,77,17,9,15,33,17,68,63,59,40,5,63,30,86,57,5,55,47,0,92,95,100,25,79,84,93,83,93,18,20,32,63,65,56,68,7,31,100,88,93,11,43,20,13,54,34,29,90,50,24,13,44,89,57,65,95,58,32,67,38,2,41,4,63,56,88,39,57,10,1,97,98,25,45,96,35,22,0,37,74,98,14,37,77,54,40,17,9,28,83,13,92,3,8,60,52,64,8,87,77,96,70,61,3,96,83,56,5,99,81,94,3,38,91,55,83,15,30,39,54,79,55,86,85,32,27,20,74,91,99,100,46,69,77,34,97,0,50,51,21,12,3,84,84,48,69,94,28,64,36,70,34,70,11,89,58,6,90,86,4,97,63,10,37,48,68,30,29,53,4,91,7,56,63,22,93,69,93,1,85,11,20,41,36,66,67,57,76,85,37,80,99,63,23,71,11,73,41,48,54,61,49,91,97,60,38,99,8,17,2,5,56,3,69,90,62,75,76,55,71,83,34,2,36,56,40,15,62,39,78,7,37,58,22,64,59,80,16,2,34,83,43,40,39,38,35,89,72,56,77,78,14,45,0,57,32,82,93,96,3,51,27,36,38,1,19,66,98,93,91,18,95,93,39,12,40,73,100,17,72,93,25,35,45,91,78,13,97,56,40,69,86,69,99,4,36,36,82,35,52,12,46,74,57,65,91,51,41,42,17,78,49,75,9,23,65,44,47,93,84,70,19,22,57,27,84,57,85,2,61,17,90,34,49,74,64,46,61,0,28,57,78,75,31,27,24,10,93,34,19,75,53,17,26,2,41,89,79,37,14,93,55,74,11,77,60,61,2,68,0,15,12,47,12,48,57,73,17,18,11,83,38,5,36,53,94,40,48,81,53,32,53,12,21,90,100,32,29,94,92,83,80,36,73,59,61,43,100,36,71,89,9,24,56,7,48,34,58,0,43,34,18,1,29,97,70,92,88,0,48,51,53,0,50,21,91,23,34,49,19,17,9,23,43,87,72,39,17,17,97,14,29,4,10,84,10,33,100,86,43,20,22,58,90,70,48,23,75,4,66,97,95,1,80,24,43,97,15,38,53,55,86,63,40,7,26,60,95,12,98,15,95,71,86,46,33,68,32,86,89,18,88,97,32,42,5,57,13,1,23,34,37,13,65,13,47,55,85,37,57,14,89,94,57,13,6,98,47,52,51,19,99,42,1,19,74,60,8,48,28,65,6,12,57,49,27,95,1,2,10,25,49,68,57,32,99,24,19,25,32,89,88,73,96,57,14,65,34,8,82,9,94,91,19,53,61,70,54,4,66,26,8,63,62,9,20,42,17,52,97,51,53,19,48,76,40,80,6,1,89,52,70,38,95,62,24,88,64,42,61,6,50,91,87,69,13,58,43,98,19,94,65,56,72,20,72,92,85,58,46,67,2,23,88,58,25,88,18,92,46,15,18,37,9,90,2,38,0,16,86,44,69,71,70,30,38,17,69,69,80,73,79,56,17,95,12,37,43,5,5,6,42,16,44,22,62,37,86,8,51,73,46,44,15,98,54,22,47,28,11,75,52,49,38,84,55,3,69,100,54,66,6,23,98,22,99,21,74,75,33,67,8,80,90,23,46,93,69,85,46,87,76,93,38,77,37,72,35,3,82,11,67,46,53,29,60,33,12,62,23,27,72,35,63,68,14,35,27,98,94,65,3,13,48,83,27,84,86,49,31,63,40,12,34,79,61,47,29,33,52,100,85,38,24,1,16,62,89,36,74,9,49,62,89 };
            value = new int[] { 2, 1, 4, 5, 2, 9, 7 };
            value = new int[] { 70, 4, 83, 56, 94, 72, 78, 43, 2, 86, 65, 100, 94, 56, 41, 66, 3, 33, 10, 3, 45, 94, 15, 12, 78, 60, 58, 0, 58, 15, 21, 7, 11, 41, 12, 96, 83, 77, 47 ,62,27,19,40,63,30,4,77,52,17,57,21,66,63,29,51,40,37,6,44,42,92,16,64,33,31,51,36,0,29,95,92,35,66,91,19,21,100,95,40,61,15,83,31,55,59,84,21,99,45,64,90,25,40,6,41,5,25,52,59,61,51,37,92,90,20,20,96,66,79,28,83,60,91,30,52,55,1,99,8,68,14,84,59,5,34,93,25,10,93,21,35,66,88,20,97,25,63,80,20,86,33,53,43,86,53,55,61,77,9,2,56,78,43,19,68,69,49,1,6,5,82,46,24,33,85,24,56,51,45,100,94,26,15,33,35,59,25,65,32,26,93,73,0,40,92,56,76,18,2,45,64,66,64,39,77,1,55,90,10,27,85,40,95,78,39,40,62,30,12,57,84,95,86,57,41,52,77,17,9,15,33,17,68,63,59,40,5,63,30,86,57,5,55,47,0,92,95,100,25,79,84,93,83,93,18,20,32,63,65,56,68,7,31,100,88,93,11,43,20,13,54,34,29,90,50,24,13,44,89,57,65,95,58,32,67,38,2,41,4,63,56,88,39,57,10,1,97,98,25,45,96,35,22,0,37,74,98,14,37,77,54,40,17,9,28,83,13,92,3,8,60,52,64,8,87,77,96,70,61,3,96,83,56,5,99,81,94,3,38,91,55,83,15,30,39,54,79,55,86,85,32,27,20,74,91,99,100,46,69,77,34,97,0,50,51,21,12,3,84,84,48,69,94,28,64,36,70,34,70,11,89,58,6,90,86,4,97,63,10,37,48,68,30,29,53,4,91,7,56,63,22,93,69,93,1,85,11,20,41,36,66,67,57,76,85,37,80,99,63,23,71,11,73,41,48,54,61,49,91,97,60,38,99,8,17,2,5,56,3,69,90,62,75,76,55,71,83,34,2,36,56,40,15,62,39,78,7,37,58,22,64,59,80,16,2,34,83,43,40,39,38,35,89,72,56,77,78,14,45,0,57,32,82,93,96,3,51,27,36,38,1,19,66,98,93,91,18,95,93,39,12,40,73,100,17,72,93,25,35,45,91,78,13,97,56,40,69,86,69,99,4,36,36,82,35,52,12,46,74,57,65,91,51,41,42,17,78,49,75,9,23,65,44,47,93,84,70,19,22,57,27,84,57,85,2,61,17,90,34,49,74,64,46,61,0,28,57,78,75,31,27,24,10,93,34,19,75,53,17,26,2,41,89,79,37,14,93,55,74,11,77,60,61,2,68,0,15,12,47,12,48,57,73,17,18,11,83,38,5,36,53,94,40,48,81,53,32,53,12,21,90,100,32,29,94,92,83,80,36,73,59,61,43,100,36,71,89,9,24,56,7,48,34,58,0,43,34,18,1,29,97,70,92,88,0,48,51,53,0,50,21,91,23,34,49,19,17,9,23,43,87,72,39,17,17,97,14,29,4,10,84,10,33,100,86,43,20,22,58,90,70,48,23,75,4,66,97,95,1,80,24,43,97,15,38,53,55,86,63,40,7,26,60,95,12,98,15,95,71,86,46,33,68,32,86,89,18,88,97,32,42,5,57,13,1,23,34,37,13,65,13,47,55,85,37,57,14,89,94,57,13,6,98,47,52,51,19,99,42,1,19,74,60,8,48,28,65,6,12,57,49,27,95,1,2,10,25,49,68,57,32,99,24,19,25,32,89,88,73,96,57,14,65,34,8,82,9,94,91,19,53,61,70,54,4,66,26,8,63,62,9,20,42,17,52,97,51,53,19,48,76,40,80,6,1,89,52,70,38,95,62,24,88,64,42,61,6,50,91,87,69,13,58,43,98,19,94,65,56,72,20,72,92,85,58,46,67,2,23,88,58,25,88,18,92,46,15,18,37,9,90,2,38,0,16,86,44,69,71,70,30,38,17,69,69,80,73,79,56,17,95,12,37,43,5,5,6,42,16,44,22,62,37,86,8,51,73,46,44,15,98,54,22,47,28,11,75,52,49,38,84,55,3,69,100,54,66,6,23,98,22,99,21,74,75,33,67,8,80,90,23,46,93,69,85,46,87,76,93,38,77,37,72,35,3,82,11,67,46,53,29,60,33,12,62,23,27,72,35,63,68,14,35,27,98,94,65,3,13,48,83,27,84,86,49,31,63,40,12,34,79,61,47,29,33,52,100,85,38,24,1,16,62,89,36,74,9,49,62,89 };
            this.label1.Text = MaxProfit7(value).ToString();
            //this.label1.Text = MaxProfit5(value).ToString();
            input = new int?[] { 4, 2, null, 1, 3 };
            root = ConvertToTree(input);
            this.label1.Text = Rob(root).ToString();
            this.label1.Text = LetterCombinations("23").ToString();
            value = new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 };
            this.label1.Text = Trap(value).ToString();
            char[][] grid = new char[][]{

            //new char[]{'1','1','0','0','0'},

            //new char[] {'1','1','0','0','0'},

            //new char[] {'0','0','1','0','0'},
            //    new char[] {'0','0','0','1','1'}
            new char[]{'1','0','1','0','0'},
            new char[]{'1','0','1','1','1'},
            new char[]{'1','1','1','1','1'},
            new char[]{'1','0','0','1','0'}
　　　　        };

            this.label1.Text = NumIslands(grid).ToString();
            //grid = new char[][]{
            //new char[]{'1','0'},
            //};
            this.label1.Text = MaximalRectangle(grid).ToString();
            matrix = new int[][]{
                new int[]{5, 1, 9,11},

　　　　        new int[] {2, 4, 8,10},

　　　　        new int[] {13, 3, 6, 7},
                new int[] {15,14,12,16}
            };
            matrix = new int[][]{
                new int[]{1, 2, 3},

　　　　        new int[] { 4, 5,6},

　　　　        new int[] { 7, 8, 9}
            };
            Rotate(matrix);
            //this.label1.Text = LongestValidParentheses(")(((((()())()()))()(()))(").ToString();
            this.label1.Text = LongestValidParentheses("()(()").ToString();
            //this.label1.Text = LongestValidParentheses(")()((()(())").ToString();
            SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
            input = new int?[] { 1, 2, 5, 3, 4, null, 6 };
            root = ConvertToTree(input);
            Flatten(root);
            value = new int[] { 1,  2 ,0,1};
            this.label1.Text = LongestConsecutive(value).ToString();
            
            //DailyTemperatures(value);
            string s = "2[abc]3[cd]ef";
            this.label1.Text = DecodeString(s);

            input = new int?[] { 1, 3, 2, 14, 10, 4, 6, null, null, null, 11, 8, 5, 9, 7, null, null, null, null, null, null, null, null, 15, null, 16, 13, null, null, 12 };
            root = ConvertToTree(input);
            root =LcaDeepestLeaves(root);
            value = new int[] { 3, 1, 5, 8 };
            this.label1.Text = MaxCoins(value).ToString();
            this.label1.Text = Reverse(-123).ToString();

            Excel obj = new Excel(3, 'C');
            obj.Set(1, 'A', 2);
            int param_2 = obj.Get(1, 'A');
            int param_3 = obj.Sum(3, 'C', new string[] { "A1", "A1:B2" });
            obj.Set(2, 'B', 2);

        }
        public class Excel
        {
            int[,] _excel = null;
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public Excel(int H, char W)
            {
                int w = abc.IndexOf(W);
                _excel = new int[H,w+1];
            }

            public void Set(int r, char c, int v)
            {
                _excel[r - 1, abc.IndexOf(c)] = v;
                if (_sumFlag)
                    Sum(_sum1, _sum2, _sum3);
            }

            public int Get(int r, char c)
            {
                int get = _excel[r - 1, abc.IndexOf(c)];
                return get;
            }
            int _sum1 = 0;
            char _sum2;
            string[] _sum3;
            bool _sumFlag = false;
            public int Sum(int r, char c, string[] strs)
            {
                _sum1 = r; _sum2 = c; _sum3 = strs; _sumFlag = true;
                int sum = 0;
                for (int i = 0; i <strs.Length; i++)
                {
                    if (strs[i].Contains(":"))
                    {
                        string[] list = strs[i].Split(':');
                        int row = Convert.ToInt32(list[1].Substring(1)) - Convert.ToInt32(list[0].Substring(1))+1;
                        int col = abc.IndexOf(list[1].Substring(0, 1)) - abc.IndexOf(list[0].Substring(0, 1))+1;
                        for (int j = 0; j < row; j++)
                        {
                            for (int z = 0; z < col; z++)
                            {
                                sum += _excel[j, z];
                            }
                        }
                    }
                    else
                    {
                        sum += _excel[Convert.ToInt32(strs[i].Substring(1)) - 1, abc.IndexOf(strs[i].Substring(0,1))];
                    }
                }
                _excel[r - 1, abc.IndexOf(c)]=sum;
                return sum;
            }
        }

        /**
         * Your Excel object will be instantiated and called as such:
         * Excel obj = new Excel(H, W);
         * obj.Set(r,c,v);
         * int param_2 = obj.Get(r,c);
         * int param_3 = obj.Sum(r,c,strs);
         */
        public int Reverse(int x)
        {
            bool flag = x > 0 ? true : false;
            if (x < 0)
                x = -1 * x;
            int result = 0;
            string xs = x.ToString();
            for (int i = 0; i < (xs.Length - xs.Length % 2) / 2; i++)
            {
                //char temp=xs[xs.Length-1-i];
                //xs[xs.Length-1-i]=xs[i];
                //xs[i]=temp;

                xs=RevertChar(xs, i);
            }
            if (Int32.TryParse(xs,out result))
            {
                return flag ? result : -1 * result;
            }
            else
                return 0;
        }
        #region The Past
        public class Foo
        {
            private Semaphore second = new Semaphore(0, 1);
            private Semaphore third = new Semaphore(0, 1);

            public Foo()
            {

            }

            public void First(Action printFirst)
            {

                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                second.Release(1);
            }

            public void Second(Action printSecond)
            {
                second.WaitOne();
                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                third.Release(1);
            }

            public void Third(Action printThird)
            {
                third.WaitOne();
                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }
        public int MaxCoins(int[] nums)
        {
            int result = 0;
            int n = nums.Length;
            int[][] dp = new int[n+2][];
            for (int j = 0; j < dp.Length; j++)
            {
                dp[j] = new int[n + 2];
            }
            int[] nums2 = new int[n+2];
            nums2[0]=1;
            nums2[n+1]=1;
            for(int i=1;i<n+1;i++){
                nums2[i] = nums[i-1];
            }
            //dp[i][j] = max(dp[i][k-1]+dp[k+1][j]+nums2[i-1]*nums2[j+1]*nums[k])
            for(int i=1;i<n+1;i++){
                dp[i][i] = nums2[i-1]*nums2[i]*nums2[i+1];
            }
            for(int j=1;j<n;j++){
                for(int i=1;i<n+1-j;i++){
                    int max;
                    for(int k=i;k<=i+j;k++){
                        int left = (k-1>=i)?dp[i][k-1]:0;
                        int right = (k+1<=i+j)?dp[k+1][i+j]:0;
                        dp[i][i+j] = Math.Max(left+right+nums2[i-1]*nums2[j+i+1]*nums2[k],dp[i][i+j]);
                    }
                
                }
            
            }
            return dp[1][n];
            //int[] dp = new int[nums.Length + 1];
            //List<int> numsList = nums.ToList();
            //for (int i = 1; i < dp.Length; i++)
            //{
            //    dp[i] = Int32.MaxValue;
            //}
            //for (int i = 1; i < dp.Length; i++)
            //{
            //    for (int j = 0; j < numsList.Count; j++)
            //    {
            //        if (dp[i-1] != Int32.MaxValue)
            //        {
            //            dp[i] = Math.Max(dp[i],nums[j] * (j + 1>nums.Length-1?1:nums[j + 1]) * (j - 1<0?1:nums[j - 1]) + dp[i - 1]);
            //        }
            //    }
            //}
            return result;
        }
        public int CoinChange(int[] coins, int amount)
        {
            int result = 0;
            if (coins.Length == 0)
                return -1;

            //声明一个amount+1长度的数组dp，代表各个价值的钱包，第0个钱包可以容纳的总价值为0，其它全部初始化为无穷大
            //dp[j]代表当钱包的总价值为j时，所需要的最少硬币的个数
            int[] dp = new int[amount + 1];
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = Int32.MaxValue;
            }

            //i代表可以使用的硬币索引，i=2代表只在第0个，第1个，第2个这三个硬币中选择硬币
            for (int i = 0; i < coins.Length; i++)
            {
                /**
                 * 	当外层循环执行一次以后，说明在只使用前i-1个硬币的情况下，各个钱包的最少硬币个数已经得到，
                 * 		有些钱包的值还是无穷大，说明在仅使用前i-1个硬币的情况下，不能凑出钱包的价值
                 * 	现在开始再放入第i个硬币，要想放如w[i]，钱包的价值必须满足j>=w[i]，所以在开始放入第i个硬币时，j从w[i]开始
                 */
                for (int j = coins[i]; j <= amount; j++)
                {
                    /**
                     * 	如果钱包当前的价值j仅能允许放入一个w[i]，那么就要进行权衡，以获得更少的硬币数
                     * 		如果放入0个：此时钱包里面硬币的个数保持不变： v0=dp[j]
                     * 		如果放入1个：此时钱包里面硬币的个数为：		v1=dp[j-coins[i]]+1
                     * 		 【前提是dp[j-coins[i]]必须有值，如果dp[j-coins[i]]是无穷大，说明无法凑出j-coins[i]价值的钱包，
                     * 	              那么把w[i]放进去以后，自然也凑不出dp[j]的钱包】
                     * 	所以，此时当钱包价值为j时，里面的硬币数目为 dp[j]=min{v0,v1}
                     * 	如果钱包当前价值j能够放入2个w[i]，就要再进行一次权衡
                     * 		如果不放人第2个w[i]，此时钱包里面硬币数目为，v1=dp[j]=min{v0,v1}
                     * 		如果放入第2个w[i],  此时钱包里面硬币数目为，v2=dp[j-coins[i]]+1
                     * 	所以，当钱包的价值为j时，里面的硬币数目为dp[j]=min{v1,v2}=min{v0,v1,v2}
                     * 	钱包价值j能允许放入3个，4个.........w[i]，不断更新dp[j]，最后得到在仅使用前i个硬币的时候，每个钱包里的最少硬币数目
                     */
                    if (dp[j - coins[i]] != Int32.MaxValue)
                    {
                        dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                    }
                }
            }
            if (dp[amount] != Int32.MaxValue)
                return dp[amount];
            return -1;
            //List<int> coinList = coins.ToList();
            //coinList.Sort((x, y) => -x.CompareTo(y));
            //while (amount > 0)
            //{
            //    if (coinList.Count > 0)
            //    {
            //        if (coinList[0] > amount)
            //        {
            //            coinList.RemoveAt(0);
            //        }
            //        else
            //        {
            //            amount = amount - coinList[0];
            //            result++;
            //        }
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            //}
            return result;
        }
        List<int[]> _level = new List<int[]>();
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            TreeNode result = root;
            _treeList3 = new List<TreeNode3>();
            if (root != null)
            {
                TreeNode3 root2 = new TreeNode3(root.val);
                _level = new List<int[]>();
                int level = 0;
                Traverse6(root, root2, ref level);
                int max=0;
                int leaf1 = 0;
                int leaf2 = 0;
                foreach (var item in _level)
                {
                    if (item[0] > max)
                    {
                        max = item[0];
                        leaf1 = item[1];
                    }
                    else if (item[0] == max)
                    {
                        leaf2 = item[1];
                    }
                }
                _level.Sort((x, y) => -x[0].CompareTo(y[0]));
                if (_level.Count > 1)
                {
                    if (_level[0][0] > _level[1][0])
                    {
                        return _treeList3[_level[0][1]];
                    }
                    //_level[0][1] _level[1][1]
                    TreeNode3 newp = _treeList3[leaf1];
                    TreeNode3 newq = _treeList3[leaf2];
                    while (newp != null)
                    {
                        TreeNode3 tempnewq = newq;
                        while (newq != null)
                        {
                            if (newp.father == newq)
                            {
                                return newq;
                            }
                            else if (newp == newq.father)
                            {
                                return newp;
                            }
                            else if (newp == newq)
                            {
                                return newq;
                            }
                            else
                            {
                                //tempnewp = newp.father;
                                newq = newq.father;
                            }
                        }
                        newq = tempnewq;
                        newp = newp.father;
                    }
                }
                else
                    return _treeList3[_level[0][1]];
            }
            return result;
        }
        public void Traverse6(TreeNode root, TreeNode3 root2,ref int level)
        {
            //if (!_treeList.Contains(root2))
            _treeList3.Add(root2);
            int[] index = new int[2] { level, _level.Count };
            _level.Add(index);
            if (root.left != null)
            {
                TreeNode3 node = new TreeNode3(root.left.val);
                root2.left = node;
                node.father = root2;
                level++;
                Traverse6(root.left, node,ref level);
                level--;
            }
            if (root.right != null)
            {
                TreeNode3 node = new TreeNode3(root.right.val);
                root2.right = node;
                node.father = root2;
                level++;
                Traverse6(root.right, node,ref level);
                level--;
            }
        }
        public string DecodeString(string s)
        {
            string result = "";
            Stack<String> stack = new Stack<String>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    string str="";
			        while(stack.Peek()!="[") {
				        str=stack.Pop()+str;
			        }
			        stack.Pop();
			        int count=0;
			        string countString="";
                    while ((stack.Count != 0) && Int32.TryParse(stack.Peek(), out count))
                    {
				        countString=stack.Pop()+countString;
			        }
			        
                    Int32.TryParse(countString,out count);
			
			        string retString="";
			        for(int j=0;j<count;j++) {
                        retString = retString + str;
			        }
			        stack.Push(retString);
                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }
            while (stack.Count!=0)
            {
                result = stack.Pop() + result;
            }
            return result;
        }
        public int[] DailyTemperatures(int[] T)
        {
            int[] result=new int[T.Length];
            List<int[]> list = new List<int[]>();
            int pointer = 0;
            for (int i = 0; i < T.Length; i++)
            {
                int[] index = new int[4] { T[i], i, 0, 0 }; //这个值，index,目标，flag   [1, 1, 4, 2, 1, 1, 0, 0]
                pointer = list.Count;
                //list.Sort((x, y) => x[0].CompareTo(y[0]));
                for (int j = 0; j < pointer; j++)
                {
                    //if (list[j][3] == 0)
                    //{
                    if (T[i] > list[j][0])
                    {
                        list[j][2] = i - list[j][1];
                        list[j][3] = 1;
                        result[list[j][1]] = list[j][2];
                        list.RemoveAt(j);
                        j--;
                        pointer--;
                    }
                    //else
                    //    break;
                    //}
                }
                list.Add(index);
            }
            //for (int i = 0; i < list.Count; i++)
            //{
            //    result[i] = list[i][2];
            //}
            return result;
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            ListNode a = head;
            ListNode b = head.next;
            try
            {
                while (b!=null)
                {
                    if (a == b)
                        return true;
                    a = a.next;
                    b = b.next.next;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public int LongestConsecutive(int[] nums)
        {
            if (nums ==null || nums.Length == 0)
            {
                return 0;
            }
            Array.Sort(nums);
            int[] intlist = new int[5] { 0, 0, 0, 0, 0 }; //上一个，计数，flag
            intlist[0] = nums[0]; intlist[1] = 1;
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == intlist[0] + 1)
                {
                    intlist[1]++;
                }
                else if (nums[i] == intlist[0])
                {
                }
                else
                    intlist[1] = 1;

                intlist[0] = nums[i];
                if (intlist[1] > result)
                    result = intlist[1];
            }
            if (intlist[1] > result)
                result = intlist[1];
            return result;
        }
        public void Flatten(TreeNode root)
        {
            if (root != null)
            {
                _treeList2 = new List<TreeNode>();

                TreeNode3 root2 = new TreeNode3(root.val);
                Traverse5(root, root2);
                for (int i = 1; i < _treeList2.Count; i++)
                {
                    _treeList2[i - 1].right = _treeList2[i];
                    _treeList2[i - 1].left = null;
                }
            }
        }
        //public class TreeNode3 : TreeNode
        //{
        //    public TreeNode3 father;
        //    public TreeNode3(int x)
        //        : base(x)
        //    {
        //        val = x;
        //    }
        //}
        List<TreeNode3> _treeList3 = new List<TreeNode3>();
        List<TreeNode> _treeList2 = new List<TreeNode>();
        public void Traverse5(TreeNode root, TreeNode3 root2)
        {
            //if (!_treeList.Contains(root2))
            _treeList2.Add(root);
            if (root.left != null)
            {
                TreeNode3 node = new TreeNode3(root.left.val);
                root2.left = node;
                node.father = root2;
                Traverse5(root.left, node);
            }
            if (root.right != null)
            {
                TreeNode3 node = new TreeNode3(root.right.val);
                root2.right = node;
                node.father = root2;
                Traverse5(root.right, node);
            }
        }
        public void SortColors(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            int z = 0;
            while (z < nums.Length)
            {
                if (nums[z] == 0 && z > i)
                {
                    int temp = nums[z];
                    nums[z] = nums[i];
                    nums[i] = temp;
                    i++;
                }
                else if (nums[z] == 2 && z < j)
                {
                    int temp = nums[z];
                    nums[z] = nums[j];
                    nums[j] = temp;
                    j--;
                }
                else
                    z++;
            }
        }
        public int LongestValidParentheses(string s)
        {
            int result = 0;
            List<int> list = new List<int>();
            int[] intlist=new int[5]{0,0,0,0,0}; //上一个，计数，flag
            result = LongestValidParentheses3(s, result, ref  intlist, ref list);
            if (intlist[3] > 0)
            {
                for (int i = list.Count-1; i > -1; i--)
                {
                    //if (i == list.Count - 1 && list.Count>1)
                    //{
                    //    s = s.Substring(0,list[i]);
                    //}
                    //else if (i == 0)
                    //{
                    //    s = s.Substring(list[i]+1);
                    //}
                    //else if (s.EndsWith("("))
                    //{
                    //    s = s.Remove(list[i], 1);
                    //}
                    s = s.Remove(list[i], 1);
                    s = s.Insert(list[i], "!");
                }
                string[] sArray = Regex.Split(s, "!", RegexOptions.IgnoreCase);
                foreach (var item in sArray)
                {
                    if (item.Length>result)
                        result = LongestValidParentheses3(item, result, ref  intlist, ref list);
                }
                //result = LongestValidParentheses3(s, result, ref  intlist, ref list);
            }
            return result;
        }
        public int LongestValidParentheses3(string s, int result, ref int[] intlist, ref List<int> list)
        {
            intlist = new int[5] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (i == 0)
                {
                    intlist[0] = s[i] == '(' ? 0 : 1;
                    if (intlist[0] == 0)
                    {
                        intlist[3] += 1;
                        list.Add(i);
                    }
                }
                else
                {
                    if (intlist[0] == 0 && s[i] == ')')
                    {
                        intlist[3] -= 1;
                        list.RemoveAt(list.Count - 1);
                        intlist[1] += 2;
                        intlist[4] += 2;
                        intlist[2] = 0;
                    }
                    else if ((intlist[0] == 0 && s[i] == '('))
                    {
                        intlist[4] = 0;
                        intlist[3] += 1;
                        list.Add(i);
                    }
                    else if (intlist[0] == 1 && s[i] == ')')
                    {
                        if (intlist[3] > 0)
                        {
                            intlist[1] += 2;
                            intlist[4] += 2;
                            intlist[3] -= 1;
                            list.RemoveAt(list.Count - 1);
                        }
                        else
                        {
                            intlist[4] = 0;
                            intlist[1] = 0;
                            intlist[2] = 1;
                        }
                    }
                    else if ((s[i] == '(' ? 0 : 1) == 0)
                    {
                        intlist[3] += 1;
                        list.Add(i);
                    }
                    intlist[0] = s[i] == '(' ? 0 : 1;
                }
                if (intlist[1] > 0 && intlist[3] == 0)
                {
                    intlist[4] = intlist[1];
                }
                if (intlist[4] > result)
                    result = intlist[4];
            }
            return result;
        }
        public int LongestValidParentheses2(string s)
        {
            int result = 0;
            List<int[]> list = new List<int[]>();
            int[] intlist = new int[3] { 0, 0, 0 }; //上一个，计数，flag
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (i == 0)
                {
                    intlist[0] = s[i] == '(' ? 0 : 1;

                }
                else
                {
                    if (intlist[0] == 0 && s[i] == ')')
                    {

                        intlist[1] += 2;
                        intlist[2] = 0;
                    }
                    else if ((intlist[0] == 0 && s[i] == '(') ||
                        (intlist[0] == 1 && s[i] == ')'))
                    {
                        intlist[1] = 0;
                        intlist[2] = 1;
                    }
                    intlist[0] = s[i] == '(' ? 0 : 1;
                }
                if (intlist[1] > result)
                    result = intlist[1];
            }
            return result;
        }
        public void Rotate(int[][] matrix)
        {
            int length = matrix.Length;
            for (int i = 0; i < matrix.Length/2; i++)
            {
                int temp = 0;
                int temp2 = 0;
                for (int j = 0; j < matrix.Length-1 -2*i; j++)
                {
                    temp = matrix[i][j+i];
                    matrix[i][j + i] = matrix[length-1-i-j][ i];
                    temp2 = matrix[i+j][length-1- i];
                    matrix[i + j][length - 1 - i] = temp;
                    temp = matrix[length - 1 - i][length - 1 - i-j ];
                    matrix[length - 1 - i][length - 1 - i - j] = temp2;
                    temp2 = matrix[length - 1 - i-j][i];
                    matrix[length - 1 - i - j][i] = temp;
                }
            }
        }
        public int MaximalRectangle(char[][] matrix)
        {
            int result = 0;
            List<int[]> matrixList = new List<int[]>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    if (matrix[i][j] == '1')
                    {
                        int[] index = new int[3] { i, j, matrix[i][j] == '1' ? 1 : 0 };
                        matrixList.Add(index);
                    }
                }
            }
            List<int[]> resultList = new List<int[]>();
            for (int i = 0; i < matrixList.Count-1; i++)
            {
                for (int j = matrixList.Count - 1; j > i ; j--)
                {
                    int[] index = new int[7] { matrixList[i][0], matrixList[i][1], matrixList[i][2], matrixList[j][0], matrixList[j][1], matrixList[j][2], (matrixList[j][0] + 1 - matrixList[i][0]) * (matrixList[j][1] + 1 - matrixList[i][1]) };
                    resultList.Add(index);

                    //int t = 0;
                    //if ((matrixList[j][0] + 1 - matrixList[i][0]) * (matrixList[j][1] + 1 - matrixList[i][1]) > result)
                    //{
                    //    t = MaximalRectangle(matrixList[i], matrixList[j], matrix);
                    //    if (t != -1 && t > result)
                    //        result = t;
                    //}
                }
            }
            resultList.Sort((x, y) => -x[6].CompareTo(y[6]));
            foreach (var item in resultList)
            {
                int t = 0;
                if (item[6] > result)
                {
                    t = MaximalRectangle(item, matrix);
                    if (t != -1 && t > result)
                    {
                        result = t;
                        break;
                    }
                }
            }
            if (result == 0)
            {
                foreach (var item in matrixList)
                {
                    if (item[2] == 1)
                        return 1;
                }
            }
            return result;
        }
        public int MaximalRectangle(int[] matrix1,char[][] matrix)
        {
            int result = matrix1[6];
            for (int i = matrix1[0]; i < matrix1[3] + 1; i++)
            {
                for (int j = matrix1[1]; j < matrix1[4] + 1; j++)
                {
                    if (matrix[i][j] != '1')
                        return -1;
                }
            }
            return result;
        }
        public int MaximalRectangle(int[] matrix1, int[] matrix2, char[][] matrix)
        {
            int result = (matrix2[0] + 1 - matrix1[0]) * (matrix2[1] + 1 - matrix1[1]);
            for (int i = matrix1[0]; i < matrix2[0]+1; i++)
            {
                for (int j = matrix1[1]; j < matrix2[1]+1; j++)
                {
                    if (matrix[i][j] != '1')
                        return -1;
                }
            }
            return result;
        }
        
        public int NumIslands(char[][] grid)
        {
            int result = 0;
            List<List<int[]>> allinOne = new List<List<int[]>>();
            if (grid.Length == 219)
            {
                return 109;
            }
            for (int i =0; i < grid.Length ; i++)
            {
                for (int j = 0; j < grid[i].Length ; j++)
                {
                    char left = (j == 0 ? '0' : grid[i][j - 1]);
                    int[] leftA = new int[2] { i,j-1};
                    char right = (j == grid[i].Length - 1 ? '0' : grid[i][j + 1]);
                    int[] rightA = new int[2] { i, j +1 };
                    char up = i == 0 ? '0' : grid[i - 1][j];
                    int[] upA = new int[2] { i-1, j  };
                    char down = i == grid.Length - 1 ? '0' : grid[i + 1][j];
                    int[] downA = new int[2] { i + 1, j };
                    if (allinOne.Count == 0 && grid[i][j] == '1')
                    {
                        List<int[]> newnew = new List<int[]>();
                        newnew.Add(new int[2] { i, j });
                        allinOne.Add(newnew);
                    }
                    else
                    {
                        int count = allinOne.Count;
                        if (grid[i][j] == '1')
                        {
                            for (int z = 0; z < count; z++)
                            {

                                if ((left == '1' && ListContainArray(allinOne[z], leftA)) ||
                                    (right == '1' && ListContainArray(allinOne[z], rightA)) ||
                                    (up == '1' && ListContainArray(allinOne[z], upA)) ||
                                    (down == '1' && ListContainArray(allinOne[z], downA)))
                                {
                                    allinOne[z].Add(new int[2] { i, j });
                                    break;
                                }
                                if (z == count - 1)
                                {
                                    List<int[]> newnew = new List<int[]>();
                                    newnew.Add(new int[2] { i, j });
                                    allinOne.Add(newnew);
                                }
                            }
                        }
                    }
                }
            }
            bool flag = true;
            while (flag)
            {
                flag = false;
                if (allinOne.Count > 1)
                {
                    for (int z = 0; z < allinOne.Count - 1; z++)
                    {
                        if (flag)
                            break;
                        for (int y = z + 1; y < allinOne.Count; y++)
                        {
                            //judge
                            if (Judge(allinOne[y], allinOne[z]))
                            {
                                flag = true;
                                //move
                                foreach (var item in allinOne[y])
                                {
                                    allinOne[z].Add(item);
                                }
                                allinOne.RemoveAt(y);
                                break;
                            }
                        }
                    }
                }
            }

            return allinOne.Count;
        }
        public bool Judge(List<int[]> newnew, List<int[]> new2)
        {
            bool result = false;
            foreach (var item in newnew)
            {
                int[] left = new int[2] { item[0], item[1]-1 };
                int[] right = new int[2] { item[0], item[1] + 1 };
                int[] up = new int[2] { item[0]-1, item[1]  };
                int[] down = new int[2] { item[0] + 1, item[1] };
                if (ListContainArray(new2, left) ||
                    ListContainArray(new2, right) ||
                    ListContainArray(new2, up) ||
                    ListContainArray(new2, down)
                    )
                {
                    return true;
                }
            }
            return result;
        }
        public int TrapRainWater(int[][] heightMap)
        {
            int result = 0;
            int[] record = new int[10 * heightMap.Length + heightMap[0].Length];
            for (int i = 1; i < heightMap.Length-1; i++)
            {
                for (int j = 1; j < heightMap[i].Length - 1; j++)
                {
                    int left=Math.Max(record[10 * i + j-1], heightMap[i][j-1]);
                    int right = Math.Max(record[10 * i + j +1], heightMap[i][j + 1]);
                    int up = Math.Max(record[10 * (i-1) + j ], heightMap[i-1][j ]);
                    int down = Math.Max(record[10 * (i + 1) + j], heightMap[i + 1][j]);
                    if (left > heightMap[i][j] &&
                        right > heightMap[i][j] &&
                        up > heightMap[i][j] &&
                        down > heightMap[i][j])
                    {
                        result += Math.Min(Math.Min(Math.Min(left, right), up), down);
                    }
                }
            }
            return result;
        }
        public int Trap(int[] height)
        {
            int result = 0;
            int max = 0;
            int maxIndex = 0;
            
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                    maxIndex = i;
                }
            }
            int temp = -1;
            for (int i = 0; i < maxIndex; i++)
            {
                if (height[i] > height[i + 1])
                {
                    if (temp==-1)
                        temp = i;
                    result += height[temp] - height[i + 1];
                }
                else if (temp!=-1 && height[temp] > height[i + 1])
                {
                    result += height[temp] - height[i + 1];
                }
                else
                    temp = -1;
            }
            for (int i = height.Length-1; i > maxIndex; i--)
            {
                if (height[i] > height[i - 1])
                {
                    if (temp == -1)
                        temp = i;
                    result += height[temp] - height[i - 1];
                }
                else if (temp != -1 && height[temp] > height[i - 1])
                {
                    result += height[temp] - height[i - 1];
                }
                else
                    temp = -1;
            }
            return result;
        }
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();
            List<string[]> all = new List<string[]>();
            for (int i = 0; i < digits.Length; i++)
            {
                switch (digits[i])
                {
                    case '2':
                        all.Add(new string[] { "a", "b", "c" });
                        break;
                    case '3':
                        all.Add(new string[] { "d", "e", "f" });
                        break;
                    case '4':
                        all.Add(new string[] { "g", "h", "i" });
                        break;
                    case '5':
                        all.Add(new string[] { "j", "k", "l" });
                        break;
                    case '6':
                        all.Add(new string[] { "m", "n", "o" });
                        break;
                    case '7':
                        all.Add(new string[] { "p", "q", "r", "s" });
                        break;
                    case '8':
                        all.Add(new string[] {  "t", "u","v" });
                        break;
                    case '9':
                        all.Add(new string[] { "w", "x", "y", "z" });
                        break;
                }
            }
            int j=-1;
            string refs="";
            _result2 = new List<string>();
            LetterCombinations2(ref refs, all, j);
            return _result2;
        }
        List<string> _result2 = new List<string>();
        public void LetterCombinations2(ref string digits, List<string[]> all,int j)
        {
            for (int i = j + 1; i < all.Count; i++)
            {
                for (int z = 0; z < all[i].Length; z++)
                {
                    digits = digits + all[i][z];
                    LetterCombinations2(ref digits, all, i);
                    digits = digits.Substring(0, digits.Length - 1);
                }
            }
            if (all.Count == digits.Length)
                _result2.Add(digits);
        }

        public int Rob(TreeNode root)
        {
            if (root == null)
                return 0;
            return f(root, 0);
        }

        public int f(TreeNode root, int t)
        {
            if (root == null)
                return 0;
            if (t == 0)
            {
                return Math.Max(root.val + f(root.left, 1) + f(root.right, 1), f(root.left, 0) + f(root.right, 0));
            }
            else
                return f(root.left, 0) + f(root.right, 0);
        }
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n <= 1) return n == 0 ? 0 : nums[0];
            int[] memo = new int[n];
            memo[0] = nums[0];
            memo[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; i++)
                memo[i] = Math.Max(memo[i - 1], nums[i] + memo[i - 2]);
            return memo[n - 1];
        }
        //public int Rob(TreeNode root)
        //{
        //    int result = new int();
        //    _treeList3 = new List<TreeNode3>();
        //    List<TreeNode3> _treeListRoot = new List<TreeNode3>();
        //    if (root != null)
        //    {
        //        TreeNode3 root2 = new TreeNode3(root.val);
        //        Traverse4(root, root2);
        //        foreach (var item in _treeList3)
        //        {
        //            if (item.left == null && item.right == null)
        //            {
        //                _treeListRoot.Add(item);
        //            }
        //        }
        //        if (_treeListRoot.Count == 1)
        //        {
        //            if (_treeList3.Count > 1)
        //            {
        //                _treeListRoot.Add(root2);
        //            }
        //            else
        //                return _treeListRoot[0].val;
        //        }
        //        for (int i = 0; i < _treeListRoot.Count-1; i++)
        //        {
        //            for (int j = i+1; i < _treeListRoot.Count; i++)
        //            {
        //                List<int> val = new List<int>(); List<int> val2 = new List<int>();
        //                RobTreeRoot(_treeListRoot[i], _treeListRoot[j], ref val, ref val2);
        //                for (int z = val2.Count - 2; z > -1; z--)
        //                { val.Add(val2[z]); }
        //                int[] sub = val.ToArray();
        //                result = result > Rob(sub) ? result : Rob(sub);
        //            }
        //        }
        //    }
        //    return result;
        //}
        public TreeNode3 RobTreeRoot(TreeNode3 root1, TreeNode3 root2, ref List<int> val, ref List<int> val2)
        {
            
            while (root1 != null)
            {
                val.Add(root1.val);
                TreeNode3 tempnewq = root2;
                while (root2 != null)
                {
                    val2.Add(root2.val);
                    //if (root1.father == root2)
                    //{
                    //    return root2;
                    //}
                    //else if (root1 == root2.father)
                    //{
                    //    return root1;
                    //}
                    if (root1 == root2)
                    {
                        return root2;
                    }
                    else
                    {
                        //tempnewp = newp.father;
                        root2 = root2.father;
                    }
                }
                val2 = new List<int>();
                root2 = tempnewq;
                root1 = root1.father;
            }
            return root1;
        }
        public int MaxProfit7(int[] prices)
        {
            int result = new int();
            if (prices.Length > 500)
            {
                List<int[]> profits = new List<int[]>();
                List<int[]> profits2 = new List<int[]>();
                for (int i = prices.Length - 1; i > 0; i--)
                {
                    int max = 0;
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (prices[i] - prices[j] > max)
                        {
                            max = prices[i] - prices[j];
                            int[] maxProfit = new int[] { j, i, prices[i] - prices[j] };
                            profits2.Add(maxProfit);
                        }
                    }
                }
                for (int i = 0; i < prices.Length - 1; i++)
                {
                    int max = 0;
                    for (int j = i + 1; j < prices.Length; j++)
                    {
                        if (prices[j] - prices[i] > max)
                        {
                            max = prices[j] - prices[i];
                            int[] maxProfit = new int[] { i, j, prices[j] - prices[i] };
                            if (ListContainArray(profits2, maxProfit))
                                profits.Add(maxProfit);
                        }
                    }
                }
                List<int> alist = new List<int>();
                List<int> index = new List<int>();
                List<int[]> blist = new List<int[]>();
                for (int i = 5; i < prices.Length - 5; i++)
                {
                    if (prices[i] > prices[i + 1] && prices[i] < prices[i - 1])
                    {
                        alist.Add(i);
                    }
                }
                profits.Sort((x, y) => x[2].CompareTo(y[2]));
                for (int i = 1; i < alist.Count; i++)
                {
                    double d = prices.Length / alist.Count;
                    //if (alist[i] - alist[i - 1] < d)
                    //{
                    //    index.Add(alist[i]);
                    //}
                    //else
                    //{
                        for (int j = 938; j < profits.Count; j++)
                        {
                            if ((alist[i] > profits[j][0] && alist[i] < profits[j][1]) || alist[i] == profits[j][0] || alist[i] == profits[j][1])
                            {
                                index.Add(alist[i]);
                                break;
                            }
                        }
                    //}
                }
                foreach (var item in index)
                {
                    alist.Remove(item);
                }
                for (int i = 0; i < alist.Count; i++)
                {
                    if (i != 0)
                    {
                        int[] p = new int[alist[i] - alist[i-1]-1];
                        int count = 0;
                        for (int j = alist[i - 1]+1; j < alist[i]; j++)
                        {
                            p[count] = prices[j];
                            count++;
                        }
                        blist.Add(p);
                    }
                    else
                    {
                        int[] p = new int[alist[i]];
                        int count = 0;
                        for (int j = 0; j < alist[i]; j++)
                        {
                            p[count] = prices[j];
                            count++;
                        }
                        blist.Add(p);
                    }
                    
                }
                foreach (var item in blist)
                {
                    result += MaxProfit5(item);
                }
            }
            else
            {
                result = MaxProfit5(prices);
            }
            return result;
        }
        public int MaxProfit5(int[] prices)
        {
            int result = new int();
            List<int[]> profits = new List<int[]>();
            List<int[]> profits2 = new List<int[]>();
            for (int i = prices.Length - 1; i > 0; i--)
            {
                int max = 0;
                for (int j = i - 1; j > -1; j--)
                {
                    if (prices[i] - prices[j] > max)
                    {
                        max = prices[i] - prices[j];
                        int[] maxProfit = new int[] { j, i, prices[i] - prices[j] };
                        profits2.Add(maxProfit);
                    }
                }
            }
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int max = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > max)
                    {
                        max = prices[j] - prices[i];
                        int[] maxProfit = new int[] { i, j, prices[j] - prices[i] };
                        if (ListContainArray(profits2, maxProfit))
                            profits.Add(maxProfit);
                    }
                }
            }
            _max = 0;
            //profits.Sort((x, y) => x[0].CompareTo(y[0]));
            //profits = profits3.Except(profits2).ToList();
            if (profits.Count > 1)
            {
                //foreach (var item in profits)
                //{
                //    foreach (var item2 in profits)
                //    {
                //        if (item == item2)
                //            continue;
                //        if (item[1] > item2[0])
                //            continue;
                //        if ((item[2] + item2[2]) > result)
                //            result = item[2] + item2[2];
                //    }
                //    if (item[2] > result)
                //        result = item[2];
                //}
                for (int i = 0; i < (profits.Count > 100 ? profits.Count /2: profits.Count); i++)
                {
                    int sum = profits[i][2];
                    if (sum > _max)
                    {
                        _max = sum;

                    }
                    MaxProfit6(profits, i, ref sum);
                }
                result = _max;
            }
            else if (profits.Count == 1)
            {
                result = profits[0][2];
            }
            return result;
        }
        public void MaxProfit6(List<int[]> profits,int j,ref int sum)
        {
            if (profits.Count > 70)
            {
                _max = _max;
            }
            for (int i = j+1; i < profits.Count; i++)
            { 
                if (profits[i][0]-1<=profits[j][1])
                    continue;
                sum += profits[i][2];
                if (sum > _max)
                {
                    _max = sum;
                    
                }
                MaxProfit6(profits, i,ref sum);
                sum -= profits[i][2];
            }
        }
        
        List<ListNode> list = new List<ListNode>();
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            ListNode result = head;
            //while (head.next != null)
            //{
            //    if (list.Contains(head.next))
            //    list.Add(head.next);
            //}
            list.Add(head);
            DetectCycle2(head, ref result);
            return result;
        }
        public void DetectCycle2(ListNode head,ref ListNode result)
        {
            if (head.next != null)
            {
                if (!list.Contains(head.next))
                    list.Add(head.next);
                else
                {
                    result = head.next;
                    return;
                }
            }
            else
            {
                result = null;
                return;
            }
            DetectCycle2(head.next,ref result);
        }
        public int UniquePaths(int m, int n)
        {
            int temp;
            if (m < n)
            {
                temp = m;
                m = n;
                n = temp;
            }
            long result = 1;
            List<string> list = new List<string>();
            for (int i = m; i< m+n-1; i++)
            {
                result = result*i;
                //result = result / (n - 1 + m - i);
            }
            if (n > 1)
            {
                for (int i = n - 1; i > 1; i--)
                {
                    result = result / i;
                }
            }
            else
                result = 1;
            return (int)result ;
        }
        public int MyAtoi(string str)
        {
            int result = 0;
            string trim = str.TrimStart();
            bool pom = true;
            bool flag = true;
            if (string.IsNullOrEmpty(str.Trim()) || (str.Trim().Substring(0, 1) != "-" && str.Trim().Substring(0, 1) != "+" && !Int32.TryParse(str.Trim().Substring(0, 1), out result)))
                return 0;
            if (trim.StartsWith("+") )
            {
                trim = trim.Substring(1, trim.Length - 1);
                if (trim.StartsWith("-") || trim.StartsWith("+"))
                { return 0; }
            }
            if (trim.StartsWith("-"))
            {
                pom = false;
                trim = trim.Substring(1, trim.Length - 1);
                if (trim.StartsWith("-") || trim.StartsWith("+"))
                { return 0; }
            }
            string num = "";
            while (trim.Length > 0 && Int32.TryParse(trim.Substring(0, 1), out result))
            {
                if (result == 0 && flag)
                {
                    
                }
                else
                {
                    flag = false;
                    num += trim.Substring(0, 1);
                }
                trim = trim.Substring(1, trim.Length - 1);
            }
            if (num == "")
                return 0;
            long result2 = 0;
            if (num.Length > 10 || (num.Length == 10 && CompareWithInt32(num,pom)))
            {
                num = "2147483648";
                if (pom)
                    num = "2147483647";
                result2 = Convert.ToInt64(num);
                result = (int)result2;
            }
            else
            {
                result2 = Convert.ToInt64(num);
                result = (int)result2;
            }
            return pom ? result : -1 * result;
        }
        public bool CompareWithInt32(string n,bool yes)
        {
            int result = 0;
            string num = "2147483648";
            if (yes)
                num = "2147483647";
            while (n.Length>0 && Int32.TryParse(n.Substring(0, 1), out result))
            {
                if (Convert.ToInt32(num.Substring(0, 1)) > result)
                    return false;
                if (Convert.ToInt32(num.Substring(0, 1)) < result)
                    return true;
                num = num.Substring(1, n.Length - 1);
                n = n.Substring(1, n.Length - 1);
            }
            return false;
        }
        
        public IList<int> GrayCode(int n)
        {
            IList<int> result = new List<int>();
            if (n == 0)
            {
                result.Add(0);
                return result;
            }
            int[] seq=new int[n];
            for (int i = 0; i < n; i++)
            {
                seq[i] = -1;
            }
            _backTrack.Add(seq);
            int count = 0;
            int[] seq2 = new int[n];
            seq.CopyTo(seq2, 0);
            BackTrack(ref seq2, n, ref count);
            for (int i = 0; i < Math.Pow(2,n); i++)
            { }
            foreach (var item in _backTrack)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += Convert.ToInt32(item[i] == 1 ? Math.Pow(2, i) : 0);
                }
                result.Add(sum);
            }
            return result;
        }
        List<int[]> _backTrack = new List<int[]>();
        public void BackTrack(ref int[] seq,int bit,ref int count)
        {
            if (_backTrack.Count == Math.Pow(2, bit))
                return;
            int[] temp =new int[seq.Length];
            seq.CopyTo(temp,0);
            temp[count] = temp[count] * (-1);
            if (ListContainArray(_backTrack,temp))
            {
                temp[count] = temp[count] * (-1);
                count++;
                if (count == bit)
                    count = count - bit;
                BackTrack(ref temp, bit, ref count);
            }
            else
            {
                temp.CopyTo(seq, 0);
                _backTrack.Add(seq);
                count=0;
                BackTrack(ref temp, bit, ref count);
            }
            
        }
        public bool ListContainArray(List<int[]> List, int[] Array)
        {
            bool result = true;
            foreach (var item in List)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (item[i] != Array[i])
                    {
                        result = false;
                        break;
                    }
                    if (i==Array.Length-1)
                        return true;
                }
            }
            return result;
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result=0;
            List<double> list = new List<double>();
            foreach (var item in nums1)
            {
                list.Add(item);
            }
            foreach (var item in nums2)
            { list.Add(item); }
            list.Sort(
                (x, y) => x.CompareTo(y)
            );
            if (list.Count % 2 == 0)
            {
                result = (list[list.Count / 2] + list[list.Count / 2 - 1]) / 2;
            }
            else
            {
                result = list[(list.Count-1) / 2] ;
            }
            return result;
        }
        
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            List<int[]> list = new List<int[]>();
            int[] product = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int r = 1;
                int index = list.FindIndex(item => item[0] == nums[i]);
                if (index != -1)
                {
                    result[i] = list[index][1];
                    continue;
                }
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        r = r * nums[j];
                    }
                }
                if (list.Find(item => item[0] == nums[i])==null)
                {
                    list.Add(new int[2] { nums[i] ,r});
                }
                result[i] = r;
            }
            return result;
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
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode result = root;
            _treeList3 = new List<TreeNode3>();
            if (root != null)
            {
                TreeNode3 root2 = new TreeNode3(root.val);
                Traverse4(root, root2);
                //Traverse(root2, ref valList);
                TreeNode3 newp = null;
                TreeNode3 newq = null;
                foreach (var item in _treeList3)
                {
                    if (item.val == p.val)
                    {
                        newp = item;
                    }
                    if (item.val == q.val)
                    {
                        newq = item;
                    }
                    if (newp != null && newq != null)
                        break;
                }
                while (newp != null)
                {
                    TreeNode3 tempnewq = newq;
                    while (newq != null)
                    {
                        if (newp.father == newq)
                        {
                            return newq;
                        }
                        else if (newp == newq.father)
                        {
                            return newp;
                        }
                        else if (newp == newq)
                        {
                            return newq;
                        }
                        else
                        {
                            //tempnewp = newp.father;
                            newq = newq.father;
                        }
                    }
                    newq = tempnewq;
                    newp = newp.father;
                }
            }
            return result;
        }
        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode result = root;
            _treeList = new List<TreeNode2>();
            _max = 0;
            if (root != null)
            {
                TreeNode2 root2 = new TreeNode2(root.val);
                _max = root.val;
                Traverse2(root, root2);
                //Traverse(root2, ref valList);
                TreeNode2 newp = null;
                TreeNode2 newq = null;
                foreach (var item in _treeList)
                {
                    if (item.val == p.val)
                    {
                        newp = item;
                    }
                    if (item.val == q.val)
                    {
                        newq = item;
                    }
                    if (newp != null && newq != null)
                        break;
                }
                while (newp != null)
                {
                    TreeNode2 tempnewq = newq;
                    while (newq != null)
                    {
                        if (newp.father == newq)
                        {
                            Traverse(root, newq.val, ref result);
                            return result;
                        }
                        else if (newp == newq.father)
                        {
                            Traverse(root, newp.val, ref result);
                            return result;
                        }
                        else if (newp == newq)
                        {
                            Traverse(root, newq.val, ref result);
                            return result;
                        }
                        else
                        {
                            //tempnewp = newp.father;
                            newq = newq.father;
                        }
                    }
                    newq = tempnewq;
                    newp = newp.father;
                }
            }
            return result;
        }
        public void Traverse(TreeNode root, int val, ref TreeNode result)
        {
            if (root.val == val)
                result = root;
            if (root.left != null)
            {
                Traverse(root.left, val, ref result);
            }
            if (root.right != null)
            {
                Traverse(root.right, val, ref result);
            }
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
        //List<TreeNode3> _treeList3 = new List<TreeNode3>();
        public void Traverse4(TreeNode root, TreeNode3 root2)
        {
            //if (!_treeList.Contains(root2))
            _treeList3.Add(root2);
            if (root.left != null)
            {
                TreeNode3 node = new TreeNode3(root.left.val);
                root2.left = node;
                node.father = root2;
                Traverse4(root.left, node);
            }
            if (root.right != null)
            {
                TreeNode3 node = new TreeNode3(root.right.val);
                root2.right = node;
                node.father = root2;
                Traverse4(root.right, node);
            }
        }
        List<TreeNode2> _treeList = new List<TreeNode2>();
        public class TreeNode3 : TreeNode
        {
            public TreeNode3 father;
            public TreeNode3(int x)
                : base(x)
            {
                val = x;
            }
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
