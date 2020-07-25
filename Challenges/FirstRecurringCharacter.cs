using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Challenges
{
    static public class FirstRecurringCharacter
    {
        public static string FindFirstRecurringCharacter(string s)
        {
            Dictionary<char, int> charRecord = new Dictionary<char, int>();
            foreach(var item in s)
            {
                if (charRecord.ContainsKey(item))
                    return $"First Recurring character is {item}";
                else
                    charRecord.Add(item, 1);
            }
            return "No Recurring character found";
        }
    }
}
