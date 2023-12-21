using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = s;
        answer = new String(answer.ToCharArray().OrderByDescending(x => x).ToArray());
        return answer;
    }
}