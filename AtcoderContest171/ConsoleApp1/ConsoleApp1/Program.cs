using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            Question3();
        }

        private static void Question1()
        {
            var input = Console.ReadLine();
            char ans = input[0] <= 'Z' ? 'A' : 'a';
            Console.WriteLine(ans);
        }

        private static void Question2()
        {
            var inputA = Console.ReadLine().Split(' ');
            var inputP = Console.ReadLine().Split(' ');

            var N = int.Parse(inputA[0]);
            var K = int.Parse(inputA[1]);

            int[] p = new int[N];

            for (int i = 0; i < N; i++) p[i] = int.Parse(inputP[i]);

            List<int> val = new List<int>();
            foreach (var v in p) val.Add(v);

            val.Sort();
            var sum = 0;
            for (int i = 0; i < K; i++) sum += val[i];

            Console.WriteLine(sum);
        }

        private static void Question3()
        {
            var input = Console.ReadLine();
            long N = long.Parse(input);
            char[] alphabet = new[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 
                'v', 'w', 'x', 'y', 'z'
            };

            string ans = "";
            do
            {
                N = N - 1;
                long b = N % 26;
                N /= 26;
                ans = alphabet[b] + ans;
            } while (N > 0);
            
            Console.WriteLine(ans);
        }
    }
}