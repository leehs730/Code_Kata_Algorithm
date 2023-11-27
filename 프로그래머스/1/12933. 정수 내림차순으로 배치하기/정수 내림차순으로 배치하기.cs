using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        char[] arr = n.ToString().ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        long answer = Convert.ToInt64(new String(arr));
        return answer;
    }
}