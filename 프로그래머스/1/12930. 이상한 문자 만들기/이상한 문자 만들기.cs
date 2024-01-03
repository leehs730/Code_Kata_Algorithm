using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] str = s.ToArray();
        int cnt = 0;
        for(int i = 0; i<s.Length; i++)
        {
            if(str[i] == ' ')
            {
                cnt = 0;
                answer += ' ';
            }
            else
            {
                if(cnt % 2 == 0)
                {
                    answer += str[i].ToString().ToUpper();
                }
                else
                {
                    answer += str[i].ToString().ToLower();
                }
                ++cnt;
            }
        }

        return answer;
    }
}