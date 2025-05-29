using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = my_string;
        string tmpStr = my_string.Substring(s, e - s +1);
        string reverseStr = new String(tmpStr.Reverse().ToArray());
        answer = answer.Replace(tmpStr, reverseStr);
        return answer;
    }
}