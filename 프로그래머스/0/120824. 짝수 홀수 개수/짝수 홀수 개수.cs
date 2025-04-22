using System;

// 작동 확인 중 확인 중
public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        int odd = 0;
        int even = 0;
        for(int i = 0; i<num_list.Length; i++)
        {
            if (num_list[i]% 2 == 0)
            {
                ++even;
            }
            else
            {
                ++odd;
            }
        }
        answer[0] = even;
        answer[1] = odd;
        return answer;
    }
}