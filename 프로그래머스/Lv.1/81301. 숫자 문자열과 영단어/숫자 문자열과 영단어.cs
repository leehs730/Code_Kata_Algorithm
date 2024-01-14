using System;

public class Solution {
    public int solution(string s) {
        string[] str_list = new string[] {"zero", "one", "two", "three", "four","five", "six", "seven", "eight", "nine"};
        string[] num_list = new string[] {"0", "1", "2", "3", "4", "5","6", "7", "8", "9"};
        string s_answer = s;
        for(int i = 0; i< 10; i++)
        {
            s_answer = s_answer.Replace(str_list[i], num_list[i]);
        }
        int answer = Int32.Parse(s_answer);
        return answer;
    }
}