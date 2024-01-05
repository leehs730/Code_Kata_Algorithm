using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long num = 0;
        
        for(int i = 0; i < t.Length - p.Length + 1; i++)
        {
            num = long.Parse(t.Substring(i, p.Length));
            if(num <= long.Parse(p))
            {
                answer++;
            }
            
        }
        /*
        int a = Int32.Parse(p); // 정수가 된 p
        int al = p.Length;  // 문자열 p의 길이
        for(int i = 0; i <= t.Length-al; i++)
        {
            string b = t.Substring(i, al);
            int bi = Int32.Parse(b);
            if(bi <= a) answer++;
        }
        */
        return answer;
    }
}