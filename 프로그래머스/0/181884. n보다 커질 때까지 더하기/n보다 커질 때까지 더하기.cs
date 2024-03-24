using System;
// 백준허브 테스트
public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        for(int i = 0; i<numbers.Length; i++)
        {
            answer += numbers[i];
            if(answer > n) break;
        }
        return answer;
    }
}