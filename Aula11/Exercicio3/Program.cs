﻿using System;

public class Program
{
    private static void Main()
    {
        MyVector v = new MyVector(3, 5.5f);
        v[1] = 3.4f;
        v["A"] = -233f;
        v["b"] += 10;
        Console.WriteLine($"{v["X"]}, {v["1"]}");
    }
}
