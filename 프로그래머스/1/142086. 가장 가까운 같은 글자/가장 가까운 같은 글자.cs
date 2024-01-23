// 방법은 현재 문자열 위치에서 앞에 가까운 똑같은 것을 찾는 것
using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        for(int i = 0; i< s.Length; i++)
        {
            int sol = -1;
            for(int j = i-1; j>= 0; j--)
            {
                if(s[i] == s[j])
                {
                    sol = i - j;
                    break;
                }
            }
            answer[i] = sol;
        }
        
        return answer;
    }
}