```
using C#
```



### 基础知识

#### 树

##### BST

```
Binary Search Tree 二叉查找树

特征：
父节点的左子树所有节点的值都小于或者等于父节点的值；
父节点的右子树所有节点的值都大于或者等于父节点的值。
```

##### 完全二叉树

```
完全二叉树 (Complete Binary Tree)：

A Complete Binary Tree （CBT) is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible.

对于一颗二叉树，假设其深度为d（d>1）。除了第d层外，其它各层的节点数目均已达最大值，且第d层所有节点从左向右连续地紧密排列，这样的二叉树被称为完全二叉树；

换句话说，完全二叉树从根结点到倒数第二层满足完美二叉树，最后一层可以不完全填充，其叶子结点都靠左对齐。
```

##### 完美二叉树

```
完美二叉树 (Perfect Binary Tree)：

A Perfect Binary Tree(PBT) is a tree with all leaf nodes at the same depth. All internal nodes have degree 2.

二叉树的第i层至多拥有 2^(i-1) 个节点数；深度为k的二叉树至多总共有 2^(k+1) + 1 个节点数，而总计拥有节点数匹配的，称为“满二叉树”；
```

##### 完满二叉树 

```
完满二叉树 (Full Binary Tree):

A Full Binary Tree (FBT) is a tree in which every node other than the leaves has two children.

换句话说，所有非叶子结点的度都是2。（只要你有孩子，你就必然是有两个孩子。）
```



#### 计算

##### 最大公约数

```
使用辗转相除法 ：

	gcd(a,b) = gcd(b,a%b) 
	以除数和余数反复做除法运算，当余数为 0 时，取当前算式除数为最大公约数
```

```
/// <summary>
/// 计算两个整数的最大公约数
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
/// <returns></returns>
private int GCD(int a, int b)
{
    while (a % b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return b;
}
```

