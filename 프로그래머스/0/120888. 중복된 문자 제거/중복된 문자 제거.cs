using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        List<char> cList = new List<char>();
        foreach(char c in my_string)
        {
            if(!cList.Contains(c))
                cList.Add(c);
        }
        foreach(char c in cList)
            answer += c;
        return answer;
    }
}