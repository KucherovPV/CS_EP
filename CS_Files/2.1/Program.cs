using System;
using System.Collections.Generic;

class Program
{
   public static void uniqueCombination(int l, int sum, int target, List<int> allCandidates, List<int> newCandidates)
    {
        if (sum == target)
        {
            Console.Write("[");
            for (int i = 0; i < allCandidates.Count; i++)
            {
                if (i != 0)
                {
                    Console.Write(" ");
                }

                Console.Write(allCandidates[i]);

                if (i != allCandidates.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

        }

        for (int i = l; i < newCandidates.Count; i++)
        {
            if (sum + newCandidates[i] > target)
            {
                continue;
            }

            if (i > l && newCandidates[i] == newCandidates[i - 1])
            {
                continue;
            }

            allCandidates.Add(newCandidates[i]);
            uniqueCombination(i + 1, sum + newCandidates[i], target, allCandidates, newCandidates);
            allCandidates.RemoveAt(allCandidates.Count - 1);
        }
    }


   public static void Combination(List<int> newCandidates, int target)
    {
        newCandidates.Sort();

        List<int> allCandidates = new List<int>();

        uniqueCombination(0, 0, target, allCandidates, newCandidates);
    }
    public static bool HowManyRep(int[] arr)
    {
        int check = 0;
        for(int i =0 ; i < arr.Length; i++)
        {
            for(int j =i+1; j < arr.Length-1; j++)
            {
                if (arr[i] == arr[j])
                {
                    check++;
                }
                else if (check >= 2)
                {
                    return true;
                }
                
              
            }
            check = 0;
        }
        return false;
    }

    public static void Main(String[] args)
    {
        // 1
        //int res = 0;
        //string s = "ab";
        //string j = "aabbccdb";
        //for (int i = 0; i < s.Length; i++)
        //{
        //    for (int k = 0; k < j.Length; k++)
        //    {
        //        if (s[i] == j[k])
        //        {
        //            res++;
        //        }
        //    }
        //}
        //Console.WriteLine(res);
        // 2
        //int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
        //List<int> newCandidates = new List<int>(candidates);

        //int target = 8;

        //Combination(newCandidates, target);
        // 3
        int[] array = { 1, 3, 4,  2,  };
        bool res = HowManyRep(array);
        Console.WriteLine(res);

    }
}  


            