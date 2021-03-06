﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2.Classes.Tasks
{
    class Task__1_10 : BaseInit_OneDim, IRunnable
    {
        public Task__1_10() :
            base ("Вставити К елементів, починаючи з номеру T") { }

        public void Run()
        {
            var (K, T) = GetData();

            Array.Resize(ref array, array.Length + K);

            for (int i = array.Length - K - 1; i >= T; --i)
                array[i + K] = array[i];

            for (int i = T; i < T + K; ++i)
                array[i] = 0;

            Console.WriteLine("New array:");
            array.Print();
        }

        public void RunWithList()
        {
            List<int> list = array.ToList();
            
            var (K, T) = GetData();

            list.InsertRange(T, Enumerable.Repeat(0, K));
            
            Console.WriteLine("New array:");
            list.Print();
        }

        private static (int, int) GetData()
        {
            Console.WriteLine("Provide how many elements you'd like to insert:");
            int K = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Provide index you want to start insertion:");
            int T = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            return (K, T);
        }
    }
}
