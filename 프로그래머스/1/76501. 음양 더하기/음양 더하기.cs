using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        int num = 0;
        for(int i = 0; i< absolutes.Length; i++)
        {
            num = signs[i] ? absolutes[i] : absolutes[i] * -1;
            answer += num;
        }
        return answer;
    }
}