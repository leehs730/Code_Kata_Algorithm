using System;

public class Solution {
    public long solution(long n) {
        long x = (long)Math.Sqrt(n);
        return (x*x == n) ? (x+1)*(x+1) : -1;
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