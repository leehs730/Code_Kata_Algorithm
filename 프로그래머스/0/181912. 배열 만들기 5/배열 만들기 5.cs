using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> arr = new List<int>();
        foreach(string str in intStrs)
        {
            string tmp = str.Substring(s,l);
            int check = int.Parse(tmp);
            if(check > k)
                arr.Add(check);
        }
        int[] answer = arr.ToArray();
        return answer;
    }
}