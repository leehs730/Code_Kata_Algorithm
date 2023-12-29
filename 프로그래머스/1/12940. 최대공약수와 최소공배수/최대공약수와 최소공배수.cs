using System;

public class Solution {
    public int[] solution(int n, int m) {
        // 유클리드 호제법을 사용해서 최대공약수를 구한 다음
        // 최소 공배수는 구하는 두 수의 곱에서 최대공약수를 나누어서 구한다        
        int[] answer = new int[2];
        int min = 0; // min은 최대공약수
        int max = 0; // max는 최소공배수
        
        min = gcd(n, m);
        max = (n*m) / min;
        
        answer[0] = min;
        answer[1] = max;
                
        return answer;
    }
    public int gcd(int n, int m)
    {
        if(m == 0) return n;
        else return gcd(m, n%m);
    }
}