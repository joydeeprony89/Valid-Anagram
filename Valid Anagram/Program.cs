using System;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram", t = "nagaram";
            Console.WriteLine(IsAnagram(s, t));
        }

        static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] hash = new int[26];

            foreach (char c in s)
                hash[c - 'a']++;

            foreach (char c in t)
            {
                hash[c - 'a']--;
                if (hash[c - 'a'] < 0)
                    return false;
            }
            return true;
        }
    }
}
