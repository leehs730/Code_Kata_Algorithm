using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int idx = num_list.Length;
        int[] answer = new int[idx+1];
        for(int i = 0; i<=idx-1; i++) answer[i] = num_list[i];
        if(num_list[idx-1]>num_list[idx-2]){
            answer[idx] = num_list[idx-1] - num_list[idx-2];
        }
        else{
            answer[idx] = num_list[idx-1] * 2;
        }
        return answer;
    }
}