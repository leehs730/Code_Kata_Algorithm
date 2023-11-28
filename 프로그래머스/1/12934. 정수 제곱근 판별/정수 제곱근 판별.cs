using System;

public class Solution {
    public long solution(long n) {
        long x = (long)Math.Sqrt(n);
        return (x*x == n) ? (x+1)*(x+1) : -1;
        // 초기 실행 정답 코드, 제출 후 체점하면 반 이상 시간 초과로 탈락됨
        // for(int i = 1; i<n; i++)
        // {
        //     if(i*i == n){
        //         answer = (i+1)*(i+1);
        //         break;
        //     } 
        //     else if(i*i >= n) break;
        //     else answer = -1;
        // }
    }
}