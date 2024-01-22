using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> sum_list = new List<int>();
        for(int i = 0; i<numbers.Length-1; i++)
        {
            int sum = 0;
            for(int j = i+1; j<numbers.Length; j++)
            {
                sum = numbers[i] + numbers[j];
                if(sum_list.Contains(sum))
                {
                    sum = 0;
                }
                else
                {
                    sum_list.Add(sum);
                }
                sum_list.Sort();
            }
        }
        
        int[] answer = sum_list.ToArray();
        return answer;
    }
}