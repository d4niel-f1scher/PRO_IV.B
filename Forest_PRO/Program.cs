﻿using System;

namespace Forest_projekt
{
    class Program
    {
        public static void Main(string[] args)
        {
            // V = 1/3 pi *(r*r)v
            Tree strom = new Tree();
            strom.radius = 5;
            strom.height = 6;
            Console.WriteLine(strom.Volume);
        }
    }
}