using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        answer = arr;
        int temp = arr.Min();
        if(answer.Length == 1) answer[0] = -1;
        else
        {
            List<int> list = new List<int>(answer);
            list.Remove(temp);
            answer = list.ToArray();
        } 
        
        
        return answer;
    }
}