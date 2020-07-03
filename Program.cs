using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static string GetHours(ref List<int> nums)
    {
        int h1 = -1, h2 = -1;

        foreach (int i in Enumerable.Reverse(nums))
        {
            if (Enumerable.Range(0, 3).Contains(i))
            {
                h1 = i;
                nums.Remove(h1);
                break;
            }
        }

        if (h1 == 2)
        {
            foreach (int i in Enumerable.Reverse(nums))
            {
                if (Enumerable.Range(0, 5).Contains(i))
                {
                    h2 = i;
                    nums.Remove(h2);
                    break;
                }
            }
        }
        else
        {
            h2 = nums.Max();
            nums.Remove(h2);
        }

        return (Convert.ToString(h1) + Convert.ToString(h2));
    }

    static string GetMinutes(ref List<int> nums)
    {
        int m1 = -1, m2 = -1;

        foreach (int i in Enumerable.Reverse(nums))
        {
            if (Enumerable.Range(0, 6).Contains(i))
            {
                m1 = i;
                nums.Remove(m1);
                break;
            }
        }

        m2 = nums.Max();
        nums.Remove(m2);

        return (Convert.ToString(m1) + Convert.ToString(m2));
    }

    static string GetSeconds(ref List<int> nums)
    {
        int s1 = -1, s2 = -1;

        foreach (int i in Enumerable.Reverse(nums))
        {
            if (Enumerable.Range(0, 6).Contains(i))
            {
                s1 = i;
                nums.Remove(s1);
                break;
            }
        }

        s2 = nums.Max();
        nums.Remove(s2);

        return (Convert.ToString(s1) + Convert.ToString(s2));
    }

    static void Main(string[] args)
    {
        Console.Clear();

        List<int> nums = Console.ReadLine().Split(',').Select(x => Convert.ToInt32(x)).ToList();

        string H = GetHours(ref nums);
        if (H.Contains('-'))
        {
            Console.WriteLine("Impossible");
            Environment.Exit(0);
        }

        string M = GetMinutes(ref nums);
        if (M.Contains('-'))
        {
            Console.WriteLine("Impossible");
            Environment.Exit(0);
        }

        string S = GetSeconds(ref nums);
        if (S.Contains('-'))
        {
            Console.WriteLine("Impossible");
            Environment.Exit(0);
        }

        Console.WriteLine($"{H}:{M}:{S}");
        Console.WriteLine("Written in C# (.NET)");
    }
}