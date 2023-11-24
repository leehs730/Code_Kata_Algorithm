using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string nst = n.ToString();
        int[] answer = new int[nst.Length];
        for(int i = 0; i< nst.Length; i++)
        {
            answer[i] = int.Parse(nst[i].ToString());
        }
        Array.Reverse(answer);
        return answer;
    }
}