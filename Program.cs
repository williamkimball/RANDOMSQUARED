using System;
using System.Collections.Generic;

namespace random {
    class Program {
        static void Main (string[] args) {
            Random random = new Random ();
            // Create a list
            // Populate the list
            var randomlist = new List<int> ();

            // for (var count = 0; count < 20; count++)
            //     
            // foreach (var item in randomlist) {
            //     System.Console.WriteLine (item.value);
            // }
            Random r = new Random ();

            for (int loop = 0; loop < 20; loop++) {
                int n = r.Next (1, 50);
                randomlist.Add (n);
            }
            System.Console.WriteLine(randomlist.Count);
            var SquaredNums = new List<int> ();
            foreach (int randNo in randomlist) {
                SquaredNums.Add (randNo * randNo);
            }
            System.Console.WriteLine(SquaredNums.Count);
            foreach (int num in SquaredNums)
            {
                System.Console.WriteLine(num);
            }

            SquaredNums.RemoveAll (number => number % 2 == 0);
            foreach (int num in SquaredNums)
            {
                System.Console.WriteLine(num);
            }
        }
    }
}