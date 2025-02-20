﻿using System;

abstract class Progression
{
    public int First { get; set; }
    public int Last { get; set; }
    public int H { get; set; }

    public List<int> progList;

    public Progression(int first, int last, int h)
    {
        First = first; Last = last; H = h;
        progList = new List<int>();
    }

    public void TemplateMethod()
    {
        InitializeProgression(First, Last, H);
        Progress();
        Print(progList);
    }

    private void Print(List<int> progList)
    {
        Console.WriteLine("Последовательность: ");
        foreach (var item in progList)
        {
            Console.WriteLine(" " + item);
        }
        Console.WriteLine();
    }

    private void InitializeProgression(int a, int b, int h)
    {
        First = a; Last = b; H = h;
    }

    public abstract void Progress();
}
