using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int m = num_list.Length/n;
        int[,] answer = new int[m, n];
        int index = 0;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                answer[i,j] = num_list[index];
                index++;
            }
        }
        return answer;
    }
}