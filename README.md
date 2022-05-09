#### using C#



#### 基础知识

##### BST

```
Binary Search Tree 二叉查找树

特征：
父节点的左子树所有节点的值都小于或者等于父节点的值；
父节点的右子树所有节点的值都大于或者等于父节点的值。
```

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

