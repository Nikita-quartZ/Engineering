﻿class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };

        StrategySort sort = new SelectionSort();
        Context context = new Context(sort, arr1);

        context.Sort();
        context.PrintArray();

        int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };
        sort = new InsertionSort();
        context = new Context(sort, arr2);

        context.Sort();
        context.PrintArray();

        int[] arr3 = { 1, 5, 15, 2, 4, 13, 19, 23, 12, 21 };
        sort = new BubbleSort();
        context = new Context(sort, arr3);

        context.Sort();
        context.PrintArray();
    }
}