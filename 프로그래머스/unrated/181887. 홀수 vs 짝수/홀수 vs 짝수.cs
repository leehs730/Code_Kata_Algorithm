using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int odd = 0;
        int nums = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            if(i % 2 == 0) odd += num_list[i];
            else nums += num_list[i];
        }
        if(odd < nums) answer = nums;
        else answer = odd;
        return answer;
    }
}