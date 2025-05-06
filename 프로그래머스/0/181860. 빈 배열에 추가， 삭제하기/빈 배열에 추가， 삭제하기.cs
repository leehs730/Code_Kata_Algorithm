using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> xList = new List<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            if(flag[i])
            {
                for(int j = 0; j<arr[i]; j++)
                {
                    xList.Add(arr[i]);
                    xList.Add(arr[i]);
                }

            }
            else
            {
                for(int k = 0; k<arr[i]; k++)
                    xList.RemoveRange(xList.Count -1, 1);
            }
        }
        int[] answer = xList.ToArray();
        return answer;
    }
}