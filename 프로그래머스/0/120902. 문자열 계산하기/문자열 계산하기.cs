using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        
        string[] sumArr = my_string.Split(" ");
        answer += int.Parse(sumArr[0]);
        
        for(int i = 0; i<sumArr.Length; i++)
        {
            if(sumArr[i] == "+")
                answer += int.Parse(sumArr[i+1]);
            else if(sumArr[i] == "-")
                answer -= int.Parse(sumArr[i+1]);
        }
        
        return answer;
    }
}