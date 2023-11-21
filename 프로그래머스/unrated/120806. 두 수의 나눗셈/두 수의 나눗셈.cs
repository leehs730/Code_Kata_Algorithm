using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        double result = 0;
        result = (double)num1 / (double)num2;
        answer = (int)(result*1000);
        return answer;
    }
}